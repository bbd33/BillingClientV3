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
        private FormInfo _launcher;
        private List<string> _months,_days;
        private DateTime _now;

        public FormLogin(FormInfo frmInfo )
        {
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
            lblClock.Text = dayString + ", " + _now.Day + " " + _months[_now.Month] + " " + _now.Year + " "+_now.Hour + ":" + _now.Minute + ":" + _now.Second;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            BringToFront();
            txtTimecode.Focus();
        }

        private void txtTimecode_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
