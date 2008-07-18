using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AppSettingsLib;

namespace MessageClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOptions options = new FormOptions();
            options.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageSender msgSender = new MessageSender(new AppSettings());
            msgSender.Send(textBoxMessage.Text);
        }
    }
}
