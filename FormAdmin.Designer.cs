namespace BillingClientV3
{
    partial class FormAdmin
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
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.lblCaptionSecret = new System.Windows.Forms.Label();
            this.btnCLose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPasswd
            // 
            this.txtPasswd.BackColor = System.Drawing.Color.Black;
            this.txtPasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswd.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.txtPasswd.Location = new System.Drawing.Point(62, 7);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.PasswordChar = '#';
            this.txtPasswd.Size = new System.Drawing.Size(140, 22);
            this.txtPasswd.TabIndex = 0;
            this.txtPasswd.Text = "jingga";
            this.txtPasswd.UseSystemPasswordChar = true;
            this.txtPasswd.Visible = false;
            // 
            // lblCaptionSecret
            // 
            this.lblCaptionSecret.AutoSize = true;
            this.lblCaptionSecret.Location = new System.Drawing.Point(12, 11);
            this.lblCaptionSecret.Name = "lblCaptionSecret";
            this.lblCaptionSecret.Size = new System.Drawing.Size(44, 13);
            this.lblCaptionSecret.TabIndex = 1;
            this.lblCaptionSecret.Text = "Secret :";
            // 
            // btnCLose
            // 
            this.btnCLose.BackColor = System.Drawing.Color.Black;
            this.btnCLose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLose.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnCLose.Location = new System.Drawing.Point(208, 7);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(26, 22);
            this.btnCLose.TabIndex = 2;
            this.btnCLose.Text = "x";
            this.btnCLose.UseVisualStyleBackColor = false;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(246, 38);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.lblCaptionSecret);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmin";
            this.Opacity = 0.8;
            this.ShowInTaskbar = false;
            this.Text = "FormAdmin";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.Label lblCaptionSecret;
        private System.Windows.Forms.Button btnCLose;
    }
}