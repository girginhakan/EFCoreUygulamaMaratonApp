using MaratonApp.DAL.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFPlakApp
{
    public partial class KayitEkrani : Form
    {

        MaratonAppDbContext MaratonAppDbContext = new MaratonAppDbContext();

        public KayitEkrani()
        {
            InitializeComponent();
        }



        private void kayit_buton_Click(object sender, EventArgs e)
        {
           

            if (PasswordControl())
            {
                Kullanici kullanici = new Kullanici();
                kullanici.Adi = ad_textBox.Text;
                kullanici.Soyadi = soyAd_textbox.Text;
                kullanici.KullaniciAdi = kullaniciAd_textbox.Text;
                kullanici.Sifre = sifre_textbox.Text;

                
                MaratonAppDbContext.Kullanicilar.Add(kullanici);
                MaratonAppDbContext.SaveChanges();

                MessageBox.Show("Kullanıcı başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                ad_textBox.Text = "";
                soyAd_textbox.Text = "";
                kullaniciAd_textbox.Text = "";
                sifre_textbox.Text = "";
                sifreTekrari_textbox.Text = "";
            }
            else
            {
                MessageBox.Show("Sifre kontrolünüz basarili olamadi, kayit islemi iptal edilmistir.");
                return;
            }


        }


        private bool PasswordControl()
        {
            string psswrd =sifre_textbox.Text;

            if (psswrd != null && psswrd.Length >= 8)
            {
                int uppercaseCount = psswrd.Count(char.IsUpper);
                int lowercaseCount = psswrd.Count(char.IsLower);
                int specialCharacterCount = Regex.Matches(psswrd, @"[!:+*]").Count;

                if (uppercaseCount < 2)
                {
                    MessageBox.Show("En az 2 büyük harf içermelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (lowercaseCount < 3)
                {
                    MessageBox.Show("En az üç küçük harf içermelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (specialCharacterCount < 2)
                {
                    MessageBox.Show("En az iki özel karakter (!:+*) içermelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (sifre_textbox.Text != sifreTekrari_textbox.Text)
                {
                    MessageBox.Show("Şifreler birbiri ile uyuşmuyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }
            else
            {
                MessageBox.Show("Sifre en az 8 karakter içermelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }




    }
}
