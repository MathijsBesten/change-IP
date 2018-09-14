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
            this.iPInstellingenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gatewayWijzigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // debugInstructionsLabel
            // 
            this.debugInstructionsLabel.Location = new System.Drawing.Point(114, 50);
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
            this.helloWorldLabel.Location = new System.Drawing.Point(112, 24);
            this.helloWorldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.helloWorldLabel.Name = "helloWorldLabel";
            this.helloWorldLabel.Size = new System.Drawing.Size(320, 26);
            this.helloWorldLabel.TabIndex = 3;
            this.helloWorldLabel.Text = "IP adres instellingen aanpassen";
            // 
            // ipadreslabel
            // 
            this.ipadreslabel.AutoSize = true;
            this.ipadreslabel.Location = new System.Drawing.Point(114, 134);
            this.ipadreslabel.Name = "ipadreslabel";
            this.ipadreslabel.Size = new System.Drawing.Size(46, 13);
            this.ipadreslabel.TabIndex = 4;
            this.ipadreslabel.Text = "IP adres";
            // 
            // saveSettings
            // 
            this.saveSettings.Location = new System.Drawing.Point(117, 157);
            this.saveSettings.Name = "saveSettings";
            this.saveSettings.Size = new System.Drawing.Size(103, 23);
            this.saveSettings.TabIndex = 5;
            this.saveSettings.Text = "IP adres opslaan";
            this.saveSettings.UseVisualStyleBackColor = true;
            this.saveSettings.Click += new System.EventHandler(this.saveSettings_Click);
            // 
            // turnOnDHCP
            // 
            this.turnOnDHCP.Location = new System.Drawing.Point(117, 233);
            this.turnOnDHCP.Name = "turnOnDHCP";
            this.turnOnDHCP.Size = new System.Drawing.Size(121, 23);
            this.turnOnDHCP.TabIndex = 6;
            this.turnOnDHCP.Text = "Automatisch IP adres";
            this.turnOnDHCP.UseVisualStyleBackColor = true;
            this.turnOnDHCP.Click += new System.EventHandler(this.turnOnDHCP_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(166, 131);
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
            this.iPInstellingenToolStripMenuItem,
            this.gatewayWijzigenToolStripMenuItem});
            this.geavanceerdeInstellingenToolStripMenuItem.Name = "geavanceerdeInstellingenToolStripMenuItem";
            this.geavanceerdeInstellingenToolStripMenuItem.Size = new System.Drawing.Size(157, 20);
            this.geavanceerdeInstellingenToolStripMenuItem.Text = "Geavanceerde instellingen";
            // 
            // iPInstellingenToolStripMenuItem
            // 
            this.iPInstellingenToolStripMenuItem.Name = "iPInstellingenToolStripMenuItem";
            this.iPInstellingenToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.iPInstellingenToolStripMenuItem.Text = "NIC wijzigen";
            this.iPInstellingenToolStripMenuItem.Click += new System.EventHandler(this.iPInstellingenToolStripMenuItem_Click);
            // 
            // gatewayWijzigenToolStripMenuItem
            // 
            this.gatewayWijzigenToolStripMenuItem.Name = "gatewayWijzigenToolStripMenuItem";
            this.gatewayWijzigenToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.gatewayWijzigenToolStripMenuItem.Text = "Gateway wijzigen";
            this.gatewayWijzigenToolStripMenuItem.Click += new System.EventHandler(this.gatewayWijzigenToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
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
    }
}

