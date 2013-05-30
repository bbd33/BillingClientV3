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
        private FormPopUp _frmPopUp;
        private FormConfirm _frmConfirm;
        private FormChat _frmChat;

        private bool _firstInit;

        public FormMain()
        {
            InitializeComponent();
            _frmPopUp = new FormPopUp(this);    
            _frmConfirm = new FormConfirm(this);
            _frmChat = new FormChat(this);
            
        }
        private void DisableTaskSwitch()
        {
            Settings.System.EnableTaskSwitch = false;
            WinAPI.TaskSwitching_Enable_Disable(false);
        }
        private void EnableTaskSwitch()
        {
            Settings.System.EnableTaskSwitch = true;
            WinAPI.TaskSwitching_Enable_Disable(true);
        }
        private void ShowTaskBar()
        {
            Settings.System.DisplayTaskBar = true;
            WinAPI.Taskbar.Show();
        }
        private void HideTaskBar()
        {
            Settings.System.DisplayTaskBar = false;
            WinAPI.Taskbar.Hide();
        }
        public ClientInformation GetClientInfo()
        {
            return _clientInformation;
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
            HideTaskBar();
            DisableTaskSwitch();

            // Start main form fullscreen
            _frmConfirm.Hide();
            DisableTimerPush();
            FullScreen();
            HidePopUp();
            //Hide tray menu
            HideTrayMenu();

            // Query Server
            FormInfo frmInfo = new FormInfo(this, 2);
            frmInfo.SetMode(FormInfo.FormMode.QueryServerInformation);
            frmInfo.ShowDialog();

            BringToFront();

            DisplayBallonTips("Connected to " + _serverInformation.CompanyName,2000);


            frmInfo.SetMode(FormInfo.FormMode.QueryClientInformation);
            frmInfo.ShowDialog();

            DisplayBallonTips( "This computer registered as " + _clientInformation.Name,2000);

            frmInfo.SetMode(FormInfo.FormMode.QuerySessionInformation);
            frmInfo.ShowDialog();

            if( _sessionInformation != null ){
               // DisplayBallonTips( "This computer session code is " + _sessionInformation.Code, 2000);
                ShowPopUp();
            }
            ShowTrayMenu();
            // Hide On Success
            Hide();
            EnableTimerPush();

            ShowTaskBar();
            EnableTaskSwitch();
        }

        private void ShowPopUp()
        {
            _frmPopUp.Show();
        }
        private void HidePopUp()
        {
            _frmPopUp.Hide();
        }
        private void ShowTrayMenu()
        {
            stopToolStripMenuItem.Visible = true;
            refillToolStripMenuItem.Visible = true;
            chatToolStripMenuItem.Visible = true;

            stopToolStripMenuItem.Enabled = true;
            refillToolStripMenuItem.Enabled = true;
            chatToolStripMenuItem.Enabled = true;
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
            timerChat.Enabled = false;
            timerPush.Enabled = false;

            // 
            _frmChat.Hide();
        }
        private void EnableTimerPush()
        {
            timerChat.Enabled = true;
            timerPush.Enabled = true;
        }
        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Confirm Stop
            stopToolStripMenuItem.Enabled = false;
            _frmConfirm.SetMode(FormConfirm.FormMode.ConfirmLogout);
            _frmConfirm.BringToFront();
            _frmConfirm.Show();

            // Jump To OnConfirm;

        }
        public void OnConfirm(bool UserPressYesButton )
        {
            if (_frmConfirm.GetMode() == FormConfirm.FormMode.ConfirmLogout)
            {
                if (UserPressYesButton)
                {
                    DoLogout();
                }
                stopToolStripMenuItem.Enabled = true;
            }
        }
        private void DoLogout()
        {
            RestController<MessageData> rmd;
            MessageData md = null;
            string resource = "ClientLogout";
            string parameter = "?data="+_sessionInformation.Code;

            rmd = new RestController<MessageData>(Settings.RestController.ServerBase, resource, Settings.RestController.ResourcePrefix);
            try
            {
                md = rmd.GetData(parameter);
                

            }
            catch (Exception exp)
            { 
                DisplayBallonTips( exp.Message ,2000);
            }
            _sessionInformation = null;
            _pushData = null;
            timerPush.Enabled = false;
            _frmConfirm.Hide();
            ProcessMonitor.KillAll();
            Show();
            FullScreen();

            
        }

        private void refillToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timerPush_Tick(object sender, EventArgs e)
        {
            _pushData = null;
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
                //else if (_pushData.Duration <= 3)
                //{ 
                //    //Logout
                //    DoLogout();
                //}
            }
            if ( _pushData == null )
            { 
                //Logout
                DoLogout();
            }
        }

        private void DisplayBallonTips( string message, int timeout )
        {
            if (_frmPopUp.Visible)
            {
                _frmPopUp.SetText(message);
                return;
            }
            tray.BalloonTipText = message + " ";
            tray.ShowBalloonTip( timeout );
        }

        private void timerTask_Tick(object sender, EventArgs e)
        {
            
        }

        private void timerChat_Tick(object sender, EventArgs e)
        {
            RestController<ChatDatas> rcd;
            rcd = new RestController<ChatDatas>(Settings.RestController.ServerBase, "Chats", Settings.RestController.ResourcePrefix);
            ChatDatas chatDatas = new ChatDatas();

            try 
            {
                chatDatas = rcd.GetData(); 
            }
            catch(Exception exp) {
                //DisplayBallonTips(exp.Message, 1000);
            }

            if (chatDatas.Count > 0)
            { 
                foreach (ChatData chatData in chatDatas)
                {
                    _frmChat.AddToList(chatData.Message);

                    if (!_frmChat.Visible)
                    {
                        //_frmChat.BringToFront();
                        try
                        {
                            DisplayChat();
                        }
                        catch (Exception exp){
                            //DisplayBallonTips(exp.Message, 1000);
                        }
                    }
                }
            }
        }

        private void DisplayChat()
        { 
            //_frmChat.Hide();
            _frmChat.WindowState = FormWindowState.Normal;
            _frmChat.BringToFront();
            _frmChat.Show();
    
        }
        private void chatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayChat();
        }  
    }
}