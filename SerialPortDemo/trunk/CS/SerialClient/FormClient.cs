using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Serial;

namespace SerialClient
{
    public partial class FormClient : Form
    {
        private COM _com;

        public FormClient()
        {
            InitializeComponent();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            _com = new COM("COM1");

            _com.DataReceived += new EventHandler<DataReceivedEventArgs>(_com_DataReceived);
        }

        void _com_DataReceived(object sender, DataReceivedEventArgs e)
        {
            DisplayMessage("<- " + e.Data);
        } 

        private void DisplayMessage(string message)
        {
            richTextBoxReceive.AppendText(message + "\n");
            richTextBoxReceive.SelectionStart = richTextBoxReceive.Text.Length;
            richTextBoxReceive.ScrollToCaret();
            richTextBoxReceive.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayMessage("-> " + textBoxMessage.Text);
            _com.WriteLine(textBoxMessage.Text);
        }

        private void FormClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.SerialClient_Location = this.Location;
            Properties.Settings.Default.Save();
        }
    }
}