using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;

namespace BillingClientV3
{
    public partial class FormPopUp : Form
    {
        private FormMain _launcher;
        private int _animationTime;
		private int _flags;
        private ProcessMonitor _procMon;

        public FormPopUp(FormMain frmMain)
        {

            InitializeComponent();
            _procMon = new ProcessMonitor(Settings.ProcessMonitor.ProcessOwner);
            _launcher = frmMain;
            Rectangle r = Screen.PrimaryScreen.WorkingArea;
            StartPosition = FormStartPosition.Manual;
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width, Screen.PrimaryScreen.WorkingArea.Height - Height);
        }

        public void Show(int AnimationTime, int Flags )
        {
            _animationTime = AnimationTime;
            _flags = Flags;
        }
        
        public void Hide(int AnimationTime, int Flags )
        {
            _animationTime = AnimationTime;
            _flags = Flags;
        }
        public void SetText(string text)
        {
            lblTime.Text = text;
        }
        private void FormPopUp_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _flags = WinAPI.AW_ACTIVATE | WinAPI.AW_VER_POSITIVE;
            _animationTime = 1000;
            WinAPI.AnimateWindow(this.Handle, _animationTime, _flags);
        }

        private void FormPopUp_VisibleChanged(object sender, EventArgs e)
        {
            timerProcess.Enabled = Visible;
        }

        private void timerProcess_Tick(object sender, EventArgs e)
        {
            cbPsLists.DataSource =  _procMon.Watch();
            lblRunningProcess.Text = string.Format("Running Process({0})",_procMon.GetProcessCount());
        }
    }
}
