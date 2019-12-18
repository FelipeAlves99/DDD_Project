using Empresa.Domain.Entities;
using Empresa.Infra.Receita.Api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace CadstroEmpresaClient.View
{
    public partial class ucConsultOrder : UserControl
    {
        private Pedido _order = null;
        List<PedidoItem> _orderItems = null;
        private Item _item = null;
        private Company _company = null;

        public ucConsultOrder()
        {
            InitializeComponent();
            cbOrderStatus.DataSource = Enum.GetValues(typeof(Pedido.PedidoStatus));
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (HttpResponseMessage response = await ApiHelper.ApiClient().GetAsync(
                    "https://localhost:5001/api/v1/Pedido?id=" + txtCode.Text))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        _order = await response.Content.ReadAsAsync<Pedido>();
                        _company = _order.Company;
                        FillField();

                        cbOrderStatus.Enabled = true;
                        btnUpdate.Enabled = true;
                        btnCancel.Enabled = true;
                        btnSearch.Enabled = false;
                        txtCode.Enabled = false;
                    }
                    else if (response.StatusCode == HttpStatusCode.NotFound)
                        throw new HttpRequestException("Este pedido não está cadastrada.");

                    else if (response.StatusCode == HttpStatusCode.BadRequest)
                        throw new HttpRequestException("Solicitação de pesquisa errada ou má informada");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message, "Erro HTTP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FirstState(this.Controls);
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido.PedidoStatus status = (Pedido.PedidoStatus)Enum.Parse(typeof(Pedido.PedidoStatus),
                    cbOrderStatus.SelectedItem.ToString());
                Pedido pedido = new Pedido(_order.Id, status);
                string jsonSerialized = JsonConvert.SerializeObject(pedido);

                HttpContent httpContent = new StringContent(jsonSerialized, Encoding.UTF8, "application/json");
                await HttpPatchExtension.PatchAsync(ApiHelper.ApiClient(),
                    new Uri("https://localhost:5001/api/v1/Pedido/" + _order.Id),
                    httpContent);

                MessageBox.Show("Atualização do status foi bem sucedida", "Atualização completa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FirstState(this.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FillDataGrid(int quantidade, decimal valorLinha)
        {
            dgvItemList.Rows.Add(
                _item.Id,
                _item.Descricao,
                quantidade,
                valorLinha);
        }

        private void FillField()
        {
            dtpOrderDate.Value = _order.DataPedido;
            dtpOrderDelivery.Value = _order.DataEntrega;
            cbOrderStatus.Text = Convert.ToString(_order.StatusPedido);
            txtDiscount.Text = Convert.ToString(_order.Desconto);
            txtFinalPrice.Text = Convert.ToString(_order.ValorPosDesconto);

            txtClientName.Text = _company.Nome;
            masktxtCnpjClient.Text = _company.Cnpj;
            txtSituation.Text = _company.Situacao;
            txtState.Text = _company.Uf;
            txtPhone.Text = _company.Telefone;

            _orderItems = _order.PedidoItem.ToList();

            foreach (PedidoItem pedidoItem in _orderItems)
            {
                _item = pedidoItem.Item;
                int quantidade = pedidoItem.Quantidade;
                decimal valorLinha = pedidoItem.ValorTotalLinha;

                FillDataGrid(quantidade, valorLinha);
            }
        }

        private void FirstState(ControlCollection controlCollection)
        {
            cbOrderStatus.Enabled = false;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
            btnSearch.Enabled = true;
            txtCode.Enabled = true;

            dgvItemList.Rows.Clear();

            foreach (Control control in controlCollection)
            {
                if (control is TextBoxBase)
                    control.Text = String.Empty;
                else
                    FirstState(control.Controls);
            }
        }
    }
}
