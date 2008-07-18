namespace SerialClient
{
    partial class FormClient
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
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBoxReceive = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(12, 12);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(187, 20);
            this.textBoxMessage.TabIndex = 5;
            this.textBoxMessage.Text = "Hello World!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBoxReceive
            // 
            this.richTextBoxReceive.Location = new System.Drawing.Point(12, 38);
            this.richTextBoxReceive.Name = "richTextBoxReceive";
            this.richTextBoxReceive.Size = new System.Drawing.Size(268, 216);
            this.richTextBoxReceive.TabIndex = 3;
            this.richTextBoxReceive.Text = "";
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBoxReceive);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::SerialClient.Properties.Settings.Default, "SerialClient_Location", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::SerialClient.Properties.Settings.Default.SerialClient_Location;
            this.Name = "FormClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Serial Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClient_FormClosing);
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBoxReceive;
    }
}

