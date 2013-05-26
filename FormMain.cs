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
    public partial class FormMain : Form
    {
        private ServerInformation _serverInformation;
        private bool _firstInit;

        public FormMain()
        {
            InitializeComponent();
        }
        public void SetServerInfo(ServerInformation serverInfo)
        {
            _serverInformation = serverInfo;
        }
        private void FormMain_VisibleChanged(object sender, EventArgs e)
        {
            //tray.BalloonTipText = Visible ? "Iam Visible" : "Iam Invisible";
            //tray.ShowBalloonTip(3000);
            if ( !_firstInit )
                return;

            if (Visible)
            {
                Init();            
            }
            else
            { 
            
            }
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            Init();
            _firstInit = true;
        }
        private void FullScreen( )
        {
            if (Visible) 
            {
                WindowState = FormWindowState.Maximized;
                FormBorderStyle = FormBorderStyle.None;
                //TopMost = true;
            }
        }
        private void Init()
        {
            // Start main form fullscreen
            FullScreen();
            // Query Server
            FormInfo frmInfo = new FormInfo(this, 5);
            frmInfo.SetMode(FormInfo.FormMode.QueryServerInformation);
            frmInfo.ShowDialog();

            BringToFront();

            tray.BalloonTipText = "Connected to " + _serverInformation.CompanyName;
            tray.ShowBalloonTip(2000);


            frmInfo.SetMode(FormInfo.FormMode.QueryClientInformation);
            frmInfo.ShowDialog();

            // Hide On Success
            Hide();
        }
    }
}
