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
    public partial class BesinForm : Form
    {

        ProjectContext db;
        

        List<Besin> besinler;
        List<BesinKategori> besinKategorileri;

        BesinDegeri besinDegeriBilgisi;
        Besin besinBilgisi;

        public BesinForm()
        {
            InitializeComponent();
            db = new ProjectContext();
            Listele();
        }

        private void Listele()
        {
            //var tumKategoriler = db.BesinKategorileri.OrderByDescending(b => b.ID).ToList();

            //if (cmbKategori.Items.Count > 0)
            //    cmbKategori.Items.Clear();

            //tumKategoriler.ForEach(b => cmbKategori.Items.Add(b.ID + "-" + b.KategoriAdi));

            //if(tumKategoriler.Count > 0)
            //{
            //    cmbKategori.SelectedIndex = 0;
            //    cmbKategori.Enabled = true;
            //}
            //else
            //{
            //    cmbKategori.Enabled = false;
            //}

            foreach (var item in db.BesinKategorileri.ToList())
            {
                cmbKategori.Items.Add(item.KategoriAdi);
            }

            cmbKategori.SelectedIndex = -1;


            foreach (var item in db.BesinKategorileri.ToList())
            {
               cmbDegerlerBesinKategori.Items.Add(item.KategoriAdi);
            }

            cmbDegerlerBesinKategori.SelectedIndex = -1;

        }

        private void BesinForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (Metotlar.BosAlanVarMi(grpBesinKayit))
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız!");
            }
            else
            {
                Besin yeniBesin = new Besin()
                {
                    Ad = txtBesinAd.Text,
                    KategoriID = cmbKategori.SelectedIndex + 1


                };
                db.Besinler.Add(yeniBesin);
                db.SaveChanges();

                Metotlar.Temizle(grpBesinKayit);
            }

        }
        private void btnAra_Click_1(object sender, EventArgs e)
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
        

        Besin guncellenecekBesin;
        BesinDegeri guncellenecekBesinDegeri;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblGizliBesinID.Text);
            guncellenecekBesin = db.Besinler.FirstOrDefault(x => x.ID == id);
            guncellenecekBesin.Ad = txtDegerlerBesinAdi.Text;
            guncellenecekBesin.KategoriID = cmbDegerlerBesinKategori.SelectedIndex + 1;

            guncellenecekBesinDegeri = db.BesinDegerleri.FirstOrDefault(x => x.BesinID == id);
            guncellenecekBesinDegeri.Gram = Convert.ToInt32(txtAgirlik.Text);
            guncellenecekBesinDegeri.Karbonhidrat = Convert.ToInt32(txtKarbonhidrat.Text);
            guncellenecekBesinDegeri.Yag = Convert.ToInt32(txtYag.Text);
            guncellenecekBesinDegeri.Protein = Convert.ToInt32(txtProtein.Text);
            guncellenecekBesinDegeri.Lif = Convert.ToInt32(txtLif.Text);
            guncellenecekBesinDegeri.Kolestrol = Convert.ToInt32(txtKolestrol.Text);
            guncellenecekBesinDegeri.Sodyum = Convert.ToInt32(txtSodyum.Text);
            guncellenecekBesinDegeri.Potasyum = Convert.ToInt32(txtPotasyum.Text);
            guncellenecekBesinDegeri.Kalsiyum = Convert.ToInt32(txtKalsiyum.Text);

            db.SaveChanges();



        }

        private void lbxBesinListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxBesinListesi.SelectedIndex >= 0)
            {
                StringBuilder builder = new StringBuilder();
                Besin seciliBesin = (Besin)lbxBesinListesi.SelectedItem;
                var besinDetaylari = db.BesinDegerleri.FirstOrDefault(x => x.BesinID == seciliBesin.ID);

                builder.AppendLine(seciliBesin.BesinGoster());
                builder.Append(besinDetaylari != null ? besinDetaylari.BesinDegerleriniGoster() : "Besin Degeri Bilgileri Yoktur");
                
                lblBesinBilgileri.Text = builder.ToString();
            }

            if(lbxBesinListesi.SelectedIndex >= 0)
            {
                Besin seciliBesin = (Besin)lbxBesinListesi.SelectedItem;
                txtDegerlerBesinAdi.Text = seciliBesin.Ad;
                cmbDegerlerBesinKategori.SelectedIndex = seciliBesin.KategoriID-1;

            }

            if (lbxBesinListesi.SelectedIndex >= 0)
            {
                Besin seciliBesin = (Besin)lbxBesinListesi.SelectedItem;
                var besinDetaylari = db.BesinDegerleri.FirstOrDefault(x => x.BesinID == seciliBesin.ID);

                lblGizliBesinID.Text = seciliBesin.ID.ToString();

                
                //txtAgirlik.Text = seciliBesin.BesininDegerleri.Gram.ToString();
                //txtKarbonhidrat.Text = besinDetaylari.Karbonhidrat.ToString();
                //txtYag.Text = besinDetaylari.Yag.ToString();
                //txtProtein.Text = besinDetaylari.Protein.ToString();
                //txtLif.Text = besinDetaylari.Lif.ToString();
                //txtKolestrol.Text = besinDetaylari.Kolestrol.ToString();
                //txtSodyum.Text = besinDetaylari.Sodyum.ToString();
                //txtPotasyum.Text = besinDetaylari.Potasyum.ToString();
                //txtKalsiyum.Text = besinDetaylari.Kalsiyum.ToString();

            }

            besinDegeriBilgisi = db.BesinDegerleri.FirstOrDefault(x => x.BesinID == Convert.ToInt32(lblGizliBesinID.Text));

            if (besinDegeriBilgisi != null)
            {
                btnGuncelle.Enabled = true;
                txtAgirlik.Text = besinDegeriBilgisi.Gram.ToString();
                txtKarbonhidrat.Text = besinDegeriBilgisi.Karbonhidrat.ToString();
                txtYag.Text = besinDegeriBilgisi.Yag.ToString();
                txtProtein.Text = besinDegeriBilgisi.Protein.ToString();
                txtLif.Text = besinDegeriBilgisi.Lif.ToString();
                txtKolestrol.Text = besinDegeriBilgisi.Kolestrol.ToString();
                txtSodyum.Text = besinDegeriBilgisi.Sodyum.ToString();
                txtPotasyum.Text = besinDegeriBilgisi.Potasyum.ToString();
                txtKalsiyum.Text = besinDegeriBilgisi.Kalsiyum.ToString();
            }
            else
            {
                btnGuncelle.Enabled = false;
            }


        }

        
        private void btnBesinDegeriEkle_Click(object sender, EventArgs e)
        {
            if (besinDegeriBilgisi != null)
            {
                btnBesinDegeriEkle.Enabled = false;

            }
            else
            {
                besinDegeriBilgisi = new BesinDegeri()
                {
                    BesinID = Convert.ToInt32(lblGizliBesinID.Text),
                    Gram = Convert.ToInt32(txtAgirlik.Text),             
                    Karbonhidrat = Convert.ToInt32(txtKarbonhidrat.Text),
                    Yag = Convert.ToInt32(txtYag.Text),
                    Protein = Convert.ToInt32(txtProtein.Text),
                    Lif = Convert.ToInt32(txtLif.Text),
                    Kolestrol = Convert.ToInt32(txtKolestrol.Text),
                    Sodyum = Convert.ToInt32(txtSodyum.Text),
                    Potasyum = Convert.ToInt32(txtPotasyum.Text),
                    Kalsiyum = Convert.ToInt32(txtKalsiyum.Text)


                };
                db.BesinDegerleri.Add(besinDegeriBilgisi);

            }
            db.SaveChanges();
            MessageBox.Show("Besin Degerleri Basariyla Eklenmistir.");
            lbxBesinListesi.SelectedIndex = -1;
            Metotlar.Temizle(grpBesinDegerleri);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lbxBesinListesi.SelectedIndex == -1) return;

            Besin besin = (Besin)lbxBesinListesi.SelectedItem;
            db.Besinler.Remove(besin);
            db.SaveChanges();
            Metotlar.Temizle(grpBesinArama);
            Metotlar.Temizle(grpBesinDegerleri);
            lblBesinBilgileri.Text = String.Empty;
        }

       
    }
}
