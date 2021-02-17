namespace change_IP
{
    partial class change_settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(change_settings));
            this.label1 = new System.Windows.Forms.Label();
            this.instellingNaam = new System.Windows.Forms.Label();
            this.opslaanButton = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verander instelling";
            // 
            // instellingNaam
            // 
            this.instellingNaam.AutoSize = true;
            this.instellingNaam.Location = new System.Drawing.Point(183, 127);
            this.instellingNaam.Name = "instellingNaam";
            this.instellingNaam.Size = new System.Drawing.Size(73, 13);
            this.instellingNaam.TabIndex = 1;
            this.instellingNaam.Text = "instellingnaam";
            // 
            // opslaanButton
            // 
            this.opslaanButton.Location = new System.Drawing.Point(257, 182);
            this.opslaanButton.Name = "opslaanButton";
            this.opslaanButton.Size = new System.Drawing.Size(75, 23);
            this.opslaanButton.TabIndex = 3;
            this.opslaanButton.Text = "Opslaan";
            this.opslaanButton.UseVisualStyleBackColor = true;
            this.opslaanButton.Click += new System.EventHandler(this.opslaanButton_Click);
            // 
            // inputBox
            // 
            this.inputBox.FormattingEnabled = true;
            this.inputBox.Location = new System.Drawing.Point(289, 124);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(169, 21);
            this.inputBox.TabIndex = 4;
            // 
            // change_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 354);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.opslaanButton);
            this.Controls.Add(this.instellingNaam);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "change_settings";
            this.Text = "Verander instelling...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label instellingNaam;
        private System.Windows.Forms.Button opslaanButton;
        private System.Windows.Forms.ComboBox inputBox;
    }
}