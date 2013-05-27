using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace BillingClientV3
{
    public class Utils
    {
        public static string Md5(string input){
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
        public static string DurationToText(int duration)
        {
            int hour = duration / 3600;
            int secondLeft = duration % 3600;
            int minute = secondLeft / 60;

            secondLeft = secondLeft % 60;
            String durationText = "";

            if (hour > 0)
                durationText += hour.ToString() + " Jam ";

            if (minute > 0)
                durationText += " " + minute.ToString() + " Menit ";

            if (secondLeft > 0)
                durationText += " " + secondLeft.ToString() + " Detik";

            return durationText;
        }
    }

    
}
