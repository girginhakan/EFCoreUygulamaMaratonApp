using MaratonApp.DAL.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFPlakApp
{
    public partial class GirisFormu : Form
    {
        MaratonAppDbContext db = new MaratonAppDbContext();
        public GirisFormu()
        {
            InitializeComponent();
        }

        private void giris_buton_Click(object sender, EventArgs e)
        {
            var kullanici = db.Kullanicilar.FirstOrDefault(k => k.KullaniciAdi == email_textBox.Text);
            var kullaniciSifre = db.Kullanicilar.FirstOrDefault(k => k.Sifre == Program.Sha256Hash(sifre_textBox.Text));

            if (kullanici != null && kullaniciSifre != null)
            {
                AnaSayfa anaSayfa = new AnaSayfa();
                anaSayfa.Show();
                this.Hide();
                MessageBox.Show("Hoşgeldiniz.");
            }
        }

        private void kayit_buton_Click(object sender, EventArgs e)
        {
            KayitEkrani kayitEkrani = new KayitEkrani();
            kayitEkrani.Show();
            this.Hide();
        }
    }
}
