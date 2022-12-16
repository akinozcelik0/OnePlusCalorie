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
    public partial class KullaniciForm : Form
    {
        ProjectContext db;

        List<Kullanici> kullanicilar;
        public KullaniciForm()
        {
            InitializeComponent();
            db = new ProjectContext();
            
        }

        

        private void btnAra_Click(object sender, EventArgs e)
        {
            lbxKullaniciListesi.DisplayMember = "KullaniciAdi";

            if (txtAdAra.Text != string.Empty && cmbAramaKriteri.SelectedIndex >= 0)
            {
                if (cmbAramaKriteri.SelectedIndex == 0)
                {
                    lbxKullaniciListesi.DataSource = db.Kullanicilar.Where(x => EF.Functions.Like(x.KullaniciAdi, $"{txtAdAra.Text}%")).ToList();
                }
                else if (cmbAramaKriteri.SelectedIndex == 1)
                {
                    lbxKullaniciListesi.DataSource = db.Kullanicilar.Where(x => EF.Functions.Like(x.KullaniciAdi, $"%{txtAdAra.Text}%")).ToList();
                }
                else if (cmbAramaKriteri.SelectedIndex == 2)
                {
                    lbxKullaniciListesi.DataSource = db.Kullanicilar.Where(x => EF.Functions.Like(x.KullaniciAdi, $"%{txtAdAra.Text}")).ToList();
                }
            }
            else
            {
                MessageBox.Show("Lutfen arama yapmak icin secim yapiniz !!!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lbxKullaniciListesi.SelectedIndex == -1) return;

            Kullanici kullanici = (Kullanici)lbxKullaniciListesi.SelectedItem;
            db.Kullanicilar.Remove(kullanici);
            db.SaveChanges();
            Metotlar.Temizle(grpKullaniciArama);
            Metotlar.Temizle(grpKullaniciListesi);
            lbxKullaniciListesi.Text = String.Empty;
        }
    }
}
