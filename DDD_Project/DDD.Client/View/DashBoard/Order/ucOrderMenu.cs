using System;
using System.Windows.Forms;

namespace CadstroEmpresaClient.View
{
    public partial class ucOrderMenu : UserControl
    {
        public ucOrderMenu()
        {
            InitializeComponent();
            ucOrderAdd1.BringToFront();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            pnlBottom.Width = btnOrder.Width;
            pnlBottom.Top = btnOrder.Height - pnlBottom.Height;
            pnlBottom.Left = btnOrder.Left;
            ucOrderAdd1.BringToFront();
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            pnlBottom.Width = btnConsult.Width;
            pnlBottom.Top = btnConsult.Height - pnlBottom.Height;
            pnlBottom.Left = btnConsult.Left;
            ucConsultOrder1.BringToFront();
        }
    }
}
