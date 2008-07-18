using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Serial;

namespace SerialDevice
{
    public partial class FormDevice : Form
    {
        private COM _com;

        public FormDevice()
        {
            InitializeComponent();
        }

        private void FormDevice_Load(object sender, EventArgs e)
        {
            _com = new COM("COM5");

            _com.DataReceived += new EventHandler<DataReceivedEventArgs>(_com_DataReceived);
        }

        void _com_DataReceived(object sender, DataReceivedEventArgs e)
        {
            DisplayMessage("<- " + e.Data);

            string replyMessage = e.Data;

            if (e.Data.Equals("Hello"))
                replyMessage += " World!";

            DisplayMessage("-> " + replyMessage);
            _com.WriteLine(replyMessage);
        }

        private void DisplayMessage(string message)
        {
            richTextBoxReceive.AppendText(message + "\n");
            richTextBoxReceive.SelectionStart = richTextBoxReceive.Text.Length;
            richTextBoxReceive.ScrollToCaret();
            richTextBoxReceive.Refresh();
        }

        private void FormDevice_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.SerialDevice_Location = this.Location;
            Properties.Settings.Default.Save();
        }
    }
}