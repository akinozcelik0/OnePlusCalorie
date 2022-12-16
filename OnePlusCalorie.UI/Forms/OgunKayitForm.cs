using Microsoft.Data.SqlClient;
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
    public partial class OgunKayitForm : Form
    {
        ProjectContext db;
        Besin besin;
        public ProfilForm frm;
        OgunDetaylari ogunDetayi;
        private Kullanici _kullanici;
        Besin seciliBesin;
        ProfilBilgisi pb;


        public OgunKayitForm(Kullanici kullanici)
        {
            //con.Open();
            InitializeComponent();
            _kullanici = kullanici;
            db = new ProjectContext();
            Listele();
            cmbOgunler.SelectedIndex = 0;
            cbArama.SelectedIndex = 0;

        }

        private void Listele()
        {

            string ara = cbArama.Text;
            DateTime date = dtpOgunArama.Value;
            var result = (from o in db.OgunDetaylar
                          join t in db.BesinOgunTablosu
                          on o.ID equals t.BesininOgunuID
                          join b in db.Besinler on t.BesinID equals b.ID
                          join k in db.Kaloriler.DefaultIfEmpty() on b.ID equals k.BesinID
                          join ka in db.BesinKategorileri on b.KategoriID equals ka.ID
                          where o.OgunAdi == ara && o.EklenmeZamani.Year == date.Year && o.EklenmeZamani.Month == date.Month &&
                          o.EklenmeZamani.Day == date.Day

                          select new
                          {
                              b.Ad,
                              o.EklenmeZamani,
                              o.OgunAdi,
                              k._Kalori,
                              ka.KategoriAdi
                          }).ToList();

            dgvOgunRaporu.DataSource = result;
            dgvOgunRaporu.Refresh();

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

        private void lbxBesinListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxBesinListesi.SelectedIndex >= 0)
            {
                seciliBesin = (Besin)lbxBesinListesi.SelectedItem;
                var besinDetaylari = db.BesinDegerleri.FirstOrDefault(x => x.BesinID == seciliBesin.ID);

            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (Metotlar.BosAlanVarMiPanel(pnlOgun))
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız!");
            }
            else
            {
                OgunDetaylari yeniOgun = new OgunDetaylari()
                {
                    BesinID = seciliBesin.ID,
                    OgunAdi = cmbOgunler.Text,
                    EklenmeZamani = dtpOgunTarihi.Value

                };


                db.OgunDetaylar.Add(yeniOgun);

                db.SaveChanges();


                BesinOgun besinOgun = new BesinOgun()
                {
                    BesinID = seciliBesin.ID,
                    BesininOgunuID = yeniOgun.ID,

                };

                db.BesinOgunTablosu.Add(besinOgun);
                db.SaveChanges();
                pb = db.ProfilBilgileri.FirstOrDefault(p => p.KullaniciID == _kullanici.ID);
                if (pb != null)
                {
                    ProfilOgun profilOgun = new ProfilOgun()
                    {
                        ProfillerID = pb.ID,
                        OgunDetaylariID = yeniOgun.ID

                    };
                    db.ProfilOgunTablolari.Add(profilOgun);
                    db.SaveChanges();
                }
            }

        }

        private void btnOgunAra_Click(object sender, EventArgs e)
        {
            Listele();
            pb = db.ProfilBilgileri.FirstOrDefault(p => p.KullaniciID == _kullanici.ID);
            int total = dgvOgunRaporu.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToInt32(x.Cells[3].Value));
            int sayac = 0;
            string tekrarEdenBesin = "";

            for (int i = 0; i < dgvOgunRaporu.Rows.Count; ++i)
            {
                for (int j = 0; j < dgvOgunRaporu.Rows.Count; j++)
                {
                    if (Convert.ToString(dgvOgunRaporu.Rows[j].Cells[0].Value) == Convert.ToString(dgvOgunRaporu.Rows[i].Cells[0].Value))
                    {
                        sayac++;
                        if (sayac > 1)
                        {
                            tekrarEdenBesin = Convert.ToString(dgvOgunRaporu.Rows[i - 1].Cells[0].Value);
                        }
                    }
                }
            }

            string sonuc = sayac > 1 ? tekrarEdenBesin : "Hiç bir besin birden fazla tüketilmemiştir";
            if (pb.VucutKitleEndeksi < 19.8)
            {
                if (pb.HamilelikDurumu == "2-1.Dönem(1-12 Haftalar)")
                {
                    lblTavsiye.Text = $"Vucut Kitle İndeksiniz:{pb.VucutKitleEndeksi.ToString()}\n\r Alınan Kalori:{total.ToString()}\n\r Almanız gereken günlük kalori:{(2250 - total).ToString()} \n\r {sonuc}";
                }
                else if (pb.HamilelikDurumu == "3 - 2.Dönem(13 - 27 Haftalar)")
                {
                    lblTavsiye.Text = $"Vucut Kitle İndeksiniz:{pb.VucutKitleEndeksi.ToString()}\n\r Alınan Kalori:{total.ToString()}\n\r Almanız gereken günlük kalori:{(2500 - total).ToString()} \n\r {sonuc}";
                }
                else
                {
                    lblTavsiye.Text = $"Vucut Kitle İndeksiniz:{pb.VucutKitleEndeksi.ToString()}\n\r Alınan Kalori:{total.ToString()}\n\r Almanız gereken günlük kalori:{(2500 - total).ToString()} \n\r {sonuc}";
                }

            }
            else if (pb.VucutKitleEndeksi > 19.8 && pb.VucutKitleEndeksi < 26)
            {
                if (pb.HamilelikDurumu == "2-1.Dönem(1-12 Haftalar)")
                {
                    lblTavsiye.Text = $"Vucut Kitle İndeksiniz:{pb.VucutKitleEndeksi.ToString()}\n\r Alınan Kalori:{total.ToString()}\n\r Almanız gereken ekstra günlük kalori miktarı yoktur. \n\r {sonuc}";
                }
                else if (pb.HamilelikDurumu == "3 - 2.Dönem(13 - 27 Haftalar)")
                {
                    lblTavsiye.Text = $"Vucut Kitle İndeksiniz:{pb.VucutKitleEndeksi.ToString()}\n\r Alınan Kalori:{total.ToString()}\n\r Almanız gereken günlük kalori:{(2500 - total).ToString()} \n\r {sonuc}";
                }
                else
                {
                    lblTavsiye.Text = $"Vucut Kitle İndeksiniz:{pb.VucutKitleEndeksi.ToString()}\n\r Alınan Kalori:{total.ToString()}\n\r Almanız gereken günlük kalori:{(2500 - total).ToString()} \n\r {sonuc}";
                }
            }
            else if (pb.VucutKitleEndeksi > 26)
            {
                if (pb.HamilelikDurumu == "2-1.Dönem(1-12 Haftalar)")
                {
                    lblTavsiye.Text = $"Vucut Kitle İndeksiniz:{pb.VucutKitleEndeksi.ToString()}\n\r Alınan Kalori:{total.ToString()}\n\r Almanız gereken ekstra günlük kalori miktarı yoktur. Günlük kalori miktarınınzı 1500 ile 1800 arasında tutmalısınız \n\r {sonuc}";
                }
                else if (pb.HamilelikDurumu == "3 - 2.Dönem(13 - 27 Haftalar)")
                {
                    lblTavsiye.Text = $"Vucut Kitle İndeksiniz:{pb.VucutKitleEndeksi.ToString()}\n\r Alınan Kalori:{total.ToString()}\n\r Almanız gereken günlük kalori:{(2100 - total).ToString()} \n\r {sonuc}";
                }
                else
                {
                    lblTavsiye.Text = $"Vucut Kitle İndeksiniz:{pb.VucutKitleEndeksi.ToString()}\n\r Alınan Kalori:{total.ToString()}\n\r Almanız gereken günlük kalori:{(2100 - total).ToString()} \n\r {sonuc}";
                }
            }
        }


    }
}
