namespace CadstroEmpresaClient.View
{
    partial class ucOrderMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucOrderMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnConsult = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.ucOrderAdd1 = new CadstroEmpresaClient.View.ucOrderAdd();
            this.ucConsultOrder1 = new CadstroEmpresaClient.View.ucConsultOrder();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(144)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.pnlBottom);
            this.panel1.Controls.Add(this.btnConsult);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 97);
            this.panel1.TabIndex = 1;
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
            this.btnConsult.Text = "Consult Order";
            this.btnConsult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsult.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConsult.UseVisualStyleBackColor = true;
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnOrder.Image")));
            this.btnOrder.Location = new System.Drawing.Point(0, 0);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(0);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(232, 97);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Register Order";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // ucOrderAdd1
            // 
            this.ucOrderAdd1.Location = new System.Drawing.Point(0, 97);
            this.ucOrderAdd1.Name = "ucOrderAdd1";
            this.ucOrderAdd1.Size = new System.Drawing.Size(865, 434);
            this.ucOrderAdd1.TabIndex = 2;
            // 
            // ucConsultOrder1
            // 
            this.ucConsultOrder1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucConsultOrder1.Location = new System.Drawing.Point(0, 97);
            this.ucConsultOrder1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucConsultOrder1.Name = "ucConsultOrder1";
            this.ucConsultOrder1.Size = new System.Drawing.Size(865, 434);
            this.ucConsultOrder1.TabIndex = 3;
            // 
            // ucOrderMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucConsultOrder1);
            this.Controls.Add(this.ucOrderAdd1);
            this.Controls.Add(this.panel1);
            this.Name = "ucOrderMenu";
            this.Size = new System.Drawing.Size(865, 531);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnConsult;
        private System.Windows.Forms.Button btnOrder;
        private ucOrderAdd ucOrderAdd1;
        private ucConsultOrder ucConsultOrder1;
    }
}
