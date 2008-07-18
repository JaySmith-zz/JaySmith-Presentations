using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialDevice
{
    public partial class FormSerialDevice : Form
    {
        private string _inputBuffer = String.Empty;
        private int _messageCount = 0;

        public FormSerialDevice()
        {
            InitializeComponent();
        }

        private void FormSerialDevice_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            port.PortName = "COM5";
            port.BaudRate = 9600;
            port.Parity = Parity.None;
            port.DataBits = 8;
            port.StopBits = StopBits.One;
            port.NewLine = "!%";

            port.Open();

            if (port.IsOpen)
                richTextBoxReceive.AppendText("Serial Port is open and listening on " + port.PortName + "\n");
        }

        private void FormSerialDevice_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.SerialDevice_Location = this.Location;
            Properties.Settings.Default.Save();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (port.IsOpen)
            {
                _inputBuffer = port.ReadTo(port.NewLine);
                if (port.ReadExisting().Length == 0)
                {
                    _messageCount++;
                    richTextBoxReceive.AppendText(_messageCount + ": " + _inputBuffer + "\n");
                    port.WriteLine(_messageCount + ": " + _inputBuffer);
                    _inputBuffer = String.Empty;
                }
            }
        }

        private void serialPort1_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
        {
            MessageBox.Show("Error: {0}", e.ToString());
        }
    }
}