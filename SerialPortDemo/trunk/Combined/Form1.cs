using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Serial;

namespace Combined
{
    public partial class Form1 : Form
    {
        COM _client;
        COM _device;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _client = new COM("COM1");
            _client.DataReceived += new EventHandler<DataReceivedEventArgs>(_client_DataReceived);

            _device = new COM("COM5");
            _device.DataReceived += new EventHandler<DataReceivedEventArgs>(_device_DataReceived);
        }

        void _client_DataReceived(object sender, DataReceivedEventArgs e)
        {
            DisplayMessage(richTextBoxClient, "<- " + e.Data);
        }

        void _device_DataReceived(object sender, DataReceivedEventArgs e)
        {
            DisplayMessage(richTextBoxDevice, "<- " + e.Data);

            string replyMessage = e.Data;

            if (e.Data.Equals("Hello"))
                replyMessage += " World!";

            DisplayMessage(richTextBoxDevice, "-> " + replyMessage);
            _device.WriteLine(replyMessage);
        }

        private void DisplayMessage(RichTextBox target, string message)
        {
            target.AppendText(message + "\n");
            target.SelectionStart = target.Text.Length;
            target.ScrollToCaret();
            target.Refresh();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            DisplayMessage(richTextBoxClient, "-> " + textBoxMessage.Text);
            _client.WriteLine(textBoxMessage.Text);
        }
    }
}