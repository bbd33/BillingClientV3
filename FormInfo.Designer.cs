namespace BillingClientV3
{
    partial class FormInfo
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
            this.btnToggleShowParentForm = new System.Windows.Forms.Button();
            this.lblInfoCaption = new System.Windows.Forms.Label();
            this.lblInfoText = new System.Windows.Forms.Label();
            this.timerDot = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnToggleShowParentForm
            // 
            this.btnToggleShowParentForm.Location = new System.Drawing.Point(222, 6);
            this.btnToggleShowParentForm.Name = "btnToggleShowParentForm";
            this.btnToggleShowParentForm.Size = new System.Drawing.Size(173, 23);
            this.btnToggleShowParentForm.TabIndex = 0;
            this.btnToggleShowParentForm.Text = "Toggle Hide/Show Parent";
            this.btnToggleShowParentForm.UseVisualStyleBackColor = true;
            this.btnToggleShowParentForm.Visible = false;
            this.btnToggleShowParentForm.Click += new System.EventHandler(this.btnToggleShowParentForm_Click);
            // 
            // lblInfoCaption
            // 
            this.lblInfoCaption.AutoSize = true;
            this.lblInfoCaption.Location = new System.Drawing.Point(5, 11);
            this.lblInfoCaption.Name = "lblInfoCaption";
            this.lblInfoCaption.Size = new System.Drawing.Size(34, 13);
            this.lblInfoCaption.TabIndex = 1;
            this.lblInfoCaption.Text = "Info : ";
            this.lblInfoCaption.Visible = false;
            // 
            // lblInfoText
            // 
            this.lblInfoText.AutoSize = true;
            this.lblInfoText.ForeColor = System.Drawing.Color.Snow;
            this.lblInfoText.Location = new System.Drawing.Point(44, 11);
            this.lblInfoText.Name = "lblInfoText";
            this.lblInfoText.Size = new System.Drawing.Size(16, 13);
            this.lblInfoText.TabIndex = 2;
            this.lblInfoText.Text = "...";
            // 
            // timerDot
            // 
            this.timerDot.Interval = 500;
            this.timerDot.Tick += new System.EventHandler(this.timerDot_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.lblInfoCaption);
            this.panel1.Controls.Add(this.btnToggleShowParentForm);
            this.panel1.Controls.Add(this.lblInfoText);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 37);
            this.panel1.TabIndex = 3;
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(427, 61);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInfo";
            this.Opacity = 0.6;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInfo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormInfo_Load);
            this.VisibleChanged += new System.EventHandler(this.FormInfo_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToggleShowParentForm;
        private System.Windows.Forms.Label lblInfoCaption;
        private System.Windows.Forms.Label lblInfoText;
        private System.Windows.Forms.Timer timerDot;
        private System.Windows.Forms.Panel panel1;
    }
}