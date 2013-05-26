namespace BillingClientV3
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOke = new System.Windows.Forms.Button();
            this.txtTimecode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Timecode :";
            // 
            // btnOke
            // 
            this.btnOke.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnOke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOke.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnOke.Location = new System.Drawing.Point(231, 56);
            this.btnOke.Name = "btnOke";
            this.btnOke.Size = new System.Drawing.Size(51, 40);
            this.btnOke.TabIndex = 1;
            this.btnOke.Text = "Oke";
            this.btnOke.UseVisualStyleBackColor = false;
            // 
            // txtTimecode
            // 
            this.txtTimecode.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTimecode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimecode.Location = new System.Drawing.Point(23, 58);
            this.txtTimecode.Name = "txtTimecode";
            this.txtTimecode.Size = new System.Drawing.Size(202, 38);
            this.txtTimecode.TabIndex = 2;
            this.txtTimecode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimecode_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Masukkan 7 digit timecode.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnOke);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTimecode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 146);
            this.panel1.TabIndex = 4;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(183, 171);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(126, 13);
            this.lblCopyright.TabIndex = 5;
            this.lblCopyright.Text = "© 2013 Damar NET, Inc.";
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Location = new System.Drawing.Point(12, 171);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(111, 13);
            this.lblClock.TabIndex = 4;
            this.lblClock.Text = "26 Mei 2013 18:03:00";
            // 
            // timerClock
            // 
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(262, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(322, 195);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Opacity = 0.8;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.VisibleChanged += new System.EventHandler(this.FormLogin_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOke;
        private System.Windows.Forms.TextBox txtTimecode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Button btnClose;
    }
}