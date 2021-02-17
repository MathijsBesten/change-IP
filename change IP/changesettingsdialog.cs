using change_IP.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace change_IP
{
    public partial class change_settings : Form
    {
        public change_settings()
        {
            InitializeComponent();
        }
        string settingName;
        public void ShowDialog(string setting, string settingsname, string currentValue )
        {
            settingName = settingsname;
            instellingNaam.Text = setting;
            inputBox.Text = currentValue;
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                inputBox.Items.Add(nic.Name);
            }
            this.ShowDialog();
        }

        private void opslaanButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default[settingName] = inputBox.Text;
            Settings.Default.Save();
            this.Close();
        }
    }
}
