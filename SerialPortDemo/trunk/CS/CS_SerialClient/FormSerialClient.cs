using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialClient
{
    public partial class FormSerialClient : Form
    {
        private string _inputBuffer = String.Empty;

        public FormSerialClient()
        {
            InitializeComponent();
        }

        private void FormSerialClient_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            port.PortName = "COM1";
            port.BaudRate = 9600;
            port.Parity = Parity.None;
            port.DataBits = 8;
            port.StopBits = StopBits.One;
            port.NewLine = "!%";

            port.Open();

            if (port.IsOpen)
                richTextBoxReceive.AppendText("Serial Port is open and listening on " + port.PortName + "\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxMessage.Text != String.Empty)
                port.WriteLine(textBoxMessage.Text);
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (port.IsOpen)
            {
                _inputBuffer = port.ReadTo(port.NewLine);
                if (port.ReadExisting().Length == 0)
                {
                    richTextBoxReceive.AppendText(_inputBuffer + "\n");
                    _inputBuffer = String.Empty;
                }
            }
        }

        private void FormSerialClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.SerialClient_Location = this.Location;
            Properties.Settings.Default.Save();
        }
    }
}