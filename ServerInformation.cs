using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingClientV3
{
    public class ServerInformation : Entities
    {
        public int SessionInterval { get; set; }
        public int NoExpiredDate { get; set; }
        public string CompanyName { get; set; }
        public string StreetAddress { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
    }
}
