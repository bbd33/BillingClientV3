using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingClientV3
{
    public class ClientInformation : Entities
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Ip { get; set; }
        public string Group { get; set; }
    }
    public class ClientInformations : List<ClientInformation> { }
}
