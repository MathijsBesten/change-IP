using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace change_IP.Classes
{
    public class IPClass
    {
        public IPAddress IPAddress { get; set; }
        public string Subnetmask { get; set; }
        public IPAddress Gateway { get; set; }
    }
}
