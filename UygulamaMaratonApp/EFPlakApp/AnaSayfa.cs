using MaratonApp.DAL.Context;
using Microsoft.EntityFrameworkCore;
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
    public partial class AnaSayfa : Form
    {
        private MaratonAppDbContext dB;

        public AnaSayfa()
        {
            dB = new MaratonAppDbContext();
            InitializeComponent();
            //foreach (var item in dB.Sanatcilar)
            //{
            //    sanatciAdi_comboBox.Items.Add(item.SanatciAdi);
            //}

            sanatciAdi_comboBox.DataSource = dB.Sanatcilar.ToList();
            durumu_textbox.DataSource = Enum.GetNames(typeof(Status));
            

        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }


        private void liste1_buton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dB.Albumler.ToList();
        }

        private void liste2_buton_Click(object sender, EventArgs e)
        {
            var satisiDevamEtmeyenler = dB.Albumler.Where(a => a.Status == Status.SatisiDevamEtmiyor)
                                                       .Select(a => new { a.AlbumAdi, Sanatci = a.Sanatci.SanatciAdi })
                                                       .ToList();

            dataGridView1.DataSource = satisiDevamEtmeyenler;
        }

        private void liste3_buton_Click(object sender, EventArgs e)
        {
            var satisiDevamEdenler = dB.Albumler.Where(a => a.Status == Status.SatisiDevamEdiyor)
                                                   .Select(a => new { a.AlbumAdi, Sanatci = a.Sanatci.SanatciAdi })
                                                   .ToList();

            dataGridView1.DataSource = satisiDevamEdenler;
        }

        private void liste4_buton_Click(object sender, EventArgs e)
        {
            var sistemeEnSonEklenen10 = dB.Albumler.OrderByDescending(a => a.Id).Take(10)
                                                 .Select(a => new { a.AlbumAdi, Sanatci = a.Sanatci.SanatciAdi })
                                                 .ToList();

            dataGridView1.DataSource = sistemeEnSonEklenen10;
        }

        private void liste5_buton_Click(object sender, EventArgs e)
        {
            var indirimdekiAlbumler = dB.Albumler.Where(a => a.IndirimOrani > 0)
                                                       .OrderByDescending(a => a.IndirimOrani)
                                                       .Select(a => new { a.AlbumAdi, Sanatci = a.Sanatci.SanatciAdi })
                                                       .ToList();

            dataGridView1.DataSource = indirimdekiAlbumler;
        }

        private void cikisYap_buton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
