﻿namespace ClientTest
{
    partial class ClientTest
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbServerIP = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.tbServerIP = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbConnectionStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.btConnect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbDataSending = new System.Windows.Forms.TextBox();
            this.lbDateSending = new System.Windows.Forms.Label();
            this.lbDataReceiving = new System.Windows.Forms.Label();
            this.tbDataReceiving = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbServerIP
            // 
            this.lbServerIP.AutoSize = true;
            this.lbServerIP.Location = new System.Drawing.Point(3, 0);
            this.lbServerIP.Name = "lbServerIP";
            this.lbServerIP.Size = new System.Drawing.Size(54, 13);
            this.lbServerIP.TabIndex = 0;
            this.lbServerIP.Text = "Server IP:";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(3, 26);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(29, 13);
            this.lbPort.TabIndex = 1;
            this.lbPort.Text = "Port:";
            // 
            // tbServerIP
            // 
            this.tbServerIP.Location = new System.Drawing.Point(85, -3);
            this.tbServerIP.Name = "tbServerIP";
            this.tbServerIP.Size = new System.Drawing.Size(86, 20);
            this.tbServerIP.TabIndex = 2;
            this.tbServerIP.Text = "127.0.0.1";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(85, 23);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(86, 20);
            this.tbPort.TabIndex = 3;
            this.tbPort.Text = "3000";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbConnectionStatus,
            this.lbConnectionStatusText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbConnectionStatus
            // 
            this.lbConnectionStatus.Name = "lbConnectionStatus";
            this.lbConnectionStatus.Size = new System.Drawing.Size(107, 17);
            this.lbConnectionStatus.Text = "Connection Status:";
            // 
            // lbConnectionStatusText
            // 
            this.lbConnectionStatusText.Name = "lbConnectionStatusText";
            this.lbConnectionStatusText.Size = new System.Drawing.Size(79, 17);
            this.lbConnectionStatusText.Text = "Disconnected";
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(6, 49);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(165, 23);
            this.btConnect.TabIndex = 5;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btLogin);
            this.panel1.Controls.Add(this.lbPassword);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.lbServerIP);
            this.panel1.Controls.Add(this.btConnect);
            this.panel1.Controls.Add(this.tbServerIP);
            this.panel1.Controls.Add(this.tbPort);
            this.panel1.Controls.Add(this.lbPort);
            this.panel1.Location = new System.Drawing.Point(822, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 513);
            this.panel1.TabIndex = 6;
            // 
            // tbDataSending
            // 
            this.tbDataSending.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDataSending.Location = new System.Drawing.Point(12, 25);
            this.tbDataSending.Multiline = true;
            this.tbDataSending.Name = "tbDataSending";
            this.tbDataSending.Size = new System.Drawing.Size(804, 120);
            this.tbDataSending.TabIndex = 7;
            // 
            // lbDateSending
            // 
            this.lbDateSending.AutoSize = true;
            this.lbDateSending.Location = new System.Drawing.Point(12, 9);
            this.lbDateSending.Name = "lbDateSending";
            this.lbDateSending.Size = new System.Drawing.Size(75, 13);
            this.lbDateSending.TabIndex = 6;
            this.lbDateSending.Text = "Data Sending:";
            // 
            // lbDataReceiving
            // 
            this.lbDataReceiving.AutoSize = true;
            this.lbDataReceiving.Location = new System.Drawing.Point(12, 197);
            this.lbDataReceiving.Name = "lbDataReceiving";
            this.lbDataReceiving.Size = new System.Drawing.Size(84, 13);
            this.lbDataReceiving.TabIndex = 8;
            this.lbDataReceiving.Text = "Data Receiving:";
            // 
            // tbDataReceiving
            // 
            this.tbDataReceiving.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDataReceiving.Location = new System.Drawing.Point(12, 213);
            this.tbDataReceiving.Multiline = true;
            this.tbDataReceiving.Name = "tbDataReceiving";
            this.tbDataReceiving.Size = new System.Drawing.Size(804, 120);
            this.tbDataReceiving.TabIndex = 9;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(85, 113);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(86, 20);
            this.tbPassword.TabIndex = 6;
            this.tbPassword.Text = "vocaluxe";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(3, 116);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(56, 13);
            this.lbPassword.TabIndex = 7;
            this.lbPassword.Text = "Password:";
            // 
            // btLogin
            // 
            this.btLogin.Enabled = false;
            this.btLogin.Location = new System.Drawing.Point(6, 139);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(165, 23);
            this.btLogin.TabIndex = 8;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // ClientTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 550);
            this.Controls.Add(this.tbDataReceiving);
            this.Controls.Add(this.lbDataReceiving);
            this.Controls.Add(this.lbDateSending);
            this.Controls.Add(this.tbDataSending);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "ClientTest";
            this.Text = "ClientTest";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbServerIP;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.TextBox tbServerIP;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbConnectionStatus;
        private System.Windows.Forms.ToolStripStatusLabel lbConnectionStatusText;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbDataSending;
        private System.Windows.Forms.Label lbDateSending;
        private System.Windows.Forms.Label lbDataReceiving;
        private System.Windows.Forms.TextBox tbDataReceiving;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbPassword;
    }
}
