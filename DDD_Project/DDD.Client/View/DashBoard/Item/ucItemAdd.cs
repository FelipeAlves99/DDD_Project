using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Empresa.Domain.Entities;
using Empresa.Infra.Receita.Api;
using Newtonsoft.Json;

namespace CadstroEmpresaClient.View.MDI
{
    public partial class ucItemAdd : UserControl
    {
        public ucItemAdd()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields(this.Controls);
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Item item = new Item(
                    descricao: txtDescription.Text,
                    precoCompra: Convert.ToDecimal(txtBuyValue.Text),
                    precoVenda: Convert.ToDecimal(txtSellValue.Text),
                    quantidadeEstoque: Convert.ToInt32(txtQuantity.Text));

                string jsonSerialized = JsonConvert.SerializeObject(item);

                using (HttpResponseMessage response = await ApiHelper.ApiClient().PostAsync
                    ("https://localhost:5001/api/v1/Item",
                    new StringContent(jsonSerialized,
                    Encoding.UTF8,
                    "application/json")))
                {
                    MessageBox.Show
                        ("Item cadastrada com sucesso.",
                        "Cadastro Conluído",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (ex.Message,
                    "Erro inesperado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ClearFields(ControlCollection controlCollection)
        {            
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
