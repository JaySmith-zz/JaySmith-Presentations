namespace SerialDevice
{
    partial class FormSerialDevice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.port = new System.IO.Ports.SerialPort(this.components);
            this.richTextBoxReceive = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // port
            // 
            this.port.PortName = "COM5";
            this.port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            this.port.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort1_ErrorReceived);
            // 
            // richTextBoxReceive
            // 
            this.richTextBoxReceive.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxReceive.Name = "richTextBoxReceive";
            this.richTextBoxReceive.Size = new System.Drawing.Size(268, 242);
            this.richTextBoxReceive.TabIndex = 0;
            this.richTextBoxReceive.Text = "";
            // 
            // FormSerialDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.richTextBoxReceive);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::SerialDevice.Properties.Settings.Default, "SerialDevice_Location", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::SerialDevice.Properties.Settings.Default.SerialDevice_Location;
            this.Name = "FormSerialDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SerialDevice - C#";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSerialDevice_FormClosing);
            this.Load += new System.EventHandler(this.FormSerialDevice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort port;
        private System.Windows.Forms.RichTextBox richTextBoxReceive;
    }
}

