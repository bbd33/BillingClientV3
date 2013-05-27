using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BillingClientV3
{
    public partial class FormConfirm : Form
    {
        FormMain _launcher;
        int _formMode;

        public class FormMode {
            public const int ConfirmLogout = 1;
        }
        public int GetMode()
        {
            return _formMode;
        }
        public void SetMode(int mode)
        {
            _formMode = mode;

            if (_formMode == FormMode.ConfirmLogout)
                lblMessage.Text = "Apakah anda yakin ingin mengakhiri sesi ini ?";
        }
        public FormConfirm(FormMain launcher )
        {
            _launcher = launcher;
            InitializeComponent();
        }

        private void Display( string message )
        {
            lblMessage.Text = message;
        }
        private void btnYes_Click(object sender, EventArgs e)
        {
            _launcher.OnConfirm(true);
            Hide();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            _launcher.OnConfirm(false);
            Hide();

        }

        private void FormConfirm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
        }
    }
}
