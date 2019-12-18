using System;
using System.Text;
using System.Windows.Forms;
using Empresa.Domain.Entities;
using Newtonsoft.Json;
using System.Net.Http;
using Empresa.Infra.Receita.Api;
using System.Net;
using CadastroEmpresa.Models;
using System.Collections.Generic;
using System.Linq;

namespace CadstroEmpresaClient.View
{
    public partial class ucSearch : UserControl
    {
        private Company _companyModel = null;

        public ucSearch()
        {
            InitializeComponent();
        }

        private void masktxtCnpj_MouseClick(object sender, MouseEventArgs e)
        {
            if (masktxtCnpj.Text.Trim().Length == 0)
            {
                masktxtCnpj.Select(0, 0);
            }
            else
                masktxtCnpj.SelectionStart = masktxtCnpj.MaskedTextProvider.LastAssignedPosition + 1;
        }

        private void masktxtCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            masktxtCnpj.SelectionStart = masktxtCnpj.MaskedTextProvider.LastAssignedPosition + 1;
        }

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string JsonSerialized = JsonConvert.SerializeObject(_companyModel);

                using (HttpResponseMessage response = await ApiHelper.ApiClient().PostAsync
                    ("https://localhost:5001/api/v1/Empresas",
                    new StringContent(JsonSerialized,
                    Encoding.UTF8,
                    "application/json")))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show
                            ("Empresa cadastrada com sucesso.",
                            "Cadastro Conluído",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        btnCadastrar.Enabled = false;
                    }
                    else if (response.StatusCode == HttpStatusCode.BadRequest)
                        throw new HttpRequestException("Solicitação de pesquisa errada ou má informada");

                    else if (response.StatusCode == HttpStatusCode.Conflict)
                        throw new HttpRequestException("Já existe um cadastro para a empresa " + _companyModel.Nome + ".");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message,
                    "Erro na solicitação HTTP",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Erro inesperado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private async void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                bool isNumber = double.TryParse(masktxtCnpj.Text, out double aux);

                if (masktxtCnpj.Text != "" && isNumber)
                {
                    using (HttpResponseMessage response = await ApiHelper.ApiClient().GetAsync
                        ("https://localhost:5001/api/v1/Receita?cnpj=" + masktxtCnpj.Text))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string stringJson = await response.Content.ReadAsStringAsync();
                            _companyModel = JsonConvert.DeserializeObject<Company>(stringJson);
                            FillField();
                            btnCadastrar.Enabled = true;
                        }
                        else if (response.StatusCode == HttpStatusCode.NotFound)
                            throw new HttpRequestException("Muitas solitações.\nFazer no máximo 3 por minuto.");

                        else if (response.StatusCode == HttpStatusCode.BadRequest)
                            throw new HttpRequestException("Solicitação de pesquisa errada ou má informada.");
                    }
                }
                else
                    throw new FormatException("Insira apenas números.");
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message,
                "Erro HTTP",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message,
                "Erro de formatação",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                "Erro inesperado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void FillField()
        {
            masktxtCnpjInfo.Text = _companyModel.Cnpj;
            lblTipoInfo.Text = _companyModel.Tipo;
            lblDataAberturaInfo.Text = _companyModel.Abertura;
            lblNomeEmpresarialInfo.Text = _companyModel.Nome;
            lblNomeFantasiaInfo.Text = _companyModel.Fantasia;

            lblAtividadePrincipalInfo.Text = null;
            List<Atividade_Principal> principals = _companyModel.Atividade_Principal.ToList();
            foreach (Atividade_Principal principal in principals)
            {
                lblAtividadePrincipalInfo.Text = principal.Code + " - " + principal.Text;
            }

            txtSecundaria.Text = null;
            List<Atividade_Secundaria> secundarias = _companyModel.Atividades_Secundarias.ToList();
            foreach (Atividade_Secundaria secundaria in secundarias)
            {
                txtSecundaria.Text += secundaria.Code + " - " + secundaria.Text + Environment.NewLine;
            }

            lblPorteInfo.Text = _companyModel.Porte;
            lblNaturezaJuridicaInfo.Text = _companyModel.Natureza_Juridica;
            lblLogradouroInfo.Text = _companyModel.Logradouro;
            lblNumeroInfo.Text = _companyModel.Numero;
            lblCepInfo.Text = _companyModel.Cep;
            lblBairroInfo.Text = _companyModel.Bairro;
            lblMunicipioInfo.Text = _companyModel.Municipio;
            lblUfInfo.Text = _companyModel.Uf;
            lblEmailInfo.Text = _companyModel.Email;
            lblTelefoneInfo.Text = _companyModel.Telefone;
            lblEfrInfo.Text = _companyModel.Efr;
            lblCadastralInfo.Text = _companyModel.Situacao;
            lblDtCadastralInfo.Text = _companyModel.Data_Situacao;
            lblDtEspecialInfo.Text = _companyModel.Data_Situacao_Especial;
            lblEspecialInfo.Text = _companyModel.Situacao_Especial;
            lblMotivoInfo.Text = _companyModel.Motivo_situacao;
        }
    }
}
