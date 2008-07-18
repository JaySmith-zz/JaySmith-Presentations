using System;
using System.Collections.Generic;
using System.Text;

namespace Serial
{
    public class DataReceivedEventArgs : EventArgs
    {

        public DataReceivedEventArgs(string data)
        {
            _data = data;
        }

        private string _data;
        public string Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
            }
        }
    }
}
