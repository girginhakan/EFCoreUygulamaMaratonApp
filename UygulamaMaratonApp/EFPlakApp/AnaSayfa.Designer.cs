namespace EFPlakApp
{
    partial class AnaSayfa
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
            label1 = new Label();
            cikisYap_buton = new Button();
            ekle_buton = new Button();
            kullanici_lbl = new Label();
            dataGridView1 = new DataGridView();
            liste1_buton = new Button();
            liste2_buton = new Button();
            liste3_buton = new Button();
            liste4_buton = new Button();
            liste5_buton = new Button();
            guncelle_buton = new Button();
            sil_buton = new Button();
            albümAdi_textBox = new TextBox();
            fiyati_textbox = new TextBox();
            indirim_textbox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            sanatciAdi_comboBox = new ComboBox();
            durumu_textbox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(365, 36);
            label1.Name = "label1";
            label1.Size = new Size(117, 28);
            label1.TabIndex = 18;
            label1.Text = "Hoşgeldiniz";
            // 
            // cikisYap_buton
            // 
            cikisYap_buton.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            cikisYap_buton.Location = new Point(636, 603);
            cikisYap_buton.Name = "cikisYap_buton";
            cikisYap_buton.Size = new Size(116, 62);
            cikisYap_buton.TabIndex = 17;
            cikisYap_buton.Text = "Çıkış Yap";
            cikisYap_buton.UseVisualStyleBackColor = true;
            // 
            // ekle_buton
            // 
            ekle_buton.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            ekle_buton.Location = new Point(209, 603);
            ekle_buton.Name = "ekle_buton";
            ekle_buton.Size = new Size(116, 62);
            ekle_buton.TabIndex = 14;
            ekle_buton.Text = "Albüm Ekle";
            ekle_buton.UseVisualStyleBackColor = true;
            // 
            // kullanici_lbl
            // 
            kullanici_lbl.AutoSize = true;
            kullanici_lbl.BackColor = Color.Transparent;
            kullanici_lbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            kullanici_lbl.Location = new Point(488, 36);
            kullanici_lbl.Name = "kullanici_lbl";
            kullanici_lbl.Size = new Size(91, 28);
            kullanici_lbl.TabIndex = 26;
            kullanici_lbl.Text = "kullanici";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(134, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(679, 295);
            dataGridView1.TabIndex = 27;
            // 
            // liste1_buton
            // 
            liste1_buton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            liste1_buton.Location = new Point(134, 402);
            liste1_buton.Name = "liste1_buton";
            liste1_buton.Size = new Size(113, 38);
            liste1_buton.TabIndex = 28;
            liste1_buton.Text = "Liste1";
            liste1_buton.UseVisualStyleBackColor = true;
            liste1_buton.Click += liste1_buton_Click;
            // 
            // liste2_buton
            // 
            liste2_buton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            liste2_buton.Location = new Point(275, 402);
            liste2_buton.Name = "liste2_buton";
            liste2_buton.Size = new Size(113, 38);
            liste2_buton.TabIndex = 29;
            liste2_buton.Text = "Liste2";
            liste2_buton.UseVisualStyleBackColor = true;
            liste2_buton.Click += liste2_buton_Click;
            // 
            // liste3_buton
            // 
            liste3_buton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            liste3_buton.Location = new Point(417, 402);
            liste3_buton.Name = "liste3_buton";
            liste3_buton.Size = new Size(113, 38);
            liste3_buton.TabIndex = 30;
            liste3_buton.Text = "Liste3";
            liste3_buton.UseVisualStyleBackColor = true;
            liste3_buton.Click += liste3_buton_Click;
            // 
            // liste4_buton
            // 
            liste4_buton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            liste4_buton.Location = new Point(560, 402);
            liste4_buton.Name = "liste4_buton";
            liste4_buton.Size = new Size(113, 38);
            liste4_buton.TabIndex = 31;
            liste4_buton.Text = "Liste4";
            liste4_buton.UseVisualStyleBackColor = true;
            liste4_buton.Click += liste4_buton_Click;
            // 
            // liste5_buton
            // 
            liste5_buton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            liste5_buton.Location = new Point(700, 402);
            liste5_buton.Name = "liste5_buton";
            liste5_buton.Size = new Size(113, 38);
            liste5_buton.TabIndex = 32;
            liste5_buton.Text = "Liste5";
            liste5_buton.UseVisualStyleBackColor = true;
            liste5_buton.Click += liste5_buton_Click;
            // 
            // guncelle_buton
            // 
            guncelle_buton.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            guncelle_buton.Location = new Point(356, 603);
            guncelle_buton.Name = "guncelle_buton";
            guncelle_buton.Size = new Size(116, 62);
            guncelle_buton.TabIndex = 33;
            guncelle_buton.Text = "Albüm Güncelle";
            guncelle_buton.UseVisualStyleBackColor = true;
            // 
            // sil_buton
            // 
            sil_buton.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            sil_buton.Location = new Point(494, 603);
            sil_buton.Name = "sil_buton";
            sil_buton.Size = new Size(116, 62);
            sil_buton.TabIndex = 34;
            sil_buton.Text = "Albüm Sil";
            sil_buton.UseVisualStyleBackColor = true;
            // 
            // albümAdi_textBox
            // 
            albümAdi_textBox.Location = new Point(80, 473);
            albümAdi_textBox.Margin = new Padding(3, 4, 3, 4);
            albümAdi_textBox.Multiline = true;
            albümAdi_textBox.Name = "albümAdi_textBox";
            albümAdi_textBox.PlaceholderText = "Albüm Adi";
            albümAdi_textBox.Size = new Size(166, 34);
            albümAdi_textBox.TabIndex = 35;
            // 
            // fiyati_textbox
            // 
            fiyati_textbox.Location = new Point(257, 473);
            fiyati_textbox.Margin = new Padding(3, 4, 3, 4);
            fiyati_textbox.Multiline = true;
            fiyati_textbox.Name = "fiyati_textbox";
            fiyati_textbox.PlaceholderText = "Fiyati";
            fiyati_textbox.Size = new Size(166, 34);
            fiyati_textbox.TabIndex = 36;
            // 
            // indirim_textbox
            // 
            indirim_textbox.Location = new Point(433, 473);
            indirim_textbox.Margin = new Padding(3, 4, 3, 4);
            indirim_textbox.Multiline = true;
            indirim_textbox.Name = "indirim_textbox";
            indirim_textbox.PlaceholderText = "İndirim Orani";
            indirim_textbox.Size = new Size(166, 34);
            indirim_textbox.TabIndex = 37;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(617, 480);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(786, 457);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 39;
            label2.Text = "Cikis Tarihi:";
            // 
            // sanatciAdi_comboBox
            // 
            sanatciAdi_comboBox.FormattingEnabled = true;
            sanatciAdi_comboBox.Location = new Point(257, 537);
            sanatciAdi_comboBox.Name = "sanatciAdi_comboBox";
            sanatciAdi_comboBox.Size = new Size(166, 28);
            sanatciAdi_comboBox.TabIndex = 40;
            // 
            // durumu_textbox
            // 
            durumu_textbox.FormattingEnabled = true;
            durumu_textbox.Location = new Point(433, 537);
            durumu_textbox.Name = "durumu_textbox";
            durumu_textbox.Size = new Size(166, 28);
            durumu_textbox.TabIndex = 41;
            // 
            // AnaSayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 698);
            Controls.Add(durumu_textbox);
            Controls.Add(sanatciAdi_comboBox);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(indirim_textbox);
            Controls.Add(fiyati_textbox);
            Controls.Add(albümAdi_textBox);
            Controls.Add(sil_buton);
            Controls.Add(guncelle_buton);
            Controls.Add(liste5_buton);
            Controls.Add(liste4_buton);
            Controls.Add(liste3_buton);
            Controls.Add(liste2_buton);
            Controls.Add(liste1_buton);
            Controls.Add(dataGridView1);
            Controls.Add(kullanici_lbl);
            Controls.Add(label1);
            Controls.Add(cikisYap_buton);
            Controls.Add(ekle_buton);
            Name = "AnaSayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnaSayfa";
            Load += AnaSayfa_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button yiyecekEkle_buton;
        private Label vki_label;
        private Label kilo_label;
        private Label boy_label;
        private Label vücut_kitle_label;
        private Label kilonuz_label;
        private Label boyunuz_label;
        private Label label1;
        private Button cikisYap_buton;
        private Button raporlar_buton;
        private Button ekle_buton;
        private Label kullanici_lbl;
        private DataGridView dataGridView1;
        private Button liste1_buton;
        private Button liste2_buton;
        private Button liste3_buton;
        private Button liste4_buton;
        private Button liste5_buton;
        private Button guncelle_buton;
        private Button sil_buton;
        private TextBox albümAdi_textBox;
        private TextBox fiyati_textbox;
        private TextBox indirim_textbox;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private ComboBox sanatciAdi_comboBox;
        private ComboBox durumu_textbox;
    }
}