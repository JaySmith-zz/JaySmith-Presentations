using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;

namespace Serial
{
    public class COM
    {
        private string _portName;
        private SerialPort _port;
        private string _inputBuffer;

        public event EventHandler<DataReceivedEventArgs> DataReceived;

        public COM(string portName)
        {
            _portName = portName;

            _port = new SerialPort(_portName, 9600, Parity.None, 8, StopBits.One);
            _port.NewLine = "!%";
            _port.DataReceived += new SerialDataReceivedEventHandler(_port_DataReceived);
            _port.Open();
        }

        void _port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (_port.IsOpen)
            {
                _inputBuffer = _port.ReadTo(_port.NewLine);
                if (_port.ReadExisting().Length == 0)
                {
                    Invoker.Invoke(DataReceived, this, new DataReceivedEventArgs(_inputBuffer));
                    _inputBuffer = String.Empty;
                }
            }
        }

        public void Write(string buffer)
        {
            try
            {
                _port.Write(buffer);
            }
            catch
            {
                throw;
            }
        }

        public void WriteLine(string buffer)
        {
            try
            {
                _port.WriteLine(buffer);
            }
            catch
            {
                throw;
            }
        }
    }

    
}


