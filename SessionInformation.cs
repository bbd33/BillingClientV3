using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingClientV3
{
    public class SessionInformation : Entities
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public int Duration { get; set; }
        public DateTime UpdatedOn { get; set; }
        public DateTime ExpiredAt { get; set; }
        public string Text { get; set; }
        public string StationID { get; set; }
        public string Nick { get; set; }
    }
}
