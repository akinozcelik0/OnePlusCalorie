using OnePlusCalorie.DAL.Context;
using OnePlusCalorie.DATA.Entities;
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
    public partial class LoginForm : Form
    {
        ProjectContext db;
        
        public LoginForm()
        {
            InitializeComponent();
            db = new ProjectContext();

            txtKullaniciAdi.PlaceholderText = "Kullanıcı Adı";
            txtSifre.PlaceholderText = "Şifre";

            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void lblKayitOl_Click(object sender, EventArgs e)
        {
            RegisterForm kayitForm = new RegisterForm();
            this.Hide();
            kayitForm.Show();

            //RegisterForm kayitForm = (RegisterForm)Application.OpenForms["RegisterForm"];
            //kayitForm.Show();
            //this.Close();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtKullaniciAdi.Text == "" && txtSifre.Text == "")
                {
                    MessageBox.Show("Kullanıcı Adı ve Şifre giriniz!!");
                }
                else if (txtKullaniciAdi.Text == "" && txtSifre.Text != string.Empty)
                {
                    MessageBox.Show("Kullanıcı Adınızı giriniz!!");
                }
                else if (txtKullaniciAdi.Text != string.Empty && txtSifre.Text == "")
                {
                    MessageBox.Show("Şifrenizi giriniz!!");
                }
                else if (db.Kullanicilar.FirstOrDefault(user => user.KullaniciAdi == txtKullaniciAdi.Text && user.Sifre == txtSifre.Text) != null)
                {
                    Form1 anaMenu = new Form1(db.Kullanicilar.FirstOrDefault(user => user.KullaniciAdi == txtKullaniciAdi.Text && user.Sifre == txtSifre.Text));
                    this.Hide();
                    anaMenu.Show();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş Yaptınız!!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("HATA!!" + ex.Message);
            }

        }

        private void lblGuncelle_Click(object sender, EventArgs e)
        {
            UpdateForm GuncelleFormu = new UpdateForm();
            this.Hide();
            GuncelleFormu.Show();



            //UpdateForm GuncelleFormu = (UpdateForm)Application.OpenForms["UpdateForm"];

            //GuncelleFormu.Show();
            //this.Close();

        }

        private void txtKullaniciAdi_Click(object sender, EventArgs e)
        {
            //txtKullaniciAdi.Text = "";
        }

        private void txtSifre_Click(object sender, EventArgs e)
        {
            //txtSifre.Text = "";
        }

        private void txtKullaniciAdi_DoubleClick(object sender, EventArgs e)
        {
            txtKullaniciAdi.Text = "";
        }

        private void txtSifre_DoubleClick(object sender, EventArgs e)
        {
            txtSifre.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {
            AdminForm AdminFormu = new AdminForm();
            this.Hide();
            AdminFormu.Show();
        }
    }
}
