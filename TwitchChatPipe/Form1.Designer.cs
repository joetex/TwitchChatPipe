namespace TwitchChatPipe
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
            this.components = new System.ComponentModel.Container();
            this.cmdLog = new System.Windows.Forms.RichTextBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.ircChannel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.twitchOauth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ircUsername = new System.Windows.Forms.TextBox();
            this.ircServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.ircPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.btnJoinChannel = new System.Windows.Forms.Button();
            this.txtVirtualMachine = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLockMachine = new System.Windows.Forms.Button();
            this.btnUnlockMachine = new System.Windows.Forms.Button();
            this.lblElapsedTime = new System.Windows.Forms.Label();
            this.btnSaveTime = new System.Windows.Forms.Button();
            this.txtGameName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtController = new System.Windows.Forms.TextBox();
            this.saveTimer = new System.Windows.Forms.Timer(this.components);
            this.lblLocalTime = new System.Windows.Forms.Label();
            this.localTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cmdLog
            // 
            this.cmdLog.BackColor = System.Drawing.Color.Black;
            this.cmdLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cmdLog.Font = new System.Drawing.Font("Perfect DOS VGA 437", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdLog.Location = new System.Drawing.Point(275, 66);
            this.cmdLog.MaxLength = 5000;
            this.cmdLog.Name = "cmdLog";
            this.cmdLog.ReadOnly = true;
            this.cmdLog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmdLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.cmdLog.Size = new System.Drawing.Size(198, 418);
            this.cmdLog.TabIndex = 21;
            this.cmdLog.Text = "";
            this.cmdLog.WordWrap = false;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.ForeColor = System.Drawing.Color.Black;
            this.btnDisconnect.Location = new System.Drawing.Point(154, 32);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(84, 19);
            this.btnDisconnect.TabIndex = 20;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // ircChannel
            // 
            this.ircChannel.Location = new System.Drawing.Point(48, 88);
            this.ircChannel.Name = "ircChannel";
            this.ircChannel.Size = new System.Drawing.Size(100, 20);
            this.ircChannel.TabIndex = 19;
            this.ircChannel.Text = "#twitchplayspokemon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Channel:";
            // 
            // twitchOauth
            // 
            this.twitchOauth.Location = new System.Drawing.Point(48, 62);
            this.twitchOauth.Name = "twitchOauth";
            this.twitchOauth.Size = new System.Drawing.Size(100, 20);
            this.twitchOauth.TabIndex = 17;
            this.twitchOauth.Text = "oauth:csgeevkee25sftywmtgsfgco1pmscq8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Pass:";
            // 
            // ircUsername
            // 
            this.ircUsername.Location = new System.Drawing.Point(48, 36);
            this.ircUsername.Name = "ircUsername";
            this.ircUsername.Size = new System.Drawing.Size(100, 20);
            this.ircUsername.TabIndex = 15;
            this.ircUsername.Text = "OneGameMillionPlayers";
            // 
            // ircServer
            // 
            this.ircServer.Location = new System.Drawing.Point(48, 9);
            this.ircServer.Name = "ircServer";
            this.ircServer.Size = new System.Drawing.Size(100, 20);
            this.ircServer.TabIndex = 14;
            this.ircServer.Text = "199.9.252.26,irc.twitch.tv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "User:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Server:";
            // 
            // btnConnect
            // 
            this.btnConnect.ForeColor = System.Drawing.Color.Black;
            this.btnConnect.Location = new System.Drawing.Point(154, 54);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(84, 27);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // ircPort
            // 
            this.ircPort.Location = new System.Drawing.Point(183, 8);
            this.ircPort.Name = "ircPort";
            this.ircPort.Size = new System.Drawing.Size(55, 20);
            this.ircPort.TabIndex = 23;
            this.ircPort.Text = "6667";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(157, 11);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 22;
            this.lblPort.Text = "Port:";
            // 
            // btnJoinChannel
            // 
            this.btnJoinChannel.Enabled = false;
            this.btnJoinChannel.ForeColor = System.Drawing.Color.Black;
            this.btnJoinChannel.Location = new System.Drawing.Point(154, 87);
            this.btnJoinChannel.Name = "btnJoinChannel";
            this.btnJoinChannel.Size = new System.Drawing.Size(84, 20);
            this.btnJoinChannel.TabIndex = 24;
            this.btnJoinChannel.Text = "Join Channel";
            this.btnJoinChannel.UseVisualStyleBackColor = true;
            this.btnJoinChannel.Click += new System.EventHandler(this.btnJoinChannel_Click);
            // 
            // txtVirtualMachine
            // 
            this.txtVirtualMachine.Location = new System.Drawing.Point(13, 137);
            this.txtVirtualMachine.Name = "txtVirtualMachine";
            this.txtVirtualMachine.Size = new System.Drawing.Size(100, 20);
            this.txtVirtualMachine.TabIndex = 26;
            this.txtVirtualMachine.Text = "WinXP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Virtual Machine Name:";
            // 
            // btnLockMachine
            // 
            this.btnLockMachine.ForeColor = System.Drawing.Color.Black;
            this.btnLockMachine.Location = new System.Drawing.Point(13, 160);
            this.btnLockMachine.Name = "btnLockMachine";
            this.btnLockMachine.Size = new System.Drawing.Size(52, 27);
            this.btnLockMachine.TabIndex = 27;
            this.btnLockMachine.Text = "Lock";
            this.btnLockMachine.UseVisualStyleBackColor = true;
            this.btnLockMachine.Click += new System.EventHandler(this.btnPipeStart_Click);
            // 
            // btnUnlockMachine
            // 
            this.btnUnlockMachine.Enabled = false;
            this.btnUnlockMachine.ForeColor = System.Drawing.Color.Black;
            this.btnUnlockMachine.Location = new System.Drawing.Point(71, 160);
            this.btnUnlockMachine.Name = "btnUnlockMachine";
            this.btnUnlockMachine.Size = new System.Drawing.Size(52, 27);
            this.btnUnlockMachine.TabIndex = 28;
            this.btnUnlockMachine.Text = "Unlock";
            this.btnUnlockMachine.UseVisualStyleBackColor = true;
            this.btnUnlockMachine.Click += new System.EventHandler(this.btnPipeStop_Click);
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.AutoSize = true;
            this.lblElapsedTime.Font = new System.Drawing.Font("Perfect DOS VGA 437", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElapsedTime.Location = new System.Drawing.Point(284, 13);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(189, 30);
            this.lblElapsedTime.TabIndex = 29;
            this.lblElapsedTime.Text = "0d 0h 0m 0s";
            // 
            // btnSaveTime
            // 
            this.btnSaveTime.ForeColor = System.Drawing.Color.Black;
            this.btnSaveTime.Location = new System.Drawing.Point(48, 263);
            this.btnSaveTime.Name = "btnSaveTime";
            this.btnSaveTime.Size = new System.Drawing.Size(91, 23);
            this.btnSaveTime.TabIndex = 31;
            this.btnSaveTime.Text = "Save";
            this.btnSaveTime.UseVisualStyleBackColor = true;
            this.btnSaveTime.Click += new System.EventHandler(this.btnSaveTime_Click);
            // 
            // txtGameName
            // 
            this.txtGameName.Location = new System.Drawing.Point(57, 202);
            this.txtGameName.Name = "txtGameName";
            this.txtGameName.Size = new System.Drawing.Size(100, 20);
            this.txtGameName.TabIndex = 33;
            this.txtGameName.Text = "FF Mystic Quest";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Game:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Controller:";
            // 
            // txtController
            // 
            this.txtController.Location = new System.Drawing.Point(57, 228);
            this.txtController.Name = "txtController";
            this.txtController.Size = new System.Drawing.Size(100, 20);
            this.txtController.TabIndex = 35;
            this.txtController.Text = "SNES";
            // 
            // saveTimer
            // 
            this.saveTimer.Enabled = true;
            this.saveTimer.Interval = 30000;
            this.saveTimer.Tick += new System.EventHandler(this.saveTimer_Tick);
            // 
            // lblLocalTime
            // 
            this.lblLocalTime.AutoSize = true;
            this.lblLocalTime.Location = new System.Drawing.Point(328, 47);
            this.lblLocalTime.Name = "lblLocalTime";
            this.lblLocalTime.Size = new System.Drawing.Size(65, 13);
            this.lblLocalTime.TabIndex = 37;
            this.lblLocalTime.Text = "Local Time: ";
            // 
            // localTimeTimer
            // 
            this.localTimeTimer.Enabled = true;
            this.localTimeTimer.Tick += new System.EventHandler(this.localTimeTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(497, 489);
            this.Controls.Add(this.lblLocalTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtController);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGameName);
            this.Controls.Add(this.btnSaveTime);
            this.Controls.Add(this.lblElapsedTime);
            this.Controls.Add(this.btnUnlockMachine);
            this.Controls.Add(this.btnLockMachine);
            this.Controls.Add(this.txtVirtualMachine);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnJoinChannel);
            this.Controls.Add(this.ircPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.cmdLog);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.ircChannel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.twitchOauth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ircUsername);
            this.Controls.Add(this.ircServer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnect);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox cmdLog;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox ircChannel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox twitchOauth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ircUsername;
        private System.Windows.Forms.TextBox ircServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox ircPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Button btnJoinChannel;
        private System.Windows.Forms.TextBox txtVirtualMachine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLockMachine;
        private System.Windows.Forms.Button btnUnlockMachine;
        private System.Windows.Forms.Label lblElapsedTime;
        private System.Windows.Forms.Button btnSaveTime;
        private System.Windows.Forms.TextBox txtGameName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtController;
        private System.Windows.Forms.Timer saveTimer;
        private System.Windows.Forms.Label lblLocalTime;
        private System.Windows.Forms.Timer localTimeTimer;
    }
}

