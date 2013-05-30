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
    public partial class FormChat : Form
    {
        private FormMain _launcher;
        private ClientInformations _clientList;

        public FormChat(FormMain launcher)
        {
            InitializeComponent();
            _launcher = launcher;
        }

        private void LoadClientList()
        {
            RestController<ClientInformations> rclist;
            rclist = new RestController<ClientInformations>( Settings.RestController.ServerBase,
                                                "stations",Settings.RestController.ResourcePrefix);
            ClientInformations clist = null;
            try
            {
                //string param = "?data=" + txtChat.Text;
                clist = rclist.GetData();
                if(clist != null )
                {

                    //for
                }
            }
            catch(Exception exp){
                AddToList(txtChat.Text + " : " +exp.Message);
            }
        }
        private void FormChat_Load(object sender, EventArgs e)
        {

        }

        private void txtChat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            { 
                RestController<MessageData> rcd;
                rcd = new RestController<MessageData>(Settings.RestController.ServerBase,
                                                    "Chat",Settings.RestController.ResourcePrefix);
                MessageData md = null;
                try
                {
                    string param = "?data=" + txtChat.Text;
                    md = rcd.GetData(param);
                    if(md != null )
                    {
                        AddToList("@Nyong " + txtChat.Text);
                    }
                }
                catch(Exception exp){
                    AddToList(txtChat.Text + " : " +exp.Message);
                }
                txtChat.Text = "";
            }
        }
        public void AddToList(string txt)
        {
            cbChatList.Items.Add(txt);
        }

        private void FormChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            //this.Parent = null;
            e.Cancel = true;
        }

    }
}
