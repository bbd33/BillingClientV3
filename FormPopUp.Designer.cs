namespace BillingClientV3
{
    partial class FormPopUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.cbPsLists = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerProcess = new System.Windows.Forms.Timer(this.components);
            this.lblRunningProcess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnClose.Location = new System.Drawing.Point(160, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 20);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "-";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblTime.Location = new System.Drawing.Point(12, 384);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(16, 13);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "...";
            // 
            // cbPsLists
            // 
            this.cbPsLists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbPsLists.FormattingEnabled = true;
            this.cbPsLists.Location = new System.Drawing.Point(15, 38);
            this.cbPsLists.Name = "cbPsLists";
            this.cbPsLists.Size = new System.Drawing.Size(160, 332);
            this.cbPsLists.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(10, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 39);
            this.panel1.TabIndex = 3;
            // 
            // timerProcess
            // 
            this.timerProcess.Interval = 5000;
            this.timerProcess.Tick += new System.EventHandler(this.timerProcess_Tick);
            // 
            // lblRunningProcess
            // 
            this.lblRunningProcess.AutoSize = true;
            this.lblRunningProcess.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblRunningProcess.Location = new System.Drawing.Point(15, 4);
            this.lblRunningProcess.Name = "lblRunningProcess";
            this.lblRunningProcess.Size = new System.Drawing.Size(16, 13);
            this.lblRunningProcess.TabIndex = 4;
            this.lblRunningProcess.Text = "...";
            // 
            // FormPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(187, 406);
            this.Controls.Add(this.lblRunningProcess);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbPsLists);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPopUp";
            this.Opacity = 0.8;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormPopUp";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormPopUp_Load);
            this.VisibleChanged += new System.EventHandler(this.FormPopUp_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cbPsLists;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerProcess;
        private System.Windows.Forms.Label lblRunningProcess;
    }
}