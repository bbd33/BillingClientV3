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
    public partial class FormPopUp : Form
    {
        private FormMain _launcher;
        private int _animationTime;
		private int _flags;
        public FormPopUp(FormMain frmMain)
        {

            InitializeComponent();
            _launcher = frmMain;
            Rectangle r = Screen.PrimaryScreen.WorkingArea;
            StartPosition = FormStartPosition.Manual;
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width, Screen.PrimaryScreen.WorkingArea.Height - Height);
        }

        public Show(int AnimationTime, int Flags )
        {
            _animationTime = AnimationTime;
            _flags = Flags;
        }
        
        public Hide(int AnimationTime, int Flags )
        {
            _animationTime = AnimationTime;
            _flags = Flags;
        }

        private void FormPopUp_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
