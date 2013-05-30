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
    public partial class FormLogin : Form
    {
        public class FormMode 
        {
            public const int Timecode = 1;
            public const int Refill = 2;
        }
        private int _formMode;
        private FormInfo _launcher;
        private List<string> _months,_days;
        private DateTime _now;
        private RestController<SessionInformation> _rss;
        private SessionInformation _ssi;
        private FormAdmin _frmAdmin;
        public void SetMode( int formMode ) 
        {
            _formMode = formMode;
        }
        public FormLogin(FormInfo frmInfo, RestController<SessionInformation> rss )
        {
            _ssi = null;
            _rss = rss;
            _launcher = frmInfo;
            _months = new List<string>() { 
                "",
                "Januari",
                "Februari",
                "Maret",
                "April",
                "Mei",
                "Juni",
                "Juli",
                "Agustus",
                "September",
                "November",
                "Oktober",
                "November",
                "Desember"
            };
            _days = new List<string>(){
                "Minggu",
                "Senin",
                "Selasa",
                "Rabu",
                "Kamis",
                "Jumat",
                "Sabtu",
                
            };
            _frmAdmin = new FormAdmin();
            InitializeComponent();
        }

        private void FormLogin_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                timerClock.Enabled = true;
                
            }
            else
            {
                timerClock.Enabled = false;
            }
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            _now = DateTime.Now;
            int day = (int)_now.DayOfWeek;
            string dayString = _days[day];
            lblClock.Text = dayString + ", " + _now.Day + " " + _months[_now.Month] + " " + _now.Year + " "+_now.Hour.ToString("D2") + ":" + _now.Minute.ToString("D2") + ":" + _now.Second.ToString("D2");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (!_frmAdmin.Visible)
            {
                _frmAdmin.BringToFront();
                _frmAdmin.Show();
            }
            //Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            BringToFront();
            txtTimecode.Focus();
            txtNick.Text = _launcher.GetParent().GetClientInfo().Name;
        }

        private void txtTimecode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && txtTimecode.Text.Length == 7) 
            {
                TimecodeCheckGet();
            }
        }
        public SessionInformation GetSessionInfo()
        {
            return _ssi;
        }
        private void TimecodeCheckGet()
        {
            if (txtTimecode.Text.Length != 7 && txtNick.Text.Length < 1 )
                MessageBox.Show(null,"Mohon lengkapi data Anda", "Maaf");

            string resource=null; 
            string code = Utils.Md5(txtTimecode.Text);

            if(_formMode == FormMode.Timecode )
                resource = "ClientLogin";

            //SessionInformation si = null;
            string parameter = "?data=" + code;
            _rss.SetResource(resource);

            try
            {
                _ssi = _rss.GetData(parameter);
                Hide();
               
            }
            catch(Exception exp)
            {
                MessageBox.Show(null,"Kode tidak berlaku","Maaf,");
            }
        }

        private void btnOke_Click(object sender, EventArgs e)
        {
            TimecodeCheckGet();
        }

        private void ckShowTc_CheckStateChanged(object sender, EventArgs e)
        {
            if (ckShowTc.Checked)
                txtTimecode.UseSystemPasswordChar = false;
            else
                txtTimecode.UseSystemPasswordChar = true;
        }
    }
}
