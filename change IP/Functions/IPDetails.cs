using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

using change_IP.Classes;

namespace change_IP.Functions
{
    public class IPDetails
    {
        public static IPClass GetAdaptorIPConfig()
        {
            NetworkInterface[] listOFAllNetworkinterfaces =  NetworkInterface.GetAllNetworkInterfaces();
            foreach (var NetworkInterface in listOFAllNetworkinterfaces)
            {
                var bla = NetworkInterface.GetIPProperties().UnicastAddresses[0];
                var Ip = bla.Address.ToString();
                var subnetmask = bla.IPv4Mask.ToString();
                var gateway = bla.PrefixOrigin;

            }

            return null;
        }
    }
}
