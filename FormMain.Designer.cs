namespace BillingClientV3
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lblInfo = new System.Windows.Forms.Label();
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tanyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerPush = new System.Windows.Forms.Timer(this.components);
            this.timerTask = new System.Windows.Forms.Timer(this.components);
            this.timerChat = new System.Windows.Forms.Timer(this.components);
            this.menuTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(13, 13);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(13, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "..";
            // 
            // tray
            // 
            this.tray.ContextMenuStrip = this.menuTray;
            this.tray.Icon = ((System.Drawing.Icon)(resources.GetObject("tray.Icon")));
            this.tray.Text = "BillingClientV3";
            this.tray.Visible = true;
            // 
            // menuTray
            // 
            this.menuTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopToolStripMenuItem,
            this.refillToolStripMenuItem,
            this.chatToolStripMenuItem,
            this.beliToolStripMenuItem,
            this.tanyaToolStripMenuItem});
            this.menuTray.Name = "menuTray";
            this.menuTray.Size = new System.Drawing.Size(153, 136);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stopToolStripMenuItem.Text = "&Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // refillToolStripMenuItem
            // 
            this.refillToolStripMenuItem.Name = "refillToolStripMenuItem";
            this.refillToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.refillToolStripMenuItem.Text = "&Refill";
            this.refillToolStripMenuItem.Click += new System.EventHandler(this.refillToolStripMenuItem_Click);
            // 
            // chatToolStripMenuItem
            // 
            this.chatToolStripMenuItem.Name = "chatToolStripMenuItem";
            this.chatToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.chatToolStripMenuItem.Text = "&Chat";
            this.chatToolStripMenuItem.Click += new System.EventHandler(this.chatToolStripMenuItem_Click);
            // 
            // beliToolStripMenuItem
            // 
            this.beliToolStripMenuItem.Name = "beliToolStripMenuItem";
            this.beliToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.beliToolStripMenuItem.Text = "&Beli";
            // 
            // tanyaToolStripMenuItem
            // 
            this.tanyaToolStripMenuItem.Name = "tanyaToolStripMenuItem";
            this.tanyaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tanyaToolStripMenuItem.Text = "&Tanya";
            // 
            // timerPush
            // 
            this.timerPush.Interval = 5000;
            this.timerPush.Tick += new System.EventHandler(this.timerPush_Tick);
            // 
            // timerTask
            // 
            this.timerTask.Enabled = true;
            this.timerTask.Interval = 5000;
            this.timerTask.Tick += new System.EventHandler(this.timerTask_Tick);
            // 
            // timerChat
            // 
            this.timerChat.Enabled = true;
            this.timerChat.Interval = 5000;
            this.timerChat.Tick += new System.EventHandler(this.timerChat_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(460, 270);
            this.Controls.Add(this.lblInfo);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormMain";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.VisibleChanged += new System.EventHandler(this.FormMain_VisibleChanged);
            this.menuTray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.NotifyIcon tray;
        private System.Windows.Forms.ContextMenuStrip menuTray;
        private System.Windows.Forms.ToolStripMenuItem refillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tanyaToolStripMenuItem;
        private System.Windows.Forms.Timer timerPush;
        private System.Windows.Forms.Timer timerTask;
        private System.Windows.Forms.Timer timerChat;
    }
}

