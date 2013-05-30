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
                RestController<ChatData> rcd;
                rcd = new RestController<ChatData>( Settings.RestController.ServerBase,
                                                    "Chat",Settings.RestController.ResourcePrefix);
                ChatData cd = null;
                try
                {
                    string param = "?data=" + txtChat.Text;
                    cd = rcd.GetData(param);
                    if(cd != null )
                    {
                        AddToList(txtChat.Text);
                    }
                }
                catch(Exception exp){
                    AddToList(txtChat.Text + " : " +exp.Message);
                }
            }
        }
        public void AddToList(string txt)
        {
            cbChatList.Items.Add(txt);
        }
    }
}
