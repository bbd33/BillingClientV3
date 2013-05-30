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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.ckShowTc = new System.Windows.Forms.CheckBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Timecode :";
            // 
            // btnOke
            // 
            this.btnOke.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOke.ForeColor = System.Drawing.Color.SeaShell;
            this.btnOke.Location = new System.Drawing.Point(247, 203);
            this.btnOke.Name = "btnOke";
            this.btnOke.Size = new System.Drawing.Size(134, 57);
            this.btnOke.TabIndex = 1;
            this.btnOke.Text = "Masuk";
            this.btnOke.UseVisualStyleBackColor = false;
            this.btnOke.Click += new System.EventHandler(this.btnOke_Click);
            // 
            // txtTimecode
            // 
            this.txtTimecode.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTimecode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimecode.Location = new System.Drawing.Point(247, 135);
            this.txtTimecode.MaxLength = 7;
            this.txtTimecode.Name = "txtTimecode";
            this.txtTimecode.Size = new System.Drawing.Size(222, 38);
            this.txtTimecode.TabIndex = 2;
            this.txtTimecode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimecode_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "- Masukkan 7 digit timecode yang sudah Anda beli.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNick);
            this.panel1.Controls.Add(this.lblNama);
            this.panel1.Controls.Add(this.lblClock);
            this.panel1.Controls.Add(this.ckShowTc);
            this.panel1.Controls.Add(this.lblCopyright);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnOke);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTimecode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 530);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "- Tekan Enter atau Klik tombol Masuk.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(236, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "- Masukkan nama Anda sebagai identitas.";
            // 
            // txtNick
            // 
            this.txtNick.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNick.Location = new System.Drawing.Point(247, 73);
            this.txtNick.MaxLength = 20;
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(355, 38);
            this.txtNick.TabIndex = 7;
            this.txtNick.Text = "12345678901234567890";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(86, 73);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(136, 25);
            this.lblNama.TabIndex = 6;
            this.lblNama.Text = "Nama Anda :";
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Location = new System.Drawing.Point(17, 504);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(111, 13);
            this.lblClock.TabIndex = 4;
            this.lblClock.Text = "26 Mei 2013 18:03:00";
            // 
            // ckShowTc
            // 
            this.ckShowTc.AutoSize = true;
            this.ckShowTc.Checked = true;
            this.ckShowTc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckShowTc.Location = new System.Drawing.Point(487, 135);
            this.ckShowTc.Name = "ckShowTc";
            this.ckShowTc.Size = new System.Drawing.Size(115, 17);
            this.ckShowTc.TabIndex = 5;
            this.ckShowTc.Text = " Tampilkan Kode ?";
            this.ckShowTc.UseVisualStyleBackColor = true;
            this.ckShowTc.CheckStateChanged += new System.EventHandler(this.ckShowTc_CheckStateChanged);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(797, 504);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(173, 13);
            this.lblCopyright.TabIndex = 5;
            this.lblCopyright.Text = "© Copyright 2013 Damar NET, Inc.";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(950, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timerClock
            // 
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1011, 553);
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
        private System.Windows.Forms.CheckBox ckShowTc;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}