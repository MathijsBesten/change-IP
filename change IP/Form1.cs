using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
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
        public string NICnaam = Properties.Settings.Default.NICnaam; //naam van WIFI adaptor
        public string LANnaam = Properties.Settings.Default.LANnaam; //naam van LAN adaptor
        public string Gateway = Properties.Settings.Default.Gateway;
        public string IPRouter = Properties.Settings.Default.IPRouter;
        #endregion
        #region button_click
        private void saveSettings_Click(object sender, EventArgs e)
        {
            IPAddress geldigIPAdres;
            bool inputIsValid = IPAddress.TryParse(Input.Text,out geldigIPAdres);
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
                        ProcessStartInfo psi = new ProcessStartInfo("netsh", "interface ip set address \""+ NaamNetwerkInterface + "\" static " + geldigIPAdres.ToString() + " 255.255.255.0 "+ Gateway + " 1");
                        psi.Verb = "runas";
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
        private void turnOnDHCP_Click(object sender, EventArgs e)
        {
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

                try
                {
                    Process p = new Process();
                    ProcessStartInfo psi = new ProcessStartInfo("netsh", "interface ip set address \"" + NICnaam + "\" dhcp");
                    psi.Verb = "runas";
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://"+ Properties.Settings.Default.IPRouter);
            }
            catch (Exception error)
            {
                MessageBox.Show("kan webpagina niet openen - foutmelding: " + error.Message);
                throw;
            }
        }
        #endregion
        #region settingseditors 
        private void lANNaamWijzigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_settings dialog = new change_settings();
            dialog.ShowDialog("Netwerk adapter naam", "LANnaam", Properties.Settings.Default.LANnaam);
            LANnaam = Properties.Settings.Default.LANnaam;
        }
        private void iPInstellingenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_settings dialog = new change_settings();
            dialog.ShowDialog("Netwerk adapter naam", "NICnaam", Properties.Settings.Default.NICnaam);
            NICnaam = Properties.Settings.Default.NICnaam;
        }
        private void gatewayWijzigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_settings dialog = new change_settings();
            dialog.ShowDialog("Gateway", "Gateway", Properties.Settings.Default.Gateway);
            MessageBox.Show(Gateway);
        }
        private void standaardRouterpoortWijzigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_settings dialog = new change_settings();
            dialog.ShowDialog("Standaard router IP adres", "IPRouter", Properties.Settings.Default.IPRouter);
            IPRouter = Properties.Settings.Default.IPRouter;
        }
        #endregion
    }
}
