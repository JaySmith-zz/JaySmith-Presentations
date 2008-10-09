namespace PrizePickerUoA
{
    partial class FormMain
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
            this.checkedListBoxPrizes = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxWinners = new System.Windows.Forms.CheckedListBox();
            this.buttonPickWinner = new System.Windows.Forms.Button();
            this.buttonPickPrize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBoxPrizes
            // 
            this.checkedListBoxPrizes.FormattingEnabled = true;
            this.checkedListBoxPrizes.Location = new System.Drawing.Point(12, 12);
            this.checkedListBoxPrizes.Name = "checkedListBoxPrizes";
            this.checkedListBoxPrizes.Size = new System.Drawing.Size(268, 259);
            this.checkedListBoxPrizes.TabIndex = 0;
            // 
            // checkedListBoxWinners
            // 
            this.checkedListBoxWinners.FormattingEnabled = true;
            this.checkedListBoxWinners.Location = new System.Drawing.Point(286, 12);
            this.checkedListBoxWinners.Name = "checkedListBoxWinners";
            this.checkedListBoxWinners.Size = new System.Drawing.Size(276, 259);
            this.checkedListBoxWinners.TabIndex = 1;
            // 
            // buttonPickWinner
            // 
            this.buttonPickWinner.Location = new System.Drawing.Point(487, 277);
            this.buttonPickWinner.Name = "buttonPickWinner";
            this.buttonPickWinner.Size = new System.Drawing.Size(75, 23);
            this.buttonPickWinner.TabIndex = 2;
            this.buttonPickWinner.Text = "Pick Winner";
            this.buttonPickWinner.UseVisualStyleBackColor = true;
            // 
            // buttonPickPrize
            // 
            this.buttonPickPrize.Location = new System.Drawing.Point(205, 277);
            this.buttonPickPrize.Name = "buttonPickPrize";
            this.buttonPickPrize.Size = new System.Drawing.Size(75, 23);
            this.buttonPickPrize.TabIndex = 3;
            this.buttonPickPrize.Text = "Pick Prize";
            this.buttonPickPrize.UseVisualStyleBackColor = true;
            this.buttonPickPrize.Click += new System.EventHandler(this.buttonPickPrize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 478);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPickPrize);
            this.Controls.Add(this.buttonPickWinner);
            this.Controls.Add(this.checkedListBoxWinners);
            this.Controls.Add(this.checkedListBoxPrizes);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxPrizes;
        private System.Windows.Forms.CheckedListBox checkedListBoxWinners;
        private System.Windows.Forms.Button buttonPickWinner;
        private System.Windows.Forms.Button buttonPickPrize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

