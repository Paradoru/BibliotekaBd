namespace BibliotekaBd
{
    partial class WriteOffBookForm
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
            this.writeOffButton = new System.Windows.Forms.Button();
            this.bookstatuslabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // writeOffButton
            // 
            this.writeOffButton.Location = new System.Drawing.Point(98, 153);
            this.writeOffButton.Name = "writeOffButton";
            this.writeOffButton.Size = new System.Drawing.Size(75, 23);
            this.writeOffButton.TabIndex = 0;
            this.writeOffButton.Text = "Проверить";
            this.writeOffButton.UseVisualStyleBackColor = true;
            this.writeOffButton.Click += new System.EventHandler(this.writeOffButton_Click_1);
            // 
            // bookstatuslabel
            // 
            this.bookstatuslabel.AutoSize = true;
            this.bookstatuslabel.Location = new System.Drawing.Point(84, 221);
            this.bookstatuslabel.Name = "bookstatuslabel";
            this.bookstatuslabel.Size = new System.Drawing.Size(0, 13);
            this.bookstatuslabel.TabIndex = 1;
            this.bookstatuslabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите инвентарный номер книги:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(64, 21);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Списание книги";
            // 
            // WriteOffBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bookstatuslabel);
            this.Controls.Add(this.writeOffButton);
            this.Name = "WriteOffBookForm";
            this.Text = "WriteOffBookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button writeOffButton;
        private System.Windows.Forms.Label bookstatuslabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}