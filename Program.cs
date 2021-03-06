﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace BillingClientV3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process currentProcess = Process.GetCurrentProcess();
            if (Process.GetProcessesByName(currentProcess.ProcessName, currentProcess.MachineName).Length > 1)
            {
                MessageBox.Show(null, "Another instance of this Application is running, Please close it and try again.", "We are sorry,");
                return;
            }
            Application.ApplicationExit += Application_ApplicationExit;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
        static void Application_ApplicationExit(object sender, EventArgs e)
        {
            //Showing Up The Task Bar If Hidden
            if( !Settings.System.DisplayTaskBar )
                WinAPI.Taskbar.Show();

            //Enable Task Switch
            if( !Settings.System.EnableTaskSwitch )
                WinAPI.TaskSwitching_Enable_Disable(true);
        }

  
    }
}
