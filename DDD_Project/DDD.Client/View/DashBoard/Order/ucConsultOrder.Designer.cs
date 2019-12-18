namespace CadstroEmpresaClient.View
{
    partial class ucConsultOrder
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpOrderDelivery = new System.Windows.Forms.DateTimePicker();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            this.columnItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnValorLinha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbOrderStatus = new System.Windows.Forms.ComboBox();
            this.txtFinalPrice = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.masktxtCnpjClient = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtSituation = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Location = new System.Drawing.Point(615, 281);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 28);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Limpar Campos";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.Location = new System.Drawing.Point(735, 281);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 28);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Atualizar Pedido";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpOrderDelivery);
            this.groupBox1.Controls.Add(this.dtpOrderDate);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDiscount);
            this.groupBox1.Controls.Add(this.dgvItemList);
            this.groupBox1.Controls.Add(this.cbOrderStatus);
            this.groupBox1.Controls.Add(this.txtFinalPrice);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Location = new System.Drawing.Point(16, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(473, 366);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Pedido";
            // 
            // dtpOrderDelivery
            // 
            this.dtpOrderDelivery.Enabled = false;
            this.dtpOrderDelivery.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDelivery.Location = new System.Drawing.Point(348, 49);
            this.dtpOrderDelivery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpOrderDelivery.Name = "dtpOrderDelivery";
            this.dtpOrderDelivery.Size = new System.Drawing.Size(108, 21);
            this.dtpOrderDelivery.TabIndex = 17;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Enabled = false;
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(220, 49);
            this.dtpOrderDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(108, 21);
            this.dtpOrderDate.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Location = new System.Drawing.Point(127, 42);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Lista dos itens pedidos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Valor Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Desconto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Status do Pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Data de Entrega";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Data do Pedido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Código do Pedido";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.Color.Snow;
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiscount.Location = new System.Drawing.Point(188, 104);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(116, 14);
            this.txtDiscount.TabIndex = 8;
            // 
            // dgvItemList
            // 
            this.dgvItemList.AllowUserToAddRows = false;
            this.dgvItemList.AllowUserToDeleteRows = false;
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnItemId,
            this.columnDescricao,
            this.columnQuantidade,
            this.columnValorLinha});
            this.dgvItemList.Location = new System.Drawing.Point(13, 165);
            this.dgvItemList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvItemList.MultiSelect = false;
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemList.Size = new System.Drawing.Size(443, 185);
            this.dgvItemList.TabIndex = 7;
            // 
            // columnItemId
            // 
            this.columnItemId.HeaderText = "Id Item";
            this.columnItemId.Name = "columnItemId";
            this.columnItemId.ReadOnly = true;
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
            // cbOrderStatus
            // 
            this.cbOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrderStatus.Enabled = false;
            this.cbOrderStatus.FormattingEnabled = true;
            this.cbOrderStatus.Location = new System.Drawing.Point(13, 101);
            this.cbOrderStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbOrderStatus.Name = "cbOrderStatus";
            this.cbOrderStatus.Size = new System.Drawing.Size(140, 24);
            this.cbOrderStatus.TabIndex = 6;
            // 
            // txtFinalPrice
            // 
            this.txtFinalPrice.BackColor = System.Drawing.Color.Snow;
            this.txtFinalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFinalPrice.Location = new System.Drawing.Point(339, 104);
            this.txtFinalPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFinalPrice.Name = "txtFinalPrice";
            this.txtFinalPrice.ReadOnly = true;
            this.txtFinalPrice.Size = new System.Drawing.Size(116, 14);
            this.txtFinalPrice.TabIndex = 5;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(13, 45);
            this.txtCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(108, 21);
            this.txtCode.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.masktxtCnpjClient);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtPhone);
            this.groupBox3.Controls.Add(this.txtSituation);
            this.groupBox3.Controls.Add(this.txtState);
            this.groupBox3.Controls.Add(this.txtClientName);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(495, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 240);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informações do Cliente";
            // 
            // masktxtCnpjClient
            // 
            this.masktxtCnpjClient.BackColor = System.Drawing.Color.Snow;
            this.masktxtCnpjClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.masktxtCnpjClient.Location = new System.Drawing.Point(31, 114);
            this.masktxtCnpjClient.Mask = "00,000,000/0000-00";
            this.masktxtCnpjClient.Name = "masktxtCnpjClient";
            this.masktxtCnpjClient.ReadOnly = true;
            this.masktxtCnpjClient.Size = new System.Drawing.Size(136, 14);
            this.masktxtCnpjClient.TabIndex = 23;
            this.masktxtCnpjClient.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Nome do Cliente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "CNPJ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(204, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Situação Cadastral";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(191, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Estado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 16);
            this.label12.TabIndex = 14;
            this.label12.Text = "Telefone";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Snow;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Location = new System.Drawing.Point(31, 189);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(108, 14);
            this.txtPhone.TabIndex = 7;
            // 
            // txtSituation
            // 
            this.txtSituation.BackColor = System.Drawing.Color.Snow;
            this.txtSituation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSituation.Location = new System.Drawing.Point(207, 114);
            this.txtSituation.Name = "txtSituation";
            this.txtSituation.ReadOnly = true;
            this.txtSituation.Size = new System.Drawing.Size(108, 14);
            this.txtSituation.TabIndex = 6;
            // 
            // txtState
            // 
            this.txtState.BackColor = System.Drawing.Color.Snow;
            this.txtState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtState.Location = new System.Drawing.Point(194, 189);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(50, 14);
            this.txtState.TabIndex = 5;
            // 
            // txtClientName
            // 
            this.txtClientName.BackColor = System.Drawing.Color.Snow;
            this.txtClientName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientName.Location = new System.Drawing.Point(17, 51);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.ReadOnly = true;
            this.txtClientName.Size = new System.Drawing.Size(318, 14);
            this.txtClientName.TabIndex = 3;
            // 
            // ucConsultOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucConsultOrder";
            this.Size = new System.Drawing.Size(865, 434);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpOrderDelivery;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.DataGridView dgvItemList;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnValorLinha;
        private System.Windows.Forms.ComboBox cbOrderStatus;
        private System.Windows.Forms.TextBox txtFinalPrice;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox masktxtCnpjClient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtSituation;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtClientName;
    }
}
