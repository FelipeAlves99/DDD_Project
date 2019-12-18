using System;
using System.Windows.Forms;

namespace CadstroEmpresaClient.View
{
    public partial class frmNewDesign : Form
    {
        frmMenu menu = new frmMenu();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmNewDesign()
        {
            InitializeComponent();
            ucHome1.BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            if (!menu.Visible)
            {
                Application.Exit();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnOldDesign_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlLeft.Height = btnHome.Height;
            pnlLeft.Top = btnHome.Top;
            ucHome1.BringToFront();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlLeft.Height = btnSearch.Height;
            pnlLeft.Top = btnSearch.Top;
            ucSearch1.BringToFront();
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            pnlLeft.Height = btnConsult.Height;
            pnlLeft.Top = btnConsult.Top;
            ucConsult1.BringToFront();
        }

        private void pnlControlBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            pnlLeft.Height = btnItem.Height;
            pnlLeft.Top = btnItem.Top;
            ucItemMenu1.BringToFront();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            pnlLeft.Height = btnOrder.Height;
            pnlLeft.Top = btnOrder.Top;
            ucOrderMenu1.BringToFront();
        }
    }
}
