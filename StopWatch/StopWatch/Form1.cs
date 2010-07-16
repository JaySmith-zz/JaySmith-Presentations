using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;
using System.Net.NetworkInformation;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Stopwatch watcher = new Stopwatch();

            watcher.Start();

            InitializeComponent();

            watcher.Stop();

            MessageBox.Show("Total Seconds Elapsed " + watcher.Elapsed.TotalSeconds.ToString());

            // network information

            if (NetworkInterface.GetIsNetworkAvailable())
                MessageBox.Show("The network is UP!");
            else
                MessageBox.Show("The network is DOWN!");

            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();

            MessageBox.Show("There are " + nics.Length.ToString() + " network interfaces available.");
            foreach (NetworkInterface nic in nics)
            {
                MessageBox.Show(nic.Name);
            }
        }
    }
}
