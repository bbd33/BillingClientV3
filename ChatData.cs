using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingClientV3
{
    public class ChatData
    {
        public int ID { set; get; }
        public int RecepientID { set; get; }
        public int SenderID { set; get; }
        public string Message { set; get; }
        public int IsDisplayed { set; get; }
        public DateTime UpdatedOn { set; get; }
    }

    public class ChatDatas : List<ChatData> { } 
}
