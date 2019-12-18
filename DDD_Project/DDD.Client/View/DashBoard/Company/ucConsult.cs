using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Empresa.Infra.Receita.Api;
using System.Net;
using Empresa.Domain.Entities;
using Newtonsoft.Json;
using CadastroEmpresa.Models;

namespace CadstroEmpresaClient.View
{
    public partial class ucConsult : UserControl
    {
        private bool _canUpdate;
        private string _jsonEmpresa;
        private string _jsonComparer;
        private Company _companyModel = null;

        public ucConsult()
        {
            InitializeComponent();
        }        

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbCnpj.Checked == true)
                {
                    using (HttpResponseMessage response = await ApiHelper.ApiClient().GetAsync
                        ("https://localhost:5001/api/v1/Empresas/Search?cnpj=" + masktxtPesquisa.Text))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string stringJson = await response.Content.ReadAsStringAsync();
                            _companyModel = JsonConvert.DeserializeObject<Company>(stringJson);
                            LoadInformation(_companyModel);
                            btnAtualizar.Enabled = true;
                            btnDeletar.Enabled = true;
                        }
                        else if (response.StatusCode == HttpStatusCode.NotFound)
                        {
                            btnAtualizar.Enabled = false;
                            btnDeletar.Enabled = false;
                            ClearField();
                            throw new HttpRequestException("Esta empresa não está cadastrada.");
                        }
                        else if (response.StatusCode == HttpStatusCode.BadRequest)
                        {
                            btnAtualizar.Enabled = false;
                            btnDeletar.Enabled = false;
                            ClearField();
                            throw new HttpRequestException("Solicitação de pesquisa errada ou má informada");
                        }
                    }
                }
                else
                {
                    using (HttpResponseMessage response = await ApiHelper.ApiClient().GetAsync
                        ("https://localhost:5001/api/v1/Empresas/Search?fantasia=" + masktxtPesquisa.Text))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string stringJson = await response.Content.ReadAsStringAsync();
                            _companyModel = JsonConvert.DeserializeObject<Company>(stringJson);
                            LoadInformation(_companyModel);
                            btnAtualizar.Enabled = true;
                            btnDeletar.Enabled = true;
                        }
                        else if (response.StatusCode == HttpStatusCode.NotFound)
                        {
                            btnAtualizar.Enabled = false;
                            btnDeletar.Enabled = false;
                            ClearField();
                            throw new HttpRequestException("Esta empresa não está cadastrada.");
                        }
                        else if (response.StatusCode == HttpStatusCode.BadRequest)
                        {
                            btnAtualizar.Enabled = false;
                            btnDeletar.Enabled = false;
                            ClearField();
                            throw new HttpRequestException("Solicitação de pesquisa errada ou má informada.");                            
                        }
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show
                    (ex.Message,
                    "Erro na solicitação HTTP",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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

        private async void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                await CheckInfo();
                if (_canUpdate == true)
                {
                    using (HttpResponseMessage response = await ApiHelper.ApiClient().PutAsync
                        ("https://localhost:5001/api/v1/Empresas/" + masktxtCnpj.Text,
                        new StringContent(_jsonComparer,
                        Encoding.UTF8,
                        "application/json")))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show
                                ("Registro atualizado com sucesso!",
                                "Atualização concluída",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            btnAtualizar.Enabled = false;
                        }
                        else if (response.StatusCode == HttpStatusCode.NotFound)
                        {
                            throw new HttpRequestException("Esta empresa não está cadastrada.");
                        }
                        else if (response.StatusCode == HttpStatusCode.BadRequest)
                        {
                            throw new HttpRequestException("Solicitação de pesquisa errada ou má informada");
                        }
                    }
                }
                else
                {
                    MessageBox.Show
                        ("Não houve nenhuma atualizações no registro da Receita Federal",
                        "Falha ao atualizar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
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

        private async void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                    "Deseja mesmo deletar o registro da " + lblNomeEmpresarialInfo.Text + "?",
                    "Solicitação de exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (HttpResponseMessage response = await ApiHelper.ApiClient().DeleteAsync
                        ("https://localhost:5001/api/v1/Empresas/" + masktxtCnpj.Text))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Cadastro da empresa " + lblNomeEmpresarialInfo.Text + " foi deletado",
                                "Exclusão efetuada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            btnAtualizar.Enabled = false;
                            btnDeletar.Enabled = false;
                            ClearField();
                        }
                        else if (response.StatusCode == HttpStatusCode.NotFound)
                        {
                            throw new HttpRequestException("Esta empresa não está cadastrada.");
                        }
                        else if (response.StatusCode == HttpStatusCode.BadRequest)
                        {
                            throw new HttpRequestException("Solicitação de pesquisa errada ou má informada");
                        }
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show
                    (ex.Message, "Erro na solicitação HTTP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Erro inesperado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void masktxtPesquisa_MouseClick(object sender, MouseEventArgs e)
        {
            if (masktxtPesquisa.Text.Trim().Length == 0)
            {
                masktxtPesquisa.Select(0, 0);
            }
            else
            {
                if (rbCnpj.Checked)
                {
                    masktxtPesquisa.SelectionStart = masktxtPesquisa.MaskedTextProvider.LastAssignedPosition + 1;
                }
            }
        }

        private void masktxtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbCnpj.Checked)
            {
                masktxtPesquisa.SelectionStart = masktxtPesquisa.MaskedTextProvider.LastAssignedPosition + 1;
            }
        }

        private void rbCnpj_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCnpj.Checked == false)
            {
                masktxtPesquisa.Mask = null;
                masktxtPesquisa.Focus();
                masktxtPesquisa.Text = null;                
            }
            else
            {
                masktxtPesquisa.Mask = "00.000.000/0000-00";
                masktxtPesquisa.Focus();
                masktxtPesquisa.Text = null;                
            }
        }

        public void LoadInformation(Company company)
        {
            try
            {
                _jsonEmpresa = JsonConvert.SerializeObject(company);
                masktxtCnpj.Text = company.Cnpj;
                lblTipoInfo.Text = company.Tipo;
                lblDataAberturaInfo.Text = company.Abertura;
                lblNomeEmpresarialInfo.Text = company.Nome;
                lblNomeFantasiaInfo.Text = company.Fantasia;

                lblAtividadePrincipalInfo.Text = null;
                List<Atividade_Principal> principals = company.Atividade_Principal.ToList();
                foreach (Atividade_Principal principal in principals)
                {
                    lblAtividadePrincipalInfo.Text = principal.Code + " - " + principal.Text;
                }

                txtSecundaria.Text = null;
                List<Atividade_Secundaria> secundarias = company.Atividades_Secundarias.ToList();
                foreach (Atividade_Secundaria secundaria in secundarias)
                {
                    txtSecundaria.Text += secundaria.Code + " - " + secundaria.Text + Environment.NewLine;
                }

                lblPorteInfo.Text = company.Porte;
                lblNaturezaJuridicaInfo.Text = company.Natureza_Juridica;
                lblLogradouroInfo.Text = company.Logradouro;
                lblNumeroInfo.Text = company.Numero;
                lblCepInfo.Text = company.Cep;
                lblBairroInfo.Text = company.Bairro;
                lblMunicipioInfo.Text = company.Municipio;
                lblUfInfo.Text = company.Uf;
                lblEmailInfo.Text = company.Email;
                lblTelefoneInfo.Text = company.Telefone;
                lblEfrInfo.Text = company.Efr;
                lblCadastralInfo.Text = company.Situacao;
                lblDtCadastralInfo.Text = company.Data_Situacao;
                lblDtEspecialInfo.Text = company.Data_Situacao_Especial;
                lblEspecialInfo.Text = company.Situacao_Especial;
                lblMotivoInfo.Text = company.Motivo_situacao;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao carregar a empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task CheckInfo()
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient().GetAsync
                       ("https://localhost:5001/api/v1/Receita?cnpj=" + masktxtCnpj.Text))
            {
                string stringJson = await response.Content.ReadAsStringAsync();
                var company = JsonConvert.DeserializeObject<Company>(stringJson);
                company.SetId(_companyModel.Id);
                _jsonComparer = JsonConvert.SerializeObject(company);

                if (_jsonComparer == _jsonEmpresa)
                {
                    _canUpdate = false;
                }
                else
                {
                    ClearField();
                    LoadInformation(company);
                    _canUpdate = true;
                }
            }
        }

        public void ClearField()
        {
            masktxtCnpj.Text = null;
            lblTipoInfo.Text = null;
            lblDataAberturaInfo.Text = null;
            lblNomeEmpresarialInfo.Text = null;
            lblNomeFantasiaInfo.Text =null;
            lblPorteInfo.Text = null;
            lblNaturezaJuridicaInfo.Text = null;
            lblAtividadePrincipalInfo.Text = null;
            txtSecundaria.Text = null;
            lblLogradouroInfo.Text = null;
            lblNumeroInfo.Text = null;
            lblCepInfo.Text = null;
            lblBairroInfo.Text = null;
            lblMunicipioInfo.Text = null;
            lblUfInfo.Text = null;
            lblEmailInfo.Text = null;
            lblTelefoneInfo.Text = null;
            lblEfrInfo.Text = null;
            lblCadastralInfo.Text = null;
            lblDtCadastralInfo.Text = null;
            lblDtEspecialInfo.Text = null;
            lblEspecialInfo.Text = null;
            lblMotivoInfo.Text = null;
        }
    }
}
