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

namespace OnePlusCalorie.UI.LoginRegister
{
    public partial class RegisterForm : Form
    {
        ProjectContext db;
        public RegisterForm()
        {
            InitializeComponent();

            db = new ProjectContext();

            txtAd.PlaceholderText = "Ad";  
            txtSoyad.PlaceholderText = "Soyad";
            txtKullaniciAdi.PlaceholderText = "Kullanıcı Adı";
            txtSifre.PlaceholderText = "Şifre";
            txtEmail.PlaceholderText = "Email";
            

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {


            try
            {
                if (Metotlar.BosAlanVarMiPanel(pnlKayit))
                {
                    MessageBox.Show("Boş Alan Bırakmayınız!!");
                }
                else
                {
                    Kullanici yeniKullanici = new Kullanici()
                    {
                        Adi = txtAd.Text,
                        Soyad = txtSoyad.Text,
                        Email = txtEmail.Text,
                        Telefon = txtTelefon.Text,
                        KullaniciAdi = txtKullaniciAdi.Text,
                        Sifre = txtSifre.Text,
                        UyelikTarihi = DateTime.Now,
                        GuncellemeTarihi = DateTime.Now
                    };
                    db.Add(yeniKullanici);
                    db.SaveChanges();


                    //LoginForm loginForm = (LoginForm)Application.OpenForms["LoginForm"];
                    //loginForm.Show();
                    //this.Close();


                    LoginForm girisEkrani = new LoginForm();
                    this.Hide();
                    girisEkrani.Show(); 
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("HATA!" + ex.Message);
            }
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm girisEkrani = new LoginForm();
            this.Hide();
            girisEkrani.Show();


            //LoginForm loginForm = (LoginForm)Application.OpenForms["LoginForm"];

            //loginForm.Show();
            //this.Close();
        }

        private void grpKayit_Enter(object sender, EventArgs e)
        {

        }
    }
}
