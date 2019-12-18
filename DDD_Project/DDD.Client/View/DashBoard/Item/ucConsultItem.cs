using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Empresa.Domain.Entities;
using Empresa.Infra.Receita.Api;
using Newtonsoft.Json;

namespace CadstroEmpresaClient.View
{
    public partial class ucConsultItem : UserControl
    {
        private Item _item = null;
        private List<Item> _items = new List<Item>();
        private DataTable _dataTable = new DataTable();

        private string IdItem;

        public ucConsultItem()
        {
            InitializeComponent();
            SetDataTable();
            FillDataGrid();
            FirstState();
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            ClearField(this.Controls);
            FirstState();
        }

        private async void btnUpdate_Click(object sender, System.EventArgs e)
        {
            try
            {
                _item = new Item(
                    txtDescription.Text,
                    Convert.ToDecimal(txtBuyValue.Text),
                    Convert.ToDecimal(txtSellValue.Text),
                    Convert.ToInt32(txtQuantity.Text),
                    Convert.ToInt32(IdItem));

                string jsonObject = JsonConvert.SerializeObject(_item);

                using (HttpResponseMessage response = await ApiHelper.ApiClient().PutAsync
                    ("https://localhost:5001/api/v1/Item?id=" + IdItem,
                    new StringContent(jsonObject, Encoding.UTF8, "application/json")))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show
                            ("Registro atualizado com sucesso!",
                            "Atualização concluída",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        FirstState();
                        ClearField(this.Controls);

                        _dataTable.Clear();                                               
                        FillDataGrid();
                    }
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

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja mesmo deletar o item "
                    + txtDescription.Text + "?" + Environment.NewLine +
                    "Isso fará com que itens dos pedidos sejam deletados",
                    "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (HttpResponseMessage response = await ApiHelper.ApiClient().DeleteAsync
                        ("https://localhost:5001/api/v1/Item?id=" + IdItem))
                    {
                        MessageBox.Show("Cadastro do item " + txtDescription.Text + " foi deletado",
                            "Exclusão efetuada",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);                        

                        FirstState();
                        ClearField(this.Controls);

                        _dataTable.Clear();
                        FillDataGrid();
                    }
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

        private void ClearField(Control.ControlCollection controlCollection)
        {
            foreach (Control control in controlCollection)
            {
                if (control is TextBoxBase)
                    control.Text = String.Empty;
                else
                    ClearField(control.Controls);
            }
        }

        private void FirstState()
        {
            gbItem.Enabled = false;
            btnEdit.Enabled = true;
            txtSearch.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
            dgvItem.Enabled = true;
        }

        private void SecondState()
        {
            txtSearch.Enabled = false;
            btnEdit.Enabled = false;
            gbItem.Enabled = true;
            btnClear.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            dgvItem.Enabled = false;
        }

        public async void FillDataGrid()
        {
            try
            {
                _dataTable.Rows.Clear();

                using (HttpResponseMessage response = await ApiHelper.ApiClient().GetAsync
                    ("https://localhost:5001/api/v1/Item"))
                {
                    _items = await response.Content.ReadAsAsync<List<Item>>();

                    foreach (Item item in _items)
                    {
                        _dataTable.Rows.Add(item.Id, item.Descricao, item.PrecoCompra,
                            item.PrecoVenda, item.QuantidadeEstoque);
                    }

                    dgvItem.DataSource = _dataTable;
                }
            }
            catch
            {
                {
                    MessageBox.Show("Não foi possível conectar com o Host",
                        "Erro inesperado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _dataTable.DefaultView.RowFilter = "Convert(Id, 'System.String') Like '%" + txtSearch.Text + "%' ";
        }

        private void SetDataTable()
        {
            _dataTable.Columns.Add("Id", typeof(int));
            _dataTable.Columns.Add("Descrição", typeof(string));
            _dataTable.Columns.Add("Preço de Compra", typeof(decimal));
            _dataTable.Columns.Add("Preço de Venda", typeof(decimal));
            _dataTable.Columns.Add("Quantidade em Estoque", typeof(int));
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                bool isNumber = int.TryParse(txtSearch.Text, out int aux);

                if (isNumber || txtSearch.Text == string.Empty)
                {
                    foreach (DataGridViewRow row in dgvItem.SelectedRows) {
                        IdItem = row.Cells[0].Value.ToString();
                        txtDescription.Text = row.Cells[1].Value.ToString();
                        txtBuyValue.Text = row.Cells[2].Value.ToString();
                        txtSellValue.Text = row.Cells[3].Value.ToString();
                        txtQuantity.Text = row.Cells[4].Value.ToString();
                    }
                    SecondState();
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
    }
}
