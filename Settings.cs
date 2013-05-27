using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BillingClientV3
{
    public class Settings
    {
        
        public class RestController
        { 
            public static string ServerBase = "http://10.0.0.11/damarnet/api/";
            public static string ResourcePrefix = "/format/json";
            public static string UA = "QmlsbGluZ0NsaWVudFYz";
        }
        public class Registry
        {
            class Keys
            {
                public const string Passwd = "Passwd";
                public const string ServIp = "ServIp";
                public const string DB     = "DB";
                public const string ServerBase = "RestServerBase";
                public const string ResourcePrefix = "ResourcePrefix";
            }
            public const string Root= "Software";
            public const string Key = "BillingClientV3"; 

            public static Microsoft.Win32.RegistryKey  GetKey()
            {
                Microsoft.Win32.RegistryKey registryKey = null;
                string KeyString = Registry.Root + "\\" + Registry.Key;

                registryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey( KeyString, true);
                
                if (registryKey == null)
                {
                    registryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software",true);
                    try
                    {
                        registryKey = registryKey.CreateSubKey(Registry.Key);
                    }
                    catch(Exception exp) 
                    {
                        return registryKey = null;
                    }
                }
                
                return registryKey;  
            }
            public static void Set(string key, Object value)
            {
                Microsoft.Win32.RegistryKey registryKey = Registry.GetKey();


                if( registryKey != null )
                {
                    registryKey.SetValue(key, value);        
                }
                registryKey.Close();

                 
            }
            public static Object Get(string key) 
            {
                Microsoft.Win32.RegistryKey registryKey = Registry.GetKey();
                Object Ret = null;

                if( registryKey != null )
                {
                    Ret = registryKey.GetValue(key);        
                }
                registryKey.Close();
                return Ret;
            }

            public static int Init()
            {
                int Ret = 0;

                return Ret;
            }
            
        }
        
    }
}
