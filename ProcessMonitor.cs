using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Diagnostics;

namespace BillingClientV3
{
    class ProcessMonitor
    {
        private List<string> _processList;
        private string _psOwner;
        public ProcessMonitor(string OwnerName)
        {
            _processList = new List<string>();
            _psOwner = OwnerName;
        }
        private void DeleteUnexistentProcess()
        {
            string psName = String.Empty;
            for (int i = 0; i < _processList.Count ;i++)
            {
                psName = _processList[i];
                Process[] processes = Process.GetProcessesByName(psName);
                if (processes.Length <= 0)
                {
                    _processList.RemoveAt(i);
                }
            }
        
        }
        public void AddProcess(ManagementObject mo)
        {
            string[] s = new string[2];
            mo.InvokeMethod("GetOwner", (object[])s);
            
            string ProcessOwner = s[0].ToString();
            string processName = (string)mo["Name"];
            
            //cbPsLists.Items.Add(processName + " " + ProcessOwner);
           // string s;
            bool added = _processList.Any(item => item.Contains(processName));
            if (!added) 
            {
                _processList.Add(processName);
            }
        }
        public int GetProcessCount()
        {
            return _processList.Count;
        }
        public List<string> Watch()
        {
            DeleteUnexistentProcess();
            ObjectQuery x = new ObjectQuery("Select * From Win32_Process ");
            ManagementObjectSearcher mos = new ManagementObjectSearcher(x);
            string processName = String.Empty;

            foreach (ManagementObject mo in mos.Get())
            {
                try
                {
                    AddProcess(mo);
                }
                catch { }//break;
            }
            return _processList;
        }
        
    }
}
