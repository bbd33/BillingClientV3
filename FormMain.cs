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
        private ClientInformation _clientInformation;
        private SessionInformation _sessionInformation;
        private PushData _pushData;
        private RestController<PushData> _rpd;

        private bool _firstInit;

        public FormMain()
        {
            InitializeComponent();
        }
        public void SetServerInfo(ServerInformation serverInfo)
        {
            _serverInformation = serverInfo;
        }
        public void SetClientInfo(ClientInformation clientInfo)
        {
            _clientInformation = clientInfo;
        }
        public void SetSessionInfo(SessionInformation sessionInfo)
        {
            _sessionInformation = sessionInfo;
        }
        private void FormMain_VisibleChanged(object sender, EventArgs e)
        {
            if (!_firstInit)
                return;

            if (Visible)
            {
                Init();
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
            DisableTimerPush();
            FullScreen();

            //Hide tray menu
            HideTrayMenu();

            // Query Server
            FormInfo frmInfo = new FormInfo(this, 2);
            frmInfo.SetMode(FormInfo.FormMode.QueryServerInformation);
            frmInfo.ShowDialog();

            BringToFront();

            tray.BalloonTipText = "Connected to " + _serverInformation.CompanyName;
            tray.ShowBalloonTip(2000);


            frmInfo.SetMode(FormInfo.FormMode.QueryClientInformation);
            frmInfo.ShowDialog();

            tray.BalloonTipText = "This computer registered as " + _clientInformation.Name;
            tray.ShowBalloonTip(2000);

            frmInfo.SetMode(FormInfo.FormMode.QuerySessionInformation);
            frmInfo.ShowDialog();

            tray.BalloonTipText = "This computer session code is " + _sessionInformation.Code;
            tray.ShowBalloonTip(2000);

            ShowTrayMenu();
            // Hide On Success
            Hide();
            EnableTimerPush();
        }

        private void ShowTrayMenu()
        {
            stopToolStripMenuItem.Visible = true;
            refillToolStripMenuItem.Visible = true;
        }
        
        private void HideTrayMenu()
        {
            stopToolStripMenuItem.Visible = false;
            refillToolStripMenuItem.Visible = false;
            chatToolStripMenuItem.Visible = false;
            beliToolStripMenuItem.Visible = false;
            tanyaToolStripMenuItem.Visible = false;
        }

        private void DisableTimerPush()
        {
            timerPush.Enabled = false;
        }
        private void EnableTimerPush()
        {
            timerPush.Enabled = true;
        }
        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void refillToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timerPush_Tick(object sender, EventArgs e)
        {
            if( _rpd == null )
            {
                string resource = "TimecodePush";
                _rpd = new RestController<PushData>( Settings.RestController.ServerBase, resource, Settings.RestController.ResourcePrefix );
            }
            if( _sessionInformation != null && _rpd != null )
            {
                string parameter = "?data=" + _sessionInformation.Code;
                try
                {
                    _pushData = _rpd.GetData( parameter );
                    
                }
                catch(Exception exp)
                {
                    DisplayBallonTips( exp.Message, 2000 );   
                }

                if ( _pushData != null && _pushData.Duration != 0)
                {
                    string DurationText = Utils.DurationToText(_pushData.Duration);
                    DisplayBallonTips(DurationText, 3000);
                }
                else
                {
                    if (_pushData.Duration == 0)
                    { 
                        //Logout
                        DoLogout();
                    }
                    timerPush.Enabled = false;
                    Show();
                    FullScreen();
                }
            }
        }

        private void DisplayBallonTips( string message, int timeout )
        {
            tray.BalloonTipText = message + " ";
            tray.ShowBalloonTip( timeout );
        }

        private void DoLogout()
        { 
            
        }
    }
}
