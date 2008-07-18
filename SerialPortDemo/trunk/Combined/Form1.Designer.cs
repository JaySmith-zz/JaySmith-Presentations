namespace Combined
{
    partial class Form1
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
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.richTextBoxClient = new System.Windows.Forms.RichTextBox();
            this.richTextBoxDevice = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(12, 11);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(187, 20);
            this.textBoxMessage.TabIndex = 8;
            this.textBoxMessage.Text = "Hello World!";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(205, 8);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 7;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // richTextBoxClient
            // 
            this.richTextBoxClient.Location = new System.Drawing.Point(12, 37);
            this.richTextBoxClient.Name = "richTextBoxClient";
            this.richTextBoxClient.Size = new System.Drawing.Size(268, 216);
            this.richTextBoxClient.TabIndex = 6;
            this.richTextBoxClient.Text = "";
            // 
            // richTextBoxDevice
            // 
            this.richTextBoxDevice.Location = new System.Drawing.Point(12, 259);
            this.richTextBoxDevice.Name = "richTextBoxDevice";
            this.richTextBoxDevice.Size = new System.Drawing.Size(268, 242);
            this.richTextBoxDevice.TabIndex = 9;
            this.richTextBoxDevice.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 516);
            this.Controls.Add(this.richTextBoxDevice);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.richTextBoxClient);
            this.Name = "Form1";
            this.Text = "Combined Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.RichTextBox richTextBoxClient;
        private System.Windows.Forms.RichTextBox richTextBoxDevice;
    }
}

