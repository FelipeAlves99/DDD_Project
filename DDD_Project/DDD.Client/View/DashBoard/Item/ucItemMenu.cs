using System;
using System.Windows.Forms;

namespace CadstroEmpresaClient.View
{
    public partial class ucItemMenu : UserControl
    {
        public ucItemMenu()
        {
            InitializeComponent();
            ucItemAdd1.BringToFront();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            pnlBottom.Width = btnRegister.Width;
            pnlBottom.Top = btnRegister.Height - pnlBottom.Height;
            pnlBottom.Left = btnRegister.Left;
            ucItemAdd1.BringToFront();
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            pnlBottom.Width = btnConsult.Width;
            pnlBottom.Top = btnConsult.Height - pnlBottom.Height;
            pnlBottom.Left = btnConsult.Left;
            ucConsultItem1.FillDataGrid();            
            ucConsultItem1.BringToFront();
        }
    }
}
