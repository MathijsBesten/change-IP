namespace change_IP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.debugInstructionsLabel = new System.Windows.Forms.Label();
            this.helloWorldLabel = new System.Windows.Forms.Label();
            this.ipadreslabel = new System.Windows.Forms.Label();
            this.saveSettings = new System.Windows.Forms.Button();
            this.turnOnDHCP = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.geavanceerdeInstellingenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lANNaamWijzigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iPInstellingenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gatewayWijzigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.kiesWifiOfLanPanel = new System.Windows.Forms.Panel();
            this.wifiVerbindingButton = new System.Windows.Forms.RadioButton();
            this.lanVerbindingButton = new System.Windows.Forms.RadioButton();
            this.verbindingLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.currentSettingsLabel = new System.Windows.Forms.Label();
            this.currentGateway = new System.Windows.Forms.TextBox();
            this.currentSubnet = new System.Windows.Forms.TextBox();
            this.currentIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.kiesWifiOfLanPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // debugInstructionsLabel
            // 
            this.debugInstructionsLabel.Location = new System.Drawing.Point(49, 50);
            this.debugInstructionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.debugInstructionsLabel.Name = "debugInstructionsLabel";
            this.debugInstructionsLabel.Size = new System.Drawing.Size(323, 30);
            this.debugInstructionsLabel.TabIndex = 1;
            this.debugInstructionsLabel.Text = "Vul handmatig een IP adres in of kies voor \"DHCP aanzetten\" om automatisch een IP" +
    " adres te krijgen";
            // 
            // helloWorldLabel
            // 
            this.helloWorldLabel.AutoSize = true;
            this.helloWorldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloWorldLabel.Location = new System.Drawing.Point(47, 24);
            this.helloWorldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.helloWorldLabel.Name = "helloWorldLabel";
            this.helloWorldLabel.Size = new System.Drawing.Size(320, 26);
            this.helloWorldLabel.TabIndex = 3;
            this.helloWorldLabel.Text = "IP adres instellingen aanpassen";
            // 
            // ipadreslabel
            // 
            this.ipadreslabel.AutoSize = true;
            this.ipadreslabel.Location = new System.Drawing.Point(49, 109);
            this.ipadreslabel.Name = "ipadreslabel";
            this.ipadreslabel.Size = new System.Drawing.Size(46, 13);
            this.ipadreslabel.TabIndex = 4;
            this.ipadreslabel.Text = "IP adres";
            // 
            // saveSettings
            // 
            this.saveSettings.Location = new System.Drawing.Point(52, 195);
            this.saveSettings.Name = "saveSettings";
            this.saveSettings.Size = new System.Drawing.Size(103, 23);
            this.saveSettings.TabIndex = 5;
            this.saveSettings.Text = "IP adres opslaan";
            this.saveSettings.UseVisualStyleBackColor = true;
            this.saveSettings.Click += new System.EventHandler(this.SaveSettings_Click);
            // 
            // turnOnDHCP
            // 
            this.turnOnDHCP.Location = new System.Drawing.Point(188, 195);
            this.turnOnDHCP.Name = "turnOnDHCP";
            this.turnOnDHCP.Size = new System.Drawing.Size(121, 23);
            this.turnOnDHCP.TabIndex = 6;
            this.turnOnDHCP.Text = "Automatisch IP adres";
            this.turnOnDHCP.UseVisualStyleBackColor = true;
            this.turnOnDHCP.Click += new System.EventHandler(this.TurnOnDHCP_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(101, 106);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(100, 20);
            this.Input.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geavanceerdeInstellingenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // geavanceerdeInstellingenToolStripMenuItem
            // 
            this.geavanceerdeInstellingenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lANNaamWijzigenToolStripMenuItem,
            this.iPInstellingenToolStripMenuItem,
            this.gatewayWijzigenToolStripMenuItem});
            this.geavanceerdeInstellingenToolStripMenuItem.Name = "geavanceerdeInstellingenToolStripMenuItem";
            this.geavanceerdeInstellingenToolStripMenuItem.Size = new System.Drawing.Size(157, 20);
            this.geavanceerdeInstellingenToolStripMenuItem.Text = "Geavanceerde instellingen";
            // 
            // lANNaamWijzigenToolStripMenuItem
            // 
            this.lANNaamWijzigenToolStripMenuItem.Name = "lANNaamWijzigenToolStripMenuItem";
            this.lANNaamWijzigenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lANNaamWijzigenToolStripMenuItem.Text = "LAN naam wijzigen";
            this.lANNaamWijzigenToolStripMenuItem.Click += new System.EventHandler(this.LANNaamWijzigenToolStripMenuItem_Click);
            // 
            // iPInstellingenToolStripMenuItem
            // 
            this.iPInstellingenToolStripMenuItem.Name = "iPInstellingenToolStripMenuItem";
            this.iPInstellingenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iPInstellingenToolStripMenuItem.Text = "WIFI naam wijzigen";
            this.iPInstellingenToolStripMenuItem.Click += new System.EventHandler(this.IPInstellingenToolStripMenuItem_Click);
            // 
            // gatewayWijzigenToolStripMenuItem
            // 
            this.gatewayWijzigenToolStripMenuItem.Name = "gatewayWijzigenToolStripMenuItem";
            this.gatewayWijzigenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gatewayWijzigenToolStripMenuItem.Text = "Gateway wijzigen";
            this.gatewayWijzigenToolStripMenuItem.Click += new System.EventHandler(this.GatewayWijzigenToolStripMenuItem_Click);
            // 
            // kiesWifiOfLanPanel
            // 
            this.kiesWifiOfLanPanel.Controls.Add(this.wifiVerbindingButton);
            this.kiesWifiOfLanPanel.Controls.Add(this.lanVerbindingButton);
            this.kiesWifiOfLanPanel.Location = new System.Drawing.Point(101, 140);
            this.kiesWifiOfLanPanel.Name = "kiesWifiOfLanPanel";
            this.kiesWifiOfLanPanel.Size = new System.Drawing.Size(149, 48);
            this.kiesWifiOfLanPanel.TabIndex = 11;
            // 
            // wifiVerbindingButton
            // 
            this.wifiVerbindingButton.AutoSize = true;
            this.wifiVerbindingButton.Location = new System.Drawing.Point(3, 26);
            this.wifiVerbindingButton.Name = "wifiVerbindingButton";
            this.wifiVerbindingButton.Size = new System.Drawing.Size(100, 17);
            this.wifiVerbindingButton.TabIndex = 1;
            this.wifiVerbindingButton.TabStop = true;
            this.wifiVerbindingButton.Text = "WIFI verbinding";
            this.wifiVerbindingButton.UseVisualStyleBackColor = true;
            this.wifiVerbindingButton.CheckedChanged += new System.EventHandler(this.wifiVerbindingButton_CheckedChanged);
            // 
            // lanVerbindingButton
            // 
            this.lanVerbindingButton.AutoSize = true;
            this.lanVerbindingButton.Location = new System.Drawing.Point(3, 3);
            this.lanVerbindingButton.Name = "lanVerbindingButton";
            this.lanVerbindingButton.Size = new System.Drawing.Size(98, 17);
            this.lanVerbindingButton.TabIndex = 0;
            this.lanVerbindingButton.TabStop = true;
            this.lanVerbindingButton.Text = "LAN verbinding";
            this.lanVerbindingButton.UseVisualStyleBackColor = true;
            this.lanVerbindingButton.CheckedChanged += new System.EventHandler(this.lanVerbindingButton_CheckedChanged);
            // 
            // verbindingLabel
            // 
            this.verbindingLabel.AutoSize = true;
            this.verbindingLabel.Location = new System.Drawing.Point(49, 140);
            this.verbindingLabel.Name = "verbindingLabel";
            this.verbindingLabel.Size = new System.Drawing.Size(44, 13);
            this.verbindingLabel.TabIndex = 12;
            this.verbindingLabel.Text = "Adapter";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.currentSettingsLabel);
            this.panel1.Controls.Add(this.currentGateway);
            this.panel1.Controls.Add(this.currentSubnet);
            this.panel1.Controls.Add(this.currentIP);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(333, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 154);
            this.panel1.TabIndex = 13;
            // 
            // currentSettingsLabel
            // 
            this.currentSettingsLabel.AutoSize = true;
            this.currentSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentSettingsLabel.Location = new System.Drawing.Point(13, 28);
            this.currentSettingsLabel.Name = "currentSettingsLabel";
            this.currentSettingsLabel.Size = new System.Drawing.Size(125, 16);
            this.currentSettingsLabel.TabIndex = 6;
            this.currentSettingsLabel.Text = "Huidige instellingen";
            // 
            // currentGateway
            // 
            this.currentGateway.Location = new System.Drawing.Point(69, 113);
            this.currentGateway.Name = "currentGateway";
            this.currentGateway.ReadOnly = true;
            this.currentGateway.Size = new System.Drawing.Size(100, 20);
            this.currentGateway.TabIndex = 5;
            // 
            // currentSubnet
            // 
            this.currentSubnet.Location = new System.Drawing.Point(69, 86);
            this.currentSubnet.Name = "currentSubnet";
            this.currentSubnet.ReadOnly = true;
            this.currentSubnet.Size = new System.Drawing.Size(100, 20);
            this.currentSubnet.TabIndex = 4;
            // 
            // currentIP
            // 
            this.currentIP.Location = new System.Drawing.Point(69, 60);
            this.currentIP.Name = "currentIP";
            this.currentIP.ReadOnly = true;
            this.currentIP.Size = new System.Drawing.Size(100, 20);
            this.currentIP.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gateway";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subnet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.verbindingLabel);
            this.Controls.Add(this.kiesWifiOfLanPanel);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.turnOnDHCP);
            this.Controls.Add(this.saveSettings);
            this.Controls.Add(this.ipadreslabel);
            this.Controls.Add(this.helloWorldLabel);
            this.Controls.Add(this.debugInstructionsLabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Internet instellen";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.kiesWifiOfLanPanel.ResumeLayout(false);
            this.kiesWifiOfLanPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label debugInstructionsLabel;
        private System.Windows.Forms.Label helloWorldLabel;
        private System.Windows.Forms.Label ipadreslabel;
        private System.Windows.Forms.Button saveSettings;
        private System.Windows.Forms.Button turnOnDHCP;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem geavanceerdeInstellingenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iPInstellingenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gatewayWijzigenToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel kiesWifiOfLanPanel;
        private System.Windows.Forms.RadioButton wifiVerbindingButton;
        private System.Windows.Forms.RadioButton lanVerbindingButton;
        private System.Windows.Forms.Label verbindingLabel;
        private System.Windows.Forms.ToolStripMenuItem lANNaamWijzigenToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentSettingsLabel;
        private System.Windows.Forms.TextBox currentGateway;
        private System.Windows.Forms.TextBox currentSubnet;
        private System.Windows.Forms.TextBox currentIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

