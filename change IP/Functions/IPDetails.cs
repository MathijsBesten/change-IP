using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

using change_IP.Classes;

namespace change_IP.Functions
{
    public class IPDetails
    {
        public static IPClass GetAdaptorIPConfig(bool NICisLAN)
        {
            NetworkInterface[] listOFAllNetworkinterfaces =  NetworkInterface.GetAllNetworkInterfaces();
            string SelectedNICName;
            IPClass CurrentIPData = new IPClass();
            if (NICisLAN)
            {
                 SelectedNICName = Properties.Settings.Default.LANnaam; //naam van LAN adaptor
            }   
            else
            {
                SelectedNICName = Properties.Settings.Default.NICnaam; //naam van WIFI adaptor
            }
            foreach (var NetworkInterface in listOFAllNetworkinterfaces)
            {
                if (NetworkInterface.Name == SelectedNICName)
                {
                    var listOfAddresses = NetworkInterface.GetIPProperties().UnicastAddresses;
                    var bla = listOfAddresses[listOfAddresses.Count -1]; //get last entry in the list. Last one is always the correct one. Regartless of DHCP or Manaual
                    CurrentIPData.IPAddress = bla.Address.ToString();
                    CurrentIPData.Subnetmask = bla.IPv4Mask.ToString();
                    try
                    {
                        CurrentIPData.Gateway = NetworkInterface.GetIPProperties().GatewayAddresses[0].Address.ToString();
                    }
                    catch (Exception)
                    {
                        CurrentIPData.Gateway = "Niet bekend";
                    }
                    break;
                }                              
            }
            return CurrentIPData;
        }
    }
}
