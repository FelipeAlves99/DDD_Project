namespace CadstroEmpresaClient.View
{
    partial class ucOrderAdd
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.masktxtCnpjClient = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtSituation = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnValorLinha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.dtpDelivery = new System.Windows.Forms.DateTimePicker();
            this.dtpOrder = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtFinalValue = new System.Windows.Forms.TextBox();
            this.txtNoDiscountValue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtItemValue = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.masktxtCnpjClient);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtPhone);
            this.groupBox3.Controls.Add(this.txtSituation);
            this.groupBox3.Controls.Add(this.txtState);
            this.groupBox3.Controls.Add(this.txtClientName);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(21, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(407, 191);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informações do Cliente";
            // 
            // masktxtCnpjClient
            // 
            this.masktxtCnpjClient.BackColor = System.Drawing.Color.Snow;
            this.masktxtCnpjClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.masktxtCnpjClient.Location = new System.Drawing.Point(17, 97);
            this.masktxtCnpjClient.Mask = "00,000,000/0000-00";
            this.masktxtCnpjClient.Name = "masktxtCnpjClient";
            this.masktxtCnpjClient.ReadOnly = true;
            this.masktxtCnpjClient.Size = new System.Drawing.Size(136, 14);
            this.masktxtCnpjClient.TabIndex = 23;
            this.masktxtCnpjClient.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nome do Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "CNPJ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Situação Cadastral";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Telefone";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Snow;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Location = new System.Drawing.Point(17, 151);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(108, 14);
            this.txtPhone.TabIndex = 7;
            // 
            // txtSituation
            // 
            this.txtSituation.BackColor = System.Drawing.Color.Snow;
            this.txtSituation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSituation.Location = new System.Drawing.Point(193, 97);
            this.txtSituation.Name = "txtSituation";
            this.txtSituation.ReadOnly = true;
            this.txtSituation.Size = new System.Drawing.Size(108, 14);
            this.txtSituation.TabIndex = 6;
            // 
            // txtState
            // 
            this.txtState.BackColor = System.Drawing.Color.Snow;
            this.txtState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtState.Location = new System.Drawing.Point(341, 97);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(50, 14);
            this.txtState.TabIndex = 5;
            // 
            // txtClientName
            // 
            this.txtClientName.BackColor = System.Drawing.Color.Snow;
            this.txtClientName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientName.Location = new System.Drawing.Point(17, 43);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.ReadOnly = true;
            this.txtClientName.Size = new System.Drawing.Size(375, 14);
            this.txtClientName.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMakeOrder);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.txtDiscount);
            this.groupBox2.Controls.Add(this.dgvItemList);
            this.groupBox2.Controls.Add(this.cbClient);
            this.groupBox2.Controls.Add(this.dtpDelivery);
            this.groupBox2.Controls.Add(this.dtpOrder);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtFinalValue);
            this.groupBox2.Controls.Add(this.txtNoDiscountValue);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(434, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 394);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações do Pedido";
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.Enabled = false;
            this.btnMakeOrder.Location = new System.Drawing.Point(211, 335);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(67, 40);
            this.btnMakeOrder.TabIndex = 40;
            this.btnMakeOrder.Text = "Efetuar Pedido";
            this.btnMakeOrder.UseVisualStyleBackColor = true;
            this.btnMakeOrder.Click += new System.EventHandler(this.btnMakeOrder_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "Desconto";
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(314, 297);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 32;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.Color.Snow;
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiscount.Location = new System.Drawing.Point(20, 45);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(100, 14);
            this.txtDiscount.TabIndex = 33;
            this.txtDiscount.Text = "0";
            // 
            // dgvItemList
            // 
            this.dgvItemList.AllowUserToAddRows = false;
            this.dgvItemList.AllowUserToDeleteRows = false;
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnDescricao,
            this.columnQuantidade,
            this.columnValorLinha});
            this.dgvItemList.Location = new System.Drawing.Point(20, 171);
            this.dgvItemList.MultiSelect = false;
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemList.Size = new System.Drawing.Size(370, 150);
            this.dgvItemList.TabIndex = 36;
            // 
            // columnId
            // 
            this.columnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.columnId.HeaderText = "Id";
            this.columnId.Name = "columnId";
            this.columnId.ReadOnly = true;
            this.columnId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnId.Width = 44;
            // 
            // columnDescricao
            // 
            this.columnDescricao.HeaderText = "Descrição";
            this.columnDescricao.Name = "columnDescricao";
            this.columnDescricao.ReadOnly = true;
            // 
            // columnQuantidade
            // 
            this.columnQuantidade.HeaderText = "Quantidade";
            this.columnQuantidade.Name = "columnQuantidade";
            this.columnQuantidade.ReadOnly = true;
            // 
            // columnValorLinha
            // 
            this.columnValorLinha.HeaderText = "Valor da Linha";
            this.columnValorLinha.Name = "columnValorLinha";
            this.columnValorLinha.ReadOnly = true;
            // 
            // cbClient
            // 
            this.cbClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(20, 108);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(370, 24);
            this.cbClient.TabIndex = 39;
            this.cbClient.SelectedIndexChanged += new System.EventHandler(this.cbClient_SelectedIndexChanged);
            // 
            // dtpDelivery
            // 
            this.dtpDelivery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDelivery.CustomFormat = "";
            this.dtpDelivery.Enabled = false;
            this.dtpDelivery.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDelivery.Location = new System.Drawing.Point(290, 44);
            this.dtpDelivery.Name = "dtpDelivery";
            this.dtpDelivery.Size = new System.Drawing.Size(100, 21);
            this.dtpDelivery.TabIndex = 38;
            // 
            // dtpOrder
            // 
            this.dtpOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpOrder.CustomFormat = "";
            this.dtpOrder.Enabled = false;
            this.dtpOrder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrder.Location = new System.Drawing.Point(155, 44);
            this.dtpOrder.Name = "dtpOrder";
            this.dtpOrder.Size = new System.Drawing.Size(100, 21);
            this.dtpOrder.TabIndex = 37;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(132, 335);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(67, 40);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancelar Pedido";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(287, 338);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "Valor Final";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 16);
            this.label12.TabIndex = 30;
            this.label12.Text = "Lista de Itens";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 338);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 16);
            this.label13.TabIndex = 29;
            this.label13.Text = "Valor sem Desconto";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 16);
            this.label14.TabIndex = 28;
            this.label14.Text = "Nome do Cliente";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(287, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 16);
            this.label15.TabIndex = 27;
            this.label15.Text = "Previsão de Entrega";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(152, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 16);
            this.label16.TabIndex = 26;
            this.label16.Text = "Data do Pedido";
            // 
            // txtFinalValue
            // 
            this.txtFinalValue.BackColor = System.Drawing.Color.Snow;
            this.txtFinalValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFinalValue.Location = new System.Drawing.Point(290, 354);
            this.txtFinalValue.Name = "txtFinalValue";
            this.txtFinalValue.ReadOnly = true;
            this.txtFinalValue.Size = new System.Drawing.Size(100, 14);
            this.txtFinalValue.TabIndex = 25;
            this.txtFinalValue.Text = "0";
            // 
            // txtNoDiscountValue
            // 
            this.txtNoDiscountValue.BackColor = System.Drawing.Color.Snow;
            this.txtNoDiscountValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoDiscountValue.Location = new System.Drawing.Point(20, 354);
            this.txtNoDiscountValue.Name = "txtNoDiscountValue";
            this.txtNoDiscountValue.ReadOnly = true;
            this.txtNoDiscountValue.Size = new System.Drawing.Size(100, 14);
            this.txtNoDiscountValue.TabIndex = 24;
            this.txtNoDiscountValue.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.txtItemValue);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 191);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Item";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descrição do Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código do Item";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(316, 150);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(202, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(130, 150);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(108, 21);
            this.txtQuantity.TabIndex = 3;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(283, 42);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(108, 21);
            this.txtCode.TabIndex = 2;
            // 
            // txtItemValue
            // 
            this.txtItemValue.BackColor = System.Drawing.Color.Snow;
            this.txtItemValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItemValue.Location = new System.Drawing.Point(16, 150);
            this.txtItemValue.Name = "txtItemValue";
            this.txtItemValue.ReadOnly = true;
            this.txtItemValue.Size = new System.Drawing.Size(108, 14);
            this.txtItemValue.TabIndex = 1;
            this.txtItemValue.Text = "0";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.Snow;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Location = new System.Drawing.Point(16, 69);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(375, 47);
            this.txtDescription.TabIndex = 0;
            // 
            // ucOrderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucOrderAdd";
            this.Size = new System.Drawing.Size(865, 434);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox masktxtCnpjClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtSituation;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.DataGridView dgvItemList;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnValorLinha;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.DateTimePicker dtpDelivery;
        private System.Windows.Forms.DateTimePicker dtpOrder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtFinalValue;
        private System.Windows.Forms.TextBox txtNoDiscountValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtItemValue;
        private System.Windows.Forms.TextBox txtDescription;
    }
}
