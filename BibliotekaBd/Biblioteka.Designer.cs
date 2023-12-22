namespace BibliotekaBd
{
    partial class Biblioteka
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button_zal = new System.Windows.Forms.Button();
            this.button_journalchitatel = new System.Windows.Forms.Button();
            this.button_kniga = new System.Windows.Forms.Button();
            this.button_oblast_znaniy = new System.Windows.Forms.Button();
            this.button_chitatel = new System.Windows.Forms.Button();
            this.button_eczemlyar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(71, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "База данных \"Библиотека\"";
            // 
            // button_zal
            // 
            this.button_zal.Location = new System.Drawing.Point(142, 139);
            this.button_zal.Name = "button_zal";
            this.button_zal.Size = new System.Drawing.Size(115, 23);
            this.button_zal.TabIndex = 3;
            this.button_zal.Text = "Зал";
            this.button_zal.UseVisualStyleBackColor = true;
            this.button_zal.Click += new System.EventHandler(this.button_zal_Click);
            // 
            // button_journalchitatel
            // 
            this.button_journalchitatel.Location = new System.Drawing.Point(142, 96);
            this.button_journalchitatel.Name = "button_journalchitatel";
            this.button_journalchitatel.Size = new System.Drawing.Size(115, 23);
            this.button_journalchitatel.TabIndex = 4;
            this.button_journalchitatel.Text = "Журнал читателя";
            this.button_journalchitatel.UseVisualStyleBackColor = true;
            this.button_journalchitatel.Click += new System.EventHandler(this.button_journalchitatel_Click);
            // 
            // button_kniga
            // 
            this.button_kniga.Location = new System.Drawing.Point(142, 188);
            this.button_kniga.Name = "button_kniga";
            this.button_kniga.Size = new System.Drawing.Size(115, 23);
            this.button_kniga.TabIndex = 5;
            this.button_kniga.Text = "Книга";
            this.button_kniga.UseVisualStyleBackColor = true;
            this.button_kniga.Click += new System.EventHandler(this.button_kniga_Click);
            // 
            // button_oblast_znaniy
            // 
            this.button_oblast_znaniy.Location = new System.Drawing.Point(142, 235);
            this.button_oblast_znaniy.Name = "button_oblast_znaniy";
            this.button_oblast_znaniy.Size = new System.Drawing.Size(115, 23);
            this.button_oblast_znaniy.TabIndex = 6;
            this.button_oblast_znaniy.Text = "Область знаний";
            this.button_oblast_znaniy.UseVisualStyleBackColor = true;
            this.button_oblast_znaniy.Click += new System.EventHandler(this.button_oblast_znaniy_Click);
            // 
            // button_chitatel
            // 
            this.button_chitatel.Location = new System.Drawing.Point(142, 288);
            this.button_chitatel.Name = "button_chitatel";
            this.button_chitatel.Size = new System.Drawing.Size(115, 23);
            this.button_chitatel.TabIndex = 7;
            this.button_chitatel.Text = "Читатель";
            this.button_chitatel.UseVisualStyleBackColor = true;
            this.button_chitatel.Click += new System.EventHandler(this.button_chitatel_Click);
            // 
            // button_eczemlyar
            // 
            this.button_eczemlyar.Location = new System.Drawing.Point(142, 335);
            this.button_eczemlyar.Name = "button_eczemlyar";
            this.button_eczemlyar.Size = new System.Drawing.Size(115, 23);
            this.button_eczemlyar.TabIndex = 8;
            this.button_eczemlyar.Text = "Экземпляр книги";
            this.button_eczemlyar.UseVisualStyleBackColor = true;
            this.button_eczemlyar.Click += new System.EventHandler(this.button_eczemlyar_Click);
            // 
            // Biblioteka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.button_eczemlyar);
            this.Controls.Add(this.button_chitatel);
            this.Controls.Add(this.button_oblast_znaniy);
            this.Controls.Add(this.button_kniga);
            this.Controls.Add(this.button_journalchitatel);
            this.Controls.Add(this.button_zal);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Biblioteka";
            this.Text = "Biblioteka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_zal;
        private System.Windows.Forms.Button button_journalchitatel;
        private System.Windows.Forms.Button button_kniga;
        private System.Windows.Forms.Button button_oblast_znaniy;
        private System.Windows.Forms.Button button_chitatel;
        private System.Windows.Forms.Button button_eczemlyar;
    }
}

