using change_IP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace change_IP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region public values
        public string NICnaam = Properties.Settings.Default.NICnaam; //naam van WIFI adapter
        public string LANnaam = Properties.Settings.Default.LANnaam; //naam van LAN adapter
        public string Gateway = Properties.Settings.Default.Gateway;
        #endregion
        #region save setting main
        private void SaveSettings_Click(object sender, EventArgs e)
        {
            ChangeIPOrDHCP(true);
        }
        private void TurnOnDHCP_Click(object sender, EventArgs e)
        {
            ChangeIPOrDHCP(false);
        }
        
        public void ChangeIPOrDHCP(bool changeToStaticIP) //true = static IP - false = DHCP
        {
            bool inputIsValid = IPAddress.TryParse(Input.Text, out IPAddress geldigIPAdres); //out geldigIPAdres is a now a variable
            if (wifiVerbindingButton.Checked == false && lanVerbindingButton.Checked == false)
            {
                MessageBox.Show("Er is geen Netwerk interface geselecteerd. Kies WIFI of LAN. Probeer het opnieuw");
                return;
            }
            else
            {
                string NaamNetwerkInterface;
                if (wifiVerbindingButton.Checked == true)
                {
                    NaamNetwerkInterface = NICnaam;
                }
                else // LAN is now the only option
                {
                    NaamNetwerkInterface = LANnaam;
                }
                if (inputIsValid)
                {
                    try
                    {
                        Process p = new Process();
                        ProcessStartInfo psi;
                        if (changeToStaticIP)//Static IP address
                        {
                             psi = new ProcessStartInfo("netsh", "interface ip set address \"" + NaamNetwerkInterface + "\" static " + geldigIPAdres.ToString() + " 255.255.255.0 " + Gateway + " 1"){Verb = "runas"};
                        }
                        else //DHCP
                        {
                             psi = new ProcessStartInfo("netsh", "interface ip set address \"" + NaamNetwerkInterface + "\" dhcp"){Verb = "runas"};
                        }

                        p.StartInfo = psi;
                        p.Start();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                        throw;
                    }
                }
            }
        }
        #endregion
        #region settingseditors 
        private void LANNaamWijzigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_settings dialog = new change_settings();
            dialog.ShowDialog("LAN adapter naam", "LANnaam", Properties.Settings.Default.LANnaam);
            LANnaam = Properties.Settings.Default.LANnaam;
        }
        private void IPInstellingenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_settings dialog = new change_settings();
            dialog.ShowDialog("WIFI adapter naam", "NICnaam", Properties.Settings.Default.NICnaam);
            NICnaam = Properties.Settings.Default.NICnaam;
        }
        private void GatewayWijzigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_settings dialog = new change_settings();
            dialog.ShowDialog("Gateway", "Gateway", Properties.Settings.Default.Gateway);
            Gateway = Properties.Settings.Default.Gateway;
        }
        #endregion
        #region radiobutton change
        private void lanVerbindingButton_CheckedChanged(object sender, EventArgs e)
        {
            if (lanVerbindingButton.Checked)
            {
                VernieuwHuidigeIPGegevens(true);
            }
        }

        private void wifiVerbindingButton_CheckedChanged(object sender, EventArgs e)
        {
            if (wifiVerbindingButton.Checked)
            {
                VernieuwHuidigeIPGegevens(false);
            }
        }
        public void VernieuwHuidigeIPGegevens(bool adapterIsLan)// true = lan  - false = wifi
        {
            IPClass IPData = Functions.IPDetails.GetAdapterIPConfig(adapterIsLan); 
            currentIP.Text = IPData.IPAddress;
            currentSubnet.Text = IPData.Subnetmask;
            currentGateway.Text = IPData.Gateway;
        }
        #endregion
    }
}
