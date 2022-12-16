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
    public partial class AdminRegisterForm : Form
    {
        ProjectContext db;
        public AdminRegisterForm()
        {
            InitializeComponent();
            db = new ProjectContext();
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
                    Admin yeniAdmin = new Admin();  
                    yeniAdmin.AdminAdi=txtAdminAdi.Text;
                    yeniAdmin.AdminSifre = txtSifre.Text;
                    db.Add(yeniAdmin);
                    db.SaveChanges();

                    AdminForm adminGirisEkrani = new AdminForm();
                    this.Hide();
                    adminGirisEkrani.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("HATA!" + ex.Message);
            }
        }

        private void AdminRegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AdminForm adminGirisEkrani = new AdminForm();
            this.Hide();
            adminGirisEkrani.Show();
        }
    }
}
