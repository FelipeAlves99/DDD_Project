namespace CadstroEmpresaClient.View
{
    partial class ucItemMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucItemMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnConsult = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.ucItemAdd1 = new CadstroEmpresaClient.View.MDI.ucItemAdd();
            this.ucConsultItem1 = new CadstroEmpresaClient.View.ucConsultItem();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(144)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.pnlBottom);
            this.panel1.Controls.Add(this.btnConsult);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 97);
            this.panel1.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlBottom.Location = new System.Drawing.Point(0, 87);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(232, 10);
            this.pnlBottom.TabIndex = 2;
            // 
            // btnConsult
            // 
            this.btnConsult.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConsult.FlatAppearance.BorderSize = 0;
            this.btnConsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsult.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsult.Image = ((System.Drawing.Image)(resources.GetObject("btnConsult.Image")));
            this.btnConsult.Location = new System.Drawing.Point(232, 0);
            this.btnConsult.Margin = new System.Windows.Forms.Padding(0);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(232, 97);
            this.btnConsult.TabIndex = 1;
            this.btnConsult.Text = "Consult Item";
            this.btnConsult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsult.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConsult.UseVisualStyleBackColor = true;
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnRegister.Image")));
            this.btnRegister.Location = new System.Drawing.Point(0, 0);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(232, 97);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register Item";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // ucItemAdd1
            // 
            this.ucItemAdd1.Location = new System.Drawing.Point(0, 97);
            this.ucItemAdd1.Name = "ucItemAdd1";
            this.ucItemAdd1.Size = new System.Drawing.Size(865, 434);
            this.ucItemAdd1.TabIndex = 1;
            // 
            // ucConsultItem1
            // 
            this.ucConsultItem1.Location = new System.Drawing.Point(0, 97);
            this.ucConsultItem1.Name = "ucConsultItem1";
            this.ucConsultItem1.Size = new System.Drawing.Size(865, 434);
            this.ucConsultItem1.TabIndex = 2;
            // 
            // ucItemMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucConsultItem1);
            this.Controls.Add(this.ucItemAdd1);
            this.Controls.Add(this.panel1);
            this.Name = "ucItemMenu";
            this.Size = new System.Drawing.Size(865, 531);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConsult;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel pnlBottom;
        private MDI.ucItemAdd ucItemAdd1;
        private ucConsultItem ucConsultItem1;
    }
}
