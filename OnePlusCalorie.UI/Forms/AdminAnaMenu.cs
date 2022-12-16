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
    public partial class AdminAnaMenu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;


        public AdminAnaMenu()
        {
            InitializeComponent();
           
        }
        private Color SelectThemeColor()
        {
            int index = ThemeColor.ColorList.Count;
            string color = ThemeColor.ColorList[0];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButtons(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButtons();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = currentButton.ForeColor;
                }
            }
        }
        private void DisableButtons()
        {
            foreach (Control oncekiButon in pnlMenu.Controls)
            {
                if (oncekiButon.GetType() == typeof(Button))
                {
                    oncekiButon.BackColor = Color.FromArgb(224, 64, 106);
                    oncekiButon.ForeColor = Color.FromArgb(41, 44, 53);
                    oncekiButon.Font = oncekiButon.Font;
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButtons(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlForm.Controls.Add(childForm);
            this.pnlForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnBesinAyarları_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.BesinForm(), sender);
        }

        private void btnKullaniciAyarlari_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.KullaniciForm(), sender);
        }

        private void AdminAnaMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void AdminAnaMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
