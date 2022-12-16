using Microsoft.EntityFrameworkCore;
using OnePlusCalorie.DAL.Context;
using OnePlusCalorie.DATA.Entities;
using OnePlusCalorie.UI.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnePlusCalorie.UI.Forms
{
    public partial class KaloriForm : Form
    {
        ProjectContext db;

        List<Besin> besinler;
        List<BesinKategori> besinKategorileri;

        BesinDegeri besinDegeriBilgisi;
        Besin besinBilgisi;
        Kalori kaloriBilgisi;


        public KaloriForm()
        {
            InitializeComponent();
            db = new ProjectContext();



        }

        private void KaloriForm_Load(object sender, EventArgs e)
        {
            btnGuncelle.Hide();
            btnGuncelle.Enabled = false;
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            lbxBesinListesi.DisplayMember = "Ad";

            if (txtAdAra.Text != string.Empty && cmbAramaKriteri.SelectedIndex >= 0)
            {
                if (cmbAramaKriteri.SelectedIndex == 0)
                {
                    lbxBesinListesi.DataSource = db.Besinler.Where(x => EF.Functions.Like(x.Ad, $"{txtAdAra.Text}%")).ToList();
                }
                else if (cmbAramaKriteri.SelectedIndex == 1)
                {
                    lbxBesinListesi.DataSource = db.Besinler.Where(x => EF.Functions.Like(x.Ad, $"%{txtAdAra.Text}%")).ToList();
                }
                else if (cmbAramaKriteri.SelectedIndex == 2)
                {
                    lbxBesinListesi.DataSource = db.Besinler.Where(x => EF.Functions.Like(x.Ad, $"%{txtAdAra.Text}")).ToList();
                }
            }
            else
            {
                MessageBox.Show("Lutfen arama yapmak icin secim yapiniz !!!");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
          
            kaloriBilgisi = new Kalori()
            {
                BesinID = Convert.ToInt32(lblGizliBesinID.Text),
                BesinGrami = Convert.ToInt32(txtBesinAgirligi.Text),
                _Kalori = Convert.ToInt32(txtKaloriDegeri.Text)



            };
            db.Kaloriler.Add(kaloriBilgisi);

            
            db.SaveChanges();
            MessageBox.Show("Besin Kalori Değerleri Basariyla Eklenmistir.");
            lbxBesinListesi.SelectedIndex = -1;
            Metotlar.Temizle(grpBesinArama);
            Metotlar.Temizle(grpKaloriEkleme);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {






        }

        private void lbxBesinListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxBesinListesi.SelectedIndex >= 0)
            {
                StringBuilder builder = new StringBuilder();
                Besin seciliBesin = (Besin)lbxBesinListesi.SelectedItem;
                var besinDetaylari = db.BesinDegerleri.FirstOrDefault(x => x.BesinID == seciliBesin.ID);
                var besinKalorisi = db.Kaloriler.FirstOrDefault(x => x.BesinID == seciliBesin.ID);

                if (besinKalorisi != null)
                {
                    btnEkle.Enabled = false;
                    btnEkle.Hide();
                    btnGuncelle.Enabled = true;
                    btnGuncelle.Show();
                    lblKaloriDegeri.Text = besinKalorisi._Kalori.ToString();
                    lblBesinAgirligiDegeri.Text = besinKalorisi.BesinGrami.ToString();
                }
                else if (besinKalorisi == null)
                {
                    btnGuncelle.Enabled = false;
                    btnGuncelle.Hide();
                    btnEkle.Enabled = true;
                    btnEkle.Show();

                    lblKaloriDegeri.Text = "........";
                    lblBesinAgirligiDegeri.Text = "........";

                }

                builder.AppendLine(seciliBesin.BesinGoster());
                builder.Append(besinDetaylari != null ? besinDetaylari.BesinDegerleriniGoster() : "Besin Degeri Bilgileri Yoktur");
                //builder.Append(besinKalorisi != null ? besinKalorisi.BesinKaloriDegeriGoster() : "\n\rBesinin Kalori Bilgisi Yoktur.");

                lblBesinBilgileri.Text = builder.ToString();
            }

           

            if (lbxBesinListesi.SelectedIndex >= 0)
            {
                Besin seciliBesin = (Besin)lbxBesinListesi.SelectedItem;
                var besinDetaylari = db.BesinDegerleri.FirstOrDefault(x => x.BesinID == seciliBesin.ID);

                lblGizliBesinID.Text = seciliBesin.ID.ToString();




            }
        }




    }

        
    
}
