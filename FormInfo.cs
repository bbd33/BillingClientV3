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
    public partial class FormInfo : Form
    {
        // Define form mode constant
        public static class FormMode
        {
            public const int QueryServerInformation = 1;
            public const int QueryClientInformation = 2;
            public const int QuerySessionInformation = 3;
        }

        private FormLogin _frmLogin;
        // Rest Config

        //RestClient _restClient = new RestClient();
        //string _restServerBase = "http://10.0.0.13/damarnet/api/";
        //string _restResource = "";
        //string _restResourceSuffix = "/format/json";

        private string _messageInfo;
        private int _dotCounter;
        private int _dotInterval;
        private string _dotString;

        private bool _commandExecuteInProgress;
        private int _commandRetry;
        // Store form mode
        private int _frmMode;

        // Store the laucher form
        private FormMain _launcher;
        public FormInfo( FormMain parentForm, int DotInterval)
        {
            _dotInterval = DotInterval;
            _launcher = parentForm;
            //_frmLogin = new FormLogin(this);
            InitializeComponent();
        }
        public void SetMode(int frmMode)
        { 
            _frmMode = frmMode;
            
            if (_frmMode == FormMode.QueryServerInformation)
                _messageInfo = "Getting Server Information";
            else if (_frmMode == FormMode.QueryClientInformation)
                _messageInfo = "Getting Client Information";
            else if (_frmMode == FormMode.QuerySessionInformation)
                _messageInfo = "Getting Session Information";
        }
        private void btnToggleShowParentForm_Click(object sender, EventArgs e)
        {
            if (_launcher.Visible)
            {
                _launcher.Hide();
            }
            else
            {
                _launcher.Show();
            }
            BringToFront();
        }

        public void StartTimerDot()
        {
            timerDot.Enabled = true;
        }
        public void StopTimerDot()
        {
            timerDot.Enabled = false;
        }
        private void timerDot_Tick(object sender, EventArgs e)
        {
            // Reset _dotCounter if value have reached to maximum interval
            if (_dotCounter == _dotInterval)
            {
                if (!_commandExecuteInProgress)
                {
                    ExecuteCommand();
                }
                _dotCounter = 0;
                _dotString = ".";
            }
            // Append dot string
            _dotString = _dotString + ".";
            _dotCounter++;

            lblInfoText.Text = _messageInfo + " " + _dotString;
        }

        private void ExecuteCommand()
        {
            // Set Flag
            _commandExecuteInProgress = true;

            // Temporary sould replaced by config
            /*RestClient restClient = new RestClient();
            */
            string serverBase = Settings.RestController.ServerBase;//"http://10.0.0.13/damarnet/api/";
            string resource = "", resourceSuffix = Settings.RestController.ResourcePrefix;
            
            if (_frmMode == FormMode.QueryServerInformation)
            {
                resource = "ServerInformation";
                ServerInformation srvInfo = null;
                RestController<ServerInformation> rsi;
                rsi = new RestController<ServerInformation>(serverBase, resource, resourceSuffix);

                try
                {
                    srvInfo = rsi.GetData();
                    _launcher.SetServerInfo(srvInfo);
                    _commandExecuteInProgress = false;
                    Hide();
                }
                catch (Exception exp)
                {
                    DialogResult result;
                    result = MessageBox.Show(exp.Message, "Error", MessageBoxButtons.RetryCancel);
                    //if (result == DialogResult.Retry)
                    //{
                        _commandExecuteInProgress = false;
                        _commandRetry++;
                    //}
                }
                
                
            }
            else if (_frmMode == FormMode.QueryClientInformation)
            {
                resource = "ClientInformation";
                ClientInformation clientInfo = null;
                RestController<ClientInformation> rsc;
                rsc = new RestController<ClientInformation>(serverBase, resource, resourceSuffix);

                try
                {
                    clientInfo = rsc.GetData();
                    _launcher.SetClientInfo(clientInfo);
                    _commandExecuteInProgress = false;
                    Hide();
                }
                catch (Exception exp)
                {
                    DialogResult result;
                    result = MessageBox.Show(exp.Message, "Error", MessageBoxButtons.RetryCancel);
                    //if (result == DialogResult.Retry)
                    //{
                    _commandExecuteInProgress = false;
                    _commandRetry++;
                    //}
                }
            }
            else if (_frmMode == FormMode.QuerySessionInformation)
            {
                resource = "SessionInformation";
                SessionInformation sessionInfo = null;
                RestController<SessionInformation> rss;
                rss = new RestController<SessionInformation>(serverBase, resource, resourceSuffix);

                try
                {
                    sessionInfo = rss.GetData();
                    _launcher.SetSessionInfo(sessionInfo);
                    _commandExecuteInProgress = false;
                    Hide();
                }
                catch (Exception exp)
                {
                    //DialogResult result;
                    Hide();
                    //string resource = "ClientLogin"
                    //RestController<SessionInformation> rss;
                    //rss = RestController<SessionInformation>(serverBase, resource, resourceSuffix);
                    _launcher.BringToFront();
                    _frmLogin = new FormLogin(this, rss);
                    _frmLogin.SetMode(FormLogin.FormMode.Timecode);
                    _frmLogin.ShowDialog();
                    sessionInfo = _frmLogin.GetSessionInfo();
                    _launcher.SetSessionInfo(sessionInfo);
                    //Show();
                    //result = MessageBox.Show(exp.Message, "Error", MessageBoxButtons.RetryCancel);
                    //if (result == DialogResult.Retry)
                    //{
                    _commandExecuteInProgress = false;
                    //_commandRetry++;
                    //}
                }
            }

        }
        private void FormInfo_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                StartTimerDot();
            }
            else
            {
                StopTimerDot();
            }
        }

        private void FormInfo_Load(object sender, EventArgs e)
        {

        }
        public FormMain GetParent()
        {
            return _launcher;
        }
    }
}
