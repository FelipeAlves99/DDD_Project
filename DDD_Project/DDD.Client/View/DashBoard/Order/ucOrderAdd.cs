using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Empresa.Domain.Entities;
using Empresa.Infra.Receita.Api;
using Newtonsoft.Json;

namespace CadstroEmpresaClient.View
{
    public partial class ucOrderAdd : UserControl
    {
        private Item _item = null;

        private Company _company = null;
        private IEnumerable<Company> _companies = null;

        private Pedido _order = null;

        private PedidoItem _orderItem = null;
        private List<PedidoItem> _orderItems = new List<PedidoItem>();


        private decimal _totalValue = 0;
        private decimal _lineValue = 0;


        public ucOrderAdd()
        {
            InitializeComponent();
            FillComboBox();
        }

        private async void btnSearch_Click(object sender, System.EventArgs e)
        {
            try
            {
                bool isNumber = int.TryParse(txtCode.Text, out int aux);

                if (isNumber)
                {
                    await SearchItem(txtCode.Text);
                    txtDescription.Text = _item.Descricao;
                    txtItemValue.Text = Convert.ToString(_item.PrecoVenda);
                    btnAdd.Enabled = true;
                }
                else
                    throw new Exception("Insira apenas números no campo de pesquisa.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Erro inesperado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (CheckDuplicates())
                {
                    int quantity = Convert.ToInt32(txtQuantity.Text);
                    _lineValue = _item.PrecoVenda * quantity;
                    txtNoDiscountValue.Text = SumValue(_item.PrecoVenda);

                    _order = new Pedido(_company, _company.Id, dtpOrder.Value, dtpDelivery.Value, Convert.ToDecimal(txtNoDiscountValue.Text), _orderItems);

                    _orderItem = new PedidoItem(_item.Id, quantity, _lineValue, _item, _order.Id);
                    _orderItems.Add(_orderItem);

                    if (txtDescription.Text != String.Empty)
                    {
                        dgvItemList.Rows.Add(_item.Id, _item.Descricao, quantity, _lineValue);
                        btnRemove.Enabled = true;
                        btnCancel.Enabled = true;
                        btnMakeOrder.Enabled = true;
                        btnAdd.Enabled = false;
                    }
                    else
                        throw new Exception("Quantidade de itens deve ser maior que 0");
                }
                else
                    throw new Exception("Este item já foi adicionado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Erro inesperado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            ClearFields(this.Controls);
        }

        private async void btnMakeOrder_Click(object sender, System.EventArgs e)
        {
            try
            {
                _order = new Pedido(_company, _company.Id, dtpOrder.Value, dtpDelivery.Value, Convert.ToDecimal(txtNoDiscountValue.Text), _orderItems);
                string jsonSerialized = JsonConvert.SerializeObject(_order);

                using (HttpResponseMessage responsePedido = await ApiHelper.ApiClient().PostAsync
                     ("https://localhost:5001/api/v1/Pedido",
                     new StringContent(jsonSerialized,
                     Encoding.UTF8,
                     "application/json")))
                {
                    var order = await responsePedido.Content.ReadAsAsync<Pedido>();
                    txtDiscount.Text = Convert.ToString(order.Desconto);
                    txtFinalValue.Text = Convert.ToString(order.ValorPosDesconto);

                    MessageBox.Show("Pedido " + order.Id + " efetuado.",
                        "Pedido realizado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Erro inesperado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dgvItemList.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    UpdateValue();

                    dgvItemList.Rows.RemoveAt(selectedIndex);
                    dgvItemList.Refresh();

                    CheckEmptyDGV();
                }
                else
                    throw new Exception("Deve selecionar um item a ser removido");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Erro inesperado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void cbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillClientBox();
            Pedido orderDate = new Pedido();
            orderDate.SetDateValues(_company.Uf);

            dtpDelivery.Value = orderDate.DataEntrega;
        }

        private async void FillComboBox()
        {
            try
            {
                using (HttpResponseMessage response = await ApiHelper.ApiClient().GetAsync("https://localhost:5001/api/v1/Empresas"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonCompany = await response.Content.ReadAsStringAsync();
                        _companies = JsonConvert.DeserializeObject<List<Company>>(jsonCompany);

                        cbClient.ValueMember = "Id";
                        cbClient.DisplayMember = "Nome";
                        cbClient.DataSource = _companies.ToList();

                        FillClientBox();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Servidor Local não está online",
                    "Erro com LocalHost",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async Task SearchItem(string SearchNumber)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient().GetAsync
                        ("https://localhost:5001/api/v1/Item?id=" + SearchNumber))
            {
                if (response.IsSuccessStatusCode)
                    _item = JsonConvert.DeserializeObject<Item>
                       (await response.Content.ReadAsStringAsync());
            }
        }

        private bool CheckDuplicates()
        {
            for (int i = 0; i < dgvItemList.Rows.Count; i++)
            {
                if (_item.Id == Convert.ToInt32(dgvItemList.Rows[i].Cells[0].Value))
                {
                    btnAdd.Enabled = false;
                    return false;
                }
            }
            return true;
        }

        private string SumValue(decimal value)
        {
            _totalValue += value * Convert.ToDecimal(txtQuantity.Text);
            return Convert.ToString(_totalValue);
        }

        private void UpdateValue()
        {
            if (dgvItemList.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvItemList.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvItemList.Rows[selectedrowindex];

                decimal currentRowValue = Convert.ToDecimal(selectedRow.Cells["columnValorLinha"].Value);

                int currentId = Convert.ToInt32(selectedRow.Cells["columnId"].Value);

                _totalValue -= currentRowValue;
                txtNoDiscountValue.Text = Convert.ToString(_totalValue);

                _orderItems.Remove(_orderItems.Where(pi => pi.ItemId == currentId).First());
            }
        }

        private void CheckEmptyDGV()
        {
            if (dgvItemList.Rows.Count == 0)
            {
                btnRemove.Enabled = false;
                btnMakeOrder.Enabled = false;
                btnCancel.Enabled = false;
            }
        }

        private void FillClientBox()
        {
            _company = _companies.Where(c => c.Id == Convert.ToInt32(cbClient.SelectedValue)).FirstOrDefault();
            txtClientName.Text = _company.Nome;
            masktxtCnpjClient.Text = _company.Cnpj;
            txtSituation.Text = _company.Situacao;
            txtState.Text = _company.Uf;
            txtPhone.Text = _company.Telefone;
        }

        private void ClearFields(ControlCollection controlCollection)
        {
            dgvItemList.Rows.Clear();

            foreach (Control control in controlCollection)
            {
                if (control is TextBoxBase)
                    control.Text = String.Empty;
                else
                    ClearFields(control.Controls);
            }
        }
    }
}

