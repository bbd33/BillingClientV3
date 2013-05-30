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
    public partial class FormRefill : DraggableForm
    {
        FormMain _launcher;
        public FormRefill(FormMain launcher)
        {
            _launcher = launcher;
            InitializeComponent();
        }

        private void FormRefill_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

      

        private void btnRefill_Click(object sender, EventArgs e)
        {
            DoRefill();
        }

        private void txtTimecode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                DoRefill();
            }
        }

        private void DoRefill()
        {
            if (txtTimecode.Text.Length != 7)
            {
                MessageBox.Show(null, "Mohon masukkan 7 digit timekode", "Maaf");
                return;
            }
         
            string code = Utils.Md5(txtTimecode.Text);

            RestController<MessageData> rcd;
            rcd = new RestController<MessageData>(Settings.RestController.ServerBase,
                                                "ClientRefill", Settings.RestController.ResourcePrefix);
            // = null;

            //SessionInformation si = null;
            string parameter = "?data=" + code+"&src="+_launcher.GetSessionInfo().Code;
   

            try
            {
                MessageData md = rcd.GetData(parameter);

                if (md != null)
                {
                    if (md.Text != "Ok")
                    {
                        MessageBox.Show(null, "Kode sudah tidak berlaku", "Maaf,");
                    }
                    else
                    {
                        MessageBox.Show(null, "Refill berhasil", "Selamat");
                    }
                }
                txtTimecode.Text = "";
                Hide();

            }
            catch (Exception exp)
            {
                MessageBox.Show(null, "Kode tidak berlaku", "Maaf,");
            }
        }

        private void FormRefill_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
                txtTimecode.Focus();
        }
    }
}
