namespace CadstroEmpresaClient.View
{
    partial class ucSearch
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.masktxtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.masktxtCnpjInfo = new System.Windows.Forms.MaskedTextBox();
            this.txtSecundaria = new System.Windows.Forms.TextBox();
            this.lblMotivoInfo = new System.Windows.Forms.Label();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.lblDtCadastralInfo = new System.Windows.Forms.Label();
            this.lblDtCadastra = new System.Windows.Forms.Label();
            this.lblEfrInfo = new System.Windows.Forms.Label();
            this.lblEfr = new System.Windows.Forms.Label();
            this.lblTelefoneInfo = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblDtEspecialInfo = new System.Windows.Forms.Label();
            this.lblDtEspecial = new System.Windows.Forms.Label();
            this.lblEspecialInfo = new System.Windows.Forms.Label();
            this.lblEspecial = new System.Windows.Forms.Label();
            this.lblCadastralInfo = new System.Windows.Forms.Label();
            this.lblCadastral = new System.Windows.Forms.Label();
            this.lblEmailInfo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUfInfo = new System.Windows.Forms.Label();
            this.lblMunicipioInfo = new System.Windows.Forms.Label();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.lblCepInfo = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblBairroInfo = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblNumeroInfo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblTipoInfo = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblLogradouroInfo = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblNomeEmpresarial = new System.Windows.Forms.Label();
            this.lblNaturezaJuridicaInfo = new System.Windows.Forms.Label();
            this.lblNaturezaJuridica = new System.Windows.Forms.Label();
            this.lblAtividadeSecundaria = new System.Windows.Forms.Label();
            this.lblAtividadePrincipalInfo = new System.Windows.Forms.Label();
            this.lblPorteInfo = new System.Windows.Forms.Label();
            this.lblAtividadePrincipal = new System.Windows.Forms.Label();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.lblNomeFantasiaInfo = new System.Windows.Forms.Label();
            this.lblPorte = new System.Windows.Forms.Label();
            this.lblNomeEmpresarialInfo = new System.Windows.Forms.Label();
            this.lblDataAberturaInfo = new System.Windows.Forms.Label();
            this.lblDtAbertura = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // masktxtCnpj
            // 
            this.masktxtCnpj.BackColor = System.Drawing.Color.Snow;
            this.masktxtCnpj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.masktxtCnpj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masktxtCnpj.Location = new System.Drawing.Point(113, 33);
            this.masktxtCnpj.Mask = "00,000,000/0000-00";
            this.masktxtCnpj.Name = "masktxtCnpj";
            this.masktxtCnpj.Size = new System.Drawing.Size(123, 16);
            this.masktxtCnpj.TabIndex = 11;
            this.masktxtCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.masktxtCnpj.MouseClick += new System.Windows.Forms.MouseEventHandler(this.masktxtCnpj_MouseClick);
            this.masktxtCnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.masktxtCnpj_KeyPress);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(759, 7);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(94, 42);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "CNPJ para pesquisa";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(13, 7);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(94, 42);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.masktxtCnpjInfo);
            this.gbInfo.Controls.Add(this.txtSecundaria);
            this.gbInfo.Controls.Add(this.lblMotivoInfo);
            this.gbInfo.Controls.Add(this.lblMotivo);
            this.gbInfo.Controls.Add(this.lblDtCadastralInfo);
            this.gbInfo.Controls.Add(this.lblDtCadastra);
            this.gbInfo.Controls.Add(this.lblEfrInfo);
            this.gbInfo.Controls.Add(this.lblEfr);
            this.gbInfo.Controls.Add(this.lblTelefoneInfo);
            this.gbInfo.Controls.Add(this.lblTelefone);
            this.gbInfo.Controls.Add(this.lblDtEspecialInfo);
            this.gbInfo.Controls.Add(this.lblDtEspecial);
            this.gbInfo.Controls.Add(this.lblEspecialInfo);
            this.gbInfo.Controls.Add(this.lblEspecial);
            this.gbInfo.Controls.Add(this.lblCadastralInfo);
            this.gbInfo.Controls.Add(this.lblCadastral);
            this.gbInfo.Controls.Add(this.lblEmailInfo);
            this.gbInfo.Controls.Add(this.lblEmail);
            this.gbInfo.Controls.Add(this.lblUfInfo);
            this.gbInfo.Controls.Add(this.lblMunicipioInfo);
            this.gbInfo.Controls.Add(this.lblMunicipio);
            this.gbInfo.Controls.Add(this.lblUf);
            this.gbInfo.Controls.Add(this.lblCepInfo);
            this.gbInfo.Controls.Add(this.lblCep);
            this.gbInfo.Controls.Add(this.lblBairroInfo);
            this.gbInfo.Controls.Add(this.lblBairro);
            this.gbInfo.Controls.Add(this.lblNumeroInfo);
            this.gbInfo.Controls.Add(this.lblTipo);
            this.gbInfo.Controls.Add(this.lblTipoInfo);
            this.gbInfo.Controls.Add(this.lblNumero);
            this.gbInfo.Controls.Add(this.lblLogradouroInfo);
            this.gbInfo.Controls.Add(this.lblLogradouro);
            this.gbInfo.Controls.Add(this.lblNomeEmpresarial);
            this.gbInfo.Controls.Add(this.lblNaturezaJuridicaInfo);
            this.gbInfo.Controls.Add(this.lblNaturezaJuridica);
            this.gbInfo.Controls.Add(this.lblAtividadeSecundaria);
            this.gbInfo.Controls.Add(this.lblAtividadePrincipalInfo);
            this.gbInfo.Controls.Add(this.lblPorteInfo);
            this.gbInfo.Controls.Add(this.lblAtividadePrincipal);
            this.gbInfo.Controls.Add(this.lblNomeFantasia);
            this.gbInfo.Controls.Add(this.lblNomeFantasiaInfo);
            this.gbInfo.Controls.Add(this.lblPorte);
            this.gbInfo.Controls.Add(this.lblNomeEmpresarialInfo);
            this.gbInfo.Controls.Add(this.lblDataAberturaInfo);
            this.gbInfo.Controls.Add(this.lblDtAbertura);
            this.gbInfo.Controls.Add(this.lblCnpj);
            this.gbInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.Location = new System.Drawing.Point(13, 58);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(839, 462);
            this.gbInfo.TabIndex = 9;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Informações da Empresa";
            // 
            // masktxtCnpjInfo
            // 
            this.masktxtCnpjInfo.BackColor = System.Drawing.Color.Snow;
            this.masktxtCnpjInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.masktxtCnpjInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masktxtCnpjInfo.Location = new System.Drawing.Point(9, 42);
            this.masktxtCnpjInfo.Mask = "00,000,000/0000-00";
            this.masktxtCnpjInfo.Name = "masktxtCnpjInfo";
            this.masktxtCnpjInfo.ReadOnly = true;
            this.masktxtCnpjInfo.Size = new System.Drawing.Size(115, 15);
            this.masktxtCnpjInfo.TabIndex = 51;
            this.masktxtCnpjInfo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtSecundaria
            // 
            this.txtSecundaria.BackColor = System.Drawing.Color.Snow;
            this.txtSecundaria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSecundaria.Location = new System.Drawing.Point(9, 162);
            this.txtSecundaria.Multiline = true;
            this.txtSecundaria.Name = "txtSecundaria";
            this.txtSecundaria.ReadOnly = true;
            this.txtSecundaria.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSecundaria.Size = new System.Drawing.Size(823, 91);
            this.txtSecundaria.TabIndex = 50;
            // 
            // lblMotivoInfo
            // 
            this.lblMotivoInfo.AutoSize = true;
            this.lblMotivoInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivoInfo.Location = new System.Drawing.Point(324, 379);
            this.lblMotivoInfo.Name = "lblMotivoInfo";
            this.lblMotivoInfo.Size = new System.Drawing.Size(12, 17);
            this.lblMotivoInfo.TabIndex = 49;
            this.lblMotivoInfo.Text = "-";
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(324, 363);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(191, 17);
            this.lblMotivo.TabIndex = 48;
            this.lblMotivo.Text = "Motivo da Situação Cadastral:";
            // 
            // lblDtCadastralInfo
            // 
            this.lblDtCadastralInfo.AutoSize = true;
            this.lblDtCadastralInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtCadastralInfo.Location = new System.Drawing.Point(138, 379);
            this.lblDtCadastralInfo.Name = "lblDtCadastralInfo";
            this.lblDtCadastralInfo.Size = new System.Drawing.Size(12, 17);
            this.lblDtCadastralInfo.TabIndex = 47;
            this.lblDtCadastralInfo.Text = "-";
            // 
            // lblDtCadastra
            // 
            this.lblDtCadastra.AutoSize = true;
            this.lblDtCadastra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtCadastra.Location = new System.Drawing.Point(138, 363);
            this.lblDtCadastra.Name = "lblDtCadastra";
            this.lblDtCadastra.Size = new System.Drawing.Size(178, 17);
            this.lblDtCadastra.TabIndex = 46;
            this.lblDtCadastra.Text = "Data da Situação Cadastral:";
            // 
            // lblEfrInfo
            // 
            this.lblEfrInfo.AutoSize = true;
            this.lblEfrInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEfrInfo.Location = new System.Drawing.Point(419, 327);
            this.lblEfrInfo.Name = "lblEfrInfo";
            this.lblEfrInfo.Size = new System.Drawing.Size(12, 17);
            this.lblEfrInfo.TabIndex = 45;
            this.lblEfrInfo.Text = "-";
            // 
            // lblEfr
            // 
            this.lblEfr.AutoSize = true;
            this.lblEfr.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEfr.Location = new System.Drawing.Point(419, 311);
            this.lblEfr.Name = "lblEfr";
            this.lblEfr.Size = new System.Drawing.Size(184, 17);
            this.lblEfr.TabIndex = 44;
            this.lblEfr.Text = "Ente Federativo Responsável:";
            // 
            // lblTelefoneInfo
            // 
            this.lblTelefoneInfo.AutoSize = true;
            this.lblTelefoneInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneInfo.Location = new System.Drawing.Point(239, 327);
            this.lblTelefoneInfo.Name = "lblTelefoneInfo";
            this.lblTelefoneInfo.Size = new System.Drawing.Size(12, 17);
            this.lblTelefoneInfo.TabIndex = 43;
            this.lblTelefoneInfo.Text = "-";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(239, 311);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(62, 17);
            this.lblTelefone.TabIndex = 42;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblDtEspecialInfo
            // 
            this.lblDtEspecialInfo.AutoSize = true;
            this.lblDtEspecialInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtEspecialInfo.Location = new System.Drawing.Point(138, 432);
            this.lblDtEspecialInfo.Name = "lblDtEspecialInfo";
            this.lblDtEspecialInfo.Size = new System.Drawing.Size(12, 17);
            this.lblDtEspecialInfo.TabIndex = 41;
            this.lblDtEspecialInfo.Text = "-";
            // 
            // lblDtEspecial
            // 
            this.lblDtEspecial.AutoSize = true;
            this.lblDtEspecial.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtEspecial.Location = new System.Drawing.Point(138, 416);
            this.lblDtEspecial.Name = "lblDtEspecial";
            this.lblDtEspecial.Size = new System.Drawing.Size(169, 17);
            this.lblDtEspecial.TabIndex = 40;
            this.lblDtEspecial.Text = "Data da Situação Especial:";
            // 
            // lblEspecialInfo
            // 
            this.lblEspecialInfo.AutoSize = true;
            this.lblEspecialInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialInfo.Location = new System.Drawing.Point(6, 432);
            this.lblEspecialInfo.Name = "lblEspecialInfo";
            this.lblEspecialInfo.Size = new System.Drawing.Size(12, 17);
            this.lblEspecialInfo.TabIndex = 39;
            this.lblEspecialInfo.Text = "-";
            // 
            // lblEspecial
            // 
            this.lblEspecial.AutoSize = true;
            this.lblEspecial.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecial.Location = new System.Drawing.Point(6, 416);
            this.lblEspecial.Name = "lblEspecial";
            this.lblEspecial.Size = new System.Drawing.Size(117, 17);
            this.lblEspecial.TabIndex = 38;
            this.lblEspecial.Text = "Situação Especial:";
            // 
            // lblCadastralInfo
            // 
            this.lblCadastralInfo.AutoSize = true;
            this.lblCadastralInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastralInfo.Location = new System.Drawing.Point(6, 379);
            this.lblCadastralInfo.Name = "lblCadastralInfo";
            this.lblCadastralInfo.Size = new System.Drawing.Size(12, 17);
            this.lblCadastralInfo.TabIndex = 37;
            this.lblCadastralInfo.Text = "-";
            // 
            // lblCadastral
            // 
            this.lblCadastral.AutoSize = true;
            this.lblCadastral.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastral.Location = new System.Drawing.Point(6, 363);
            this.lblCadastral.Name = "lblCadastral";
            this.lblCadastral.Size = new System.Drawing.Size(126, 17);
            this.lblCadastral.TabIndex = 36;
            this.lblCadastral.Text = "Situação Cadastral:";
            // 
            // lblEmailInfo
            // 
            this.lblEmailInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailInfo.Location = new System.Drawing.Point(6, 327);
            this.lblEmailInfo.Name = "lblEmailInfo";
            this.lblEmailInfo.Size = new System.Drawing.Size(227, 36);
            this.lblEmailInfo.TabIndex = 35;
            this.lblEmailInfo.Text = "-";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(6, 311);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(131, 17);
            this.lblEmail.TabIndex = 34;
            this.lblEmail.Text = "Endereço Eletrônico:";
            // 
            // lblUfInfo
            // 
            this.lblUfInfo.AutoSize = true;
            this.lblUfInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUfInfo.Location = new System.Drawing.Point(743, 272);
            this.lblUfInfo.Name = "lblUfInfo";
            this.lblUfInfo.Size = new System.Drawing.Size(12, 17);
            this.lblUfInfo.TabIndex = 33;
            this.lblUfInfo.Text = "-";
            // 
            // lblMunicipioInfo
            // 
            this.lblMunicipioInfo.AutoSize = true;
            this.lblMunicipioInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipioInfo.Location = new System.Drawing.Point(615, 272);
            this.lblMunicipioInfo.Name = "lblMunicipioInfo";
            this.lblMunicipioInfo.Size = new System.Drawing.Size(12, 17);
            this.lblMunicipioInfo.TabIndex = 31;
            this.lblMunicipioInfo.Text = "-";
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipio.Location = new System.Drawing.Point(615, 256);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(69, 17);
            this.lblMunicipio.TabIndex = 30;
            this.lblMunicipio.Text = "Município:";
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUf.Location = new System.Drawing.Point(743, 256);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(25, 17);
            this.lblUf.TabIndex = 32;
            this.lblUf.Text = "UF:";
            // 
            // lblCepInfo
            // 
            this.lblCepInfo.AutoSize = true;
            this.lblCepInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCepInfo.Location = new System.Drawing.Point(353, 272);
            this.lblCepInfo.Name = "lblCepInfo";
            this.lblCepInfo.Size = new System.Drawing.Size(12, 17);
            this.lblCepInfo.TabIndex = 29;
            this.lblCepInfo.Text = "-";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(353, 256);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(33, 17);
            this.lblCep.TabIndex = 28;
            this.lblCep.Text = "CEP:";
            // 
            // lblBairroInfo
            // 
            this.lblBairroInfo.AutoSize = true;
            this.lblBairroInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairroInfo.Location = new System.Drawing.Point(439, 272);
            this.lblBairroInfo.Name = "lblBairroInfo";
            this.lblBairroInfo.Size = new System.Drawing.Size(12, 17);
            this.lblBairroInfo.TabIndex = 27;
            this.lblBairroInfo.Text = "-";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(439, 256);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(45, 17);
            this.lblBairro.TabIndex = 26;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblNumeroInfo
            // 
            this.lblNumeroInfo.AutoSize = true;
            this.lblNumeroInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroInfo.Location = new System.Drawing.Point(249, 272);
            this.lblNumeroInfo.Name = "lblNumeroInfo";
            this.lblNumeroInfo.Size = new System.Drawing.Size(12, 17);
            this.lblNumeroInfo.TabIndex = 25;
            this.lblNumeroInfo.Text = "-";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(147, 26);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 17);
            this.lblTipo.TabIndex = 23;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblTipoInfo
            // 
            this.lblTipoInfo.AutoSize = true;
            this.lblTipoInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoInfo.Location = new System.Drawing.Point(147, 42);
            this.lblTipoInfo.Name = "lblTipoInfo";
            this.lblTipoInfo.Size = new System.Drawing.Size(12, 17);
            this.lblTipoInfo.TabIndex = 22;
            this.lblTipoInfo.Text = "-";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(249, 256);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(58, 17);
            this.lblNumero.TabIndex = 21;
            this.lblNumero.Text = "Número:";
            // 
            // lblLogradouroInfo
            // 
            this.lblLogradouroInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogradouroInfo.Location = new System.Drawing.Point(6, 272);
            this.lblLogradouroInfo.Name = "lblLogradouroInfo";
            this.lblLogradouroInfo.Size = new System.Drawing.Size(237, 39);
            this.lblLogradouroInfo.TabIndex = 20;
            this.lblLogradouroInfo.Text = "-";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogradouro.Location = new System.Drawing.Point(6, 256);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(80, 17);
            this.lblLogradouro.TabIndex = 19;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // lblNomeEmpresarial
            // 
            this.lblNomeEmpresarial.AutoSize = true;
            this.lblNomeEmpresarial.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEmpresarial.Location = new System.Drawing.Point(6, 84);
            this.lblNomeEmpresarial.Name = "lblNomeEmpresarial";
            this.lblNomeEmpresarial.Size = new System.Drawing.Size(118, 17);
            this.lblNomeEmpresarial.TabIndex = 18;
            this.lblNomeEmpresarial.Text = "Nome Empresarial:";
            // 
            // lblNaturezaJuridicaInfo
            // 
            this.lblNaturezaJuridicaInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaturezaJuridicaInfo.Location = new System.Drawing.Point(529, 42);
            this.lblNaturezaJuridicaInfo.Name = "lblNaturezaJuridicaInfo";
            this.lblNaturezaJuridicaInfo.Size = new System.Drawing.Size(304, 32);
            this.lblNaturezaJuridicaInfo.TabIndex = 17;
            this.lblNaturezaJuridicaInfo.Text = "-";
            // 
            // lblNaturezaJuridica
            // 
            this.lblNaturezaJuridica.AutoSize = true;
            this.lblNaturezaJuridica.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaturezaJuridica.Location = new System.Drawing.Point(529, 26);
            this.lblNaturezaJuridica.Name = "lblNaturezaJuridica";
            this.lblNaturezaJuridica.Size = new System.Drawing.Size(115, 17);
            this.lblNaturezaJuridica.TabIndex = 16;
            this.lblNaturezaJuridica.Text = "Natureza Jurídica:";
            // 
            // lblAtividadeSecundaria
            // 
            this.lblAtividadeSecundaria.AutoSize = true;
            this.lblAtividadeSecundaria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtividadeSecundaria.Location = new System.Drawing.Point(8, 142);
            this.lblAtividadeSecundaria.Name = "lblAtividadeSecundaria";
            this.lblAtividadeSecundaria.Size = new System.Drawing.Size(142, 17);
            this.lblAtividadeSecundaria.TabIndex = 14;
            this.lblAtividadeSecundaria.Text = "Atividade Secundária:";
            // 
            // lblAtividadePrincipalInfo
            // 
            this.lblAtividadePrincipalInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtividadePrincipalInfo.Location = new System.Drawing.Point(511, 100);
            this.lblAtividadePrincipalInfo.Name = "lblAtividadePrincipalInfo";
            this.lblAtividadePrincipalInfo.Size = new System.Drawing.Size(322, 59);
            this.lblAtividadePrincipalInfo.TabIndex = 13;
            this.lblAtividadePrincipalInfo.Text = "-";
            // 
            // lblPorteInfo
            // 
            this.lblPorteInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorteInfo.Location = new System.Drawing.Point(239, 42);
            this.lblPorteInfo.Name = "lblPorteInfo";
            this.lblPorteInfo.Size = new System.Drawing.Size(123, 42);
            this.lblPorteInfo.TabIndex = 12;
            this.lblPorteInfo.Text = "-";
            // 
            // lblAtividadePrincipal
            // 
            this.lblAtividadePrincipal.AutoSize = true;
            this.lblAtividadePrincipal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtividadePrincipal.Location = new System.Drawing.Point(511, 84);
            this.lblAtividadePrincipal.Name = "lblAtividadePrincipal";
            this.lblAtividadePrincipal.Size = new System.Drawing.Size(125, 17);
            this.lblAtividadePrincipal.TabIndex = 11;
            this.lblAtividadePrincipal.Text = "Atividade Principal:";
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFantasia.Location = new System.Drawing.Point(344, 84);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(100, 17);
            this.lblNomeFantasia.TabIndex = 10;
            this.lblNomeFantasia.Text = "Nome Fantasia:";
            // 
            // lblNomeFantasiaInfo
            // 
            this.lblNomeFantasiaInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFantasiaInfo.Location = new System.Drawing.Point(344, 100);
            this.lblNomeFantasiaInfo.Name = "lblNomeFantasiaInfo";
            this.lblNomeFantasiaInfo.Size = new System.Drawing.Size(161, 59);
            this.lblNomeFantasiaInfo.TabIndex = 9;
            this.lblNomeFantasiaInfo.Text = "-";
            // 
            // lblPorte
            // 
            this.lblPorte.AutoSize = true;
            this.lblPorte.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorte.Location = new System.Drawing.Point(239, 26);
            this.lblPorte.Name = "lblPorte";
            this.lblPorte.Size = new System.Drawing.Size(43, 17);
            this.lblPorte.TabIndex = 8;
            this.lblPorte.Text = "Porte:";
            // 
            // lblNomeEmpresarialInfo
            // 
            this.lblNomeEmpresarialInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEmpresarialInfo.Location = new System.Drawing.Point(6, 100);
            this.lblNomeEmpresarialInfo.Name = "lblNomeEmpresarialInfo";
            this.lblNomeEmpresarialInfo.Size = new System.Drawing.Size(328, 42);
            this.lblNomeEmpresarialInfo.TabIndex = 7;
            this.lblNomeEmpresarialInfo.Text = "-";
            // 
            // lblDataAberturaInfo
            // 
            this.lblDataAberturaInfo.AutoSize = true;
            this.lblDataAberturaInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAberturaInfo.Location = new System.Drawing.Point(368, 42);
            this.lblDataAberturaInfo.Name = "lblDataAberturaInfo";
            this.lblDataAberturaInfo.Size = new System.Drawing.Size(12, 17);
            this.lblDataAberturaInfo.TabIndex = 6;
            this.lblDataAberturaInfo.Text = "-";
            // 
            // lblDtAbertura
            // 
            this.lblDtAbertura.AutoSize = true;
            this.lblDtAbertura.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtAbertura.Location = new System.Drawing.Point(368, 26);
            this.lblDtAbertura.Name = "lblDtAbertura";
            this.lblDtAbertura.Size = new System.Drawing.Size(116, 17);
            this.lblDtAbertura.TabIndex = 5;
            this.lblDtAbertura.Text = "Data de Abertura:";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(6, 26);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(42, 17);
            this.lblCnpj.TabIndex = 4;
            this.lblCnpj.Text = "CNPJ:";
            // 
            // ucSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.masktxtCnpj);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.gbInfo);
            this.Name = "ucSearch";
            this.Size = new System.Drawing.Size(865, 531);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox masktxtCnpj;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lblMotivoInfo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Label lblDtCadastralInfo;
        private System.Windows.Forms.Label lblDtCadastra;
        private System.Windows.Forms.Label lblEfrInfo;
        private System.Windows.Forms.Label lblEfr;
        private System.Windows.Forms.Label lblTelefoneInfo;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblDtEspecialInfo;
        private System.Windows.Forms.Label lblDtEspecial;
        private System.Windows.Forms.Label lblEspecialInfo;
        private System.Windows.Forms.Label lblEspecial;
        private System.Windows.Forms.Label lblCadastralInfo;
        private System.Windows.Forms.Label lblCadastral;
        private System.Windows.Forms.Label lblEmailInfo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUfInfo;
        private System.Windows.Forms.Label lblMunicipioInfo;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.Label lblCepInfo;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblBairroInfo;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblNumeroInfo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblTipoInfo;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblLogradouroInfo;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label lblNomeEmpresarial;
        private System.Windows.Forms.Label lblNaturezaJuridicaInfo;
        private System.Windows.Forms.Label lblNaturezaJuridica;
        private System.Windows.Forms.Label lblAtividadeSecundaria;
        private System.Windows.Forms.Label lblAtividadePrincipalInfo;
        private System.Windows.Forms.Label lblPorteInfo;
        private System.Windows.Forms.Label lblAtividadePrincipal;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.Label lblNomeFantasiaInfo;
        private System.Windows.Forms.Label lblPorte;
        private System.Windows.Forms.Label lblNomeEmpresarialInfo;
        private System.Windows.Forms.Label lblDataAberturaInfo;
        private System.Windows.Forms.Label lblDtAbertura;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.TextBox txtSecundaria;
        private System.Windows.Forms.MaskedTextBox masktxtCnpjInfo;
    }
}
