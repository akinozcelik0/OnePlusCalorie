using OnePlusCalorie.DAL.Context;
using OnePlusCalorie.UI.Forms;
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
    public partial class AdminForm : Form
    {
        ProjectContext db;

        public AdminForm()
        {
            InitializeComponent();
            db = new ProjectContext();
        }

        private void lblKayitOl_Click(object sender, EventArgs e)
        {
            AdminRegisterForm AdminkayitForm = new AdminRegisterForm();
            this.Hide();
            AdminkayitForm.Show();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAdminAdi.Text == "" && txtSifre.Text == "")
                {
                    MessageBox.Show("Admin Adı ve Şifre giriniz!!");
                }
                else if (txtAdminAdi.Text == "" && txtSifre.Text != string.Empty)
                {
                    MessageBox.Show("Admin Adınızı giriniz!!");
                }
                else if (txtAdminAdi.Text != string.Empty && txtSifre.Text == "")
                {
                    MessageBox.Show("Şifrenizi giriniz!!");
                }
                else if (db.Adminler.FirstOrDefault(admin => admin.AdminAdi == txtAdminAdi.Text && admin.AdminSifre == txtSifre.Text) != null)
                {
                    AdminAnaMenu anaMenu = new AdminAnaMenu();
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
    }
}
