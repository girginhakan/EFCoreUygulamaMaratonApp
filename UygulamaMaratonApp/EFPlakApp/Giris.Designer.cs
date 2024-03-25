namespace EFPlakApp
{
    partial class Giris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            giris_buton = new Button();
            kayit_buton = new Button();
            sifre_textBox = new TextBox();
            email_textBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(140, 116);
            label1.Name = "label1";
            label1.Size = new Size(413, 38);
            label1.TabIndex = 0;
            label1.Text = "Plak Dükkânı Yönetici Modülü";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(249, 166);
            label2.Name = "label2";
            label2.Size = new Size(141, 31);
            label2.TabIndex = 1;
            label2.Text = "Hoşgeldiniz";
            // 
            // giris_buton
            // 
            giris_buton.Location = new Point(213, 370);
            giris_buton.Margin = new Padding(3, 4, 3, 4);
            giris_buton.Name = "giris_buton";
            giris_buton.Size = new Size(148, 31);
            giris_buton.TabIndex = 11;
            giris_buton.Text = "GİRİŞ";
            giris_buton.UseVisualStyleBackColor = true;
            // 
            // kayit_buton
            // 
            kayit_buton.Location = new Point(398, 370);
            kayit_buton.Margin = new Padding(3, 4, 3, 4);
            kayit_buton.Name = "kayit_buton";
            kayit_buton.Size = new Size(152, 31);
            kayit_buton.TabIndex = 10;
            kayit_buton.Text = "KAYIT OL";
            kayit_buton.UseVisualStyleBackColor = true;
            // 
            // sifre_textBox
            // 
            sifre_textBox.Location = new Point(213, 323);
            sifre_textBox.Margin = new Padding(3, 4, 3, 4);
            sifre_textBox.Name = "sifre_textBox";
            sifre_textBox.Size = new Size(337, 27);
            sifre_textBox.TabIndex = 9;
            // 
            // email_textBox
            // 
            email_textBox.Location = new Point(213, 272);
            email_textBox.Margin = new Padding(3, 4, 3, 4);
            email_textBox.Name = "email_textBox";
            email_textBox.Size = new Size(337, 27);
            email_textBox.TabIndex = 8;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(143, 325);
            label3.Name = "label3";
            label3.Size = new Size(63, 31);
            label3.TabIndex = 7;
            label3.Text = "Sifre:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(143, 274);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 6;
            label4.Text = "E-mail:";
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 516);
            Controls.Add(giris_buton);
            Controls.Add(kayit_buton);
            Controls.Add(sifre_textBox);
            Controls.Add(email_textBox);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Giris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GİRİS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button giris_buton;
        private Button kayit_buton;
        private TextBox sifre_textBox;
        private TextBox email_textBox;
        private Label label3;
        private Label label4;
    }
}
