using System;
using System.Windows.Forms;

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
            var options = new FormOptions();
            options.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}