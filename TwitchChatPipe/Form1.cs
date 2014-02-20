using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Collections;

namespace TwitchChatPipe
{
    public partial class Form1 : Form
    {
        public IrcClient[] ircs;

        public VBox vbox = null;
        public ButtonMaster bm = null;

        public delegate void CommandLogDelegate(string button);

        public Queue commandList = new Queue();
        public Queue prevCommandList = new Queue();

        public long GameStartTime = 0;

        Thread machineThread;


        public Form1()
        {
            InitializeComponent();

            bm = new ButtonMaster(this, typeof(ButtonMaster.SNESKeys));

            try
            {
                GetTimestamp();
            }
            catch (Exception ex)
            {
                SaveData();
                GetTimestamp();
            }
        }

        private void GetTimestamp()
        {
            System.IO.StreamReader file = new System.IO.StreamReader(Application.StartupPath + "\\" + txtGameName.Text + ".txt");
            string line = file.ReadLine();
            file.Close();
            string[] peices = line.Split(',');
            string timestamp = peices[1];
            GameStartTime = Convert.ToInt64(timestamp);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string[] serverList = ircServer.Text.Split(',');

            ircs = new IrcClient[serverList.Length];
            int id=0;
            foreach( string s in serverList )
            {
                if( ircs[id] == null || !ircs[id].Server.Equals(s) )
                    ircs[id] = new IrcClient(s, Convert.ToInt32(ircPort.Text), this);

                ircs[id].Nick = ircUsername.Text;
                ircs[id].AltNick = ircUsername.Text;
                ircs[id].Pass = twitchOauth.Text;
                ircs[id].Connect();
                id++;
            }
            btnJoinChannel.Enabled = true;
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            foreach (IrcClient irc in ircs)
            {
                if (irc.Connected)
                    irc.Disconnect();
            }
            btnConnect.Enabled = true;
            btnJoinChannel.Enabled = false;
            btnDisconnect.Enabled = false;
        }

        private void btnJoinChannel_Click(object sender, EventArgs e)
        {
            if (ircs == null || ircs.Length == 0) return;

            foreach (IrcClient irc in ircs)
            {
                irc.JoinChannel(ircChannel.Text);
            }
        }

        private void btnPipeStart_Click(object sender, EventArgs e)
        {
            vbox = new VBox(txtVirtualMachine.Text, this);

            machineThread = new Thread(vbox.MachineLoop);
            machineThread.Start();

            vbox.isAttached = true;
            btnLockMachine.Enabled = false;
            btnUnlockMachine.Enabled = true;
        }

        private void btnPipeStop_Click(object sender, EventArgs e)
        {
            vbox.isAttached = false;
            btnLockMachine.Enabled = true;
            btnUnlockMachine.Enabled = false;
        }

        public void CommandLog(string cmd)
        {
            cmd = cmd.Replace(";", ": ");
            if (cmdLog.InvokeRequired)
            {
                CommandLogDelegate log = new CommandLogDelegate(CommandLog);
                this.Invoke(log, new object[] { cmd });
            }
            else
            {
                cmdLog.AppendText(cmd + "\n");
                cmdLog.Select(cmdLog.Text.Length - 1, 0);
                cmdLog.ScrollToCaret();
            }

        }

        private void btnSaveTime_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void saveTimer_Tick(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(Application.StartupPath + "\\"+txtGameName.Text+".txt",true))
            {
                long x = DateTime.UtcNow.Ticks;
                string line = txtController.Text + "," + x + ",";
                foreach (var pair in bm.buttonHistory)
                {
                    line += pair.Key + ":" + pair.Value + ",";
                }
                line += "endline";
                file.WriteLine(line);
            }
        }

        private void localTimeTimer_Tick(object sender, EventArgs e)
        {
            lblLocalTime.Text = "Local Time: " + DateTime.Now.ToString("hh:mm:ss tt");
            
            long x = DateTime.UtcNow.Ticks;

            long iTimestamp = (x - GameStartTime) / 10000000;
            long days = (long)Math.Floor((double)iTimestamp/(double)86400);
            long hours = (long)Math.Floor(((double)iTimestamp-(double)days*(double)86400)/(double)3600);
            long minutes = (iTimestamp - (days * 86400 + hours * 3600)) / 60;
            long seconds = iTimestamp % 60;

            lblElapsedTime.Text = days + "d " + hours + "h " + minutes + "m " + seconds + "s";

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if( machineThread != null )
                machineThread.Abort();

            if (ircs == null || ircs.Length == 0) return;

            foreach (IrcClient irc in ircs)
            {
                irc.Disconnect();
            }
        }
    }
}
