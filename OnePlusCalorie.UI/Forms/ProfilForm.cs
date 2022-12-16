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
    public partial class ProfilForm : Form
    {
        ProjectContext db;
        private Kullanici _kullanici;
        public ProfilForm(Kullanici kullanici)
        {
            InitializeComponent();
            db =new ProjectContext();
            _kullanici = kullanici;
        }
        private void ProfilForm_Load(object sender, EventArgs e)
        {
            var profilBilgisi = db.ProfilBilgileri.FirstOrDefault(x => x.KullaniciID == _kullanici.ID);
            if(profilBilgisi != null)
            {
                txtAd.Text = profilBilgisi.Ad;
                txtSoyad.Text = profilBilgisi.Soyad;
                txtYas.Text = profilBilgisi.Yas.ToString();
                txtKilo.Text = profilBilgisi.Kilo.ToString();
                txtBoy.Text = profilBilgisi.Boy.ToString();
                if (profilBilgisi.Cinsiyet == "Kadın")
                {
                    cmbCinsiyet.SelectedIndex = 0;
                }
                else if (profilBilgisi.Cinsiyet == "Erkek")
                {
                    cmbCinsiyet.SelectedIndex = 1;
                }
                else
                {
                    cmbCinsiyet.SelectedIndex = 2;
                }
                cmbYasamTarzi.SelectedIndex = 0;
                cmbHamilelikDurumu.SelectedIndex = 0;
                if (profilBilgisi.ProfilResmi != null)
                {
                    pbProfilResmi.Image = Image.FromFile("Images/" + profilBilgisi.ProfilResmi);
                    pbProfilResmi.Tag = Path.GetExtension(profilBilgisi.ProfilResmi);
                }



                lblVucutKitleEndeksi.Text = Convert.ToString(decimal.Round((decimal)VucutKitleEndeksiHesapla(), 2, MidpointRounding.AwayFromZero));
                lblIdealVucutAgirligi.Text = Convert.ToString(decimal.Round((decimal)IdealVucutAgirligiHesaplama(), 2, MidpointRounding.AwayFromZero));

                if (Convert.ToDouble(lblVucutKitleEndeksi.Text) < 19.8)
                {
                    pbVucutKitle.Image = OnePlusCalorie.UI.Properties.Resources.Normal;
                    pbVucutKitle.SizeMode = PictureBoxSizeMode.Zoom;
                    if (cmbHamilelikDurumu.SelectedIndex == 0)
                        txtBilgi.Text = "Anne adayının bu dönemde günlük 2500  kalori alması tavsiye edilir.";
                    else if (cmbHamilelikDurumu.SelectedIndex == 1)
                        txtBilgi.Text = "Anne adayına ek günlük  3000-3500 kalori alması tavsiye edilir.";
                    else
                        txtBilgi.Text = "Anne adayı ,hamile olmadığı döneme göre günlük 400-450 kalori daha fazla alması tavsiye edilir.";
                }
                else if (19.8 < Convert.ToDouble(lblVucutKitleEndeksi.Text) && Convert.ToDouble(lblVucutKitleEndeksi.Text) < 26)
                {
                    pbVucutKitle.Image = OnePlusCalorie.UI.Properties.Resources.FazlaKilolu;
                    pbVucutKitle.SizeMode = PictureBoxSizeMode.Zoom;
                    if (cmbHamilelikDurumu.SelectedIndex == 0)
                        txtBilgi.Text = "Anne adayının bu dönemde günlük ekstra kalori almasına ihityaç yoktur.";
                    else if (cmbHamilelikDurumu.SelectedIndex == 1)
                        txtBilgi.Text = "Anne adayına ek günlük  3000-3500 arası kalori alması tavsiye edilir.";
                    else
                        txtBilgi.Text = "Anne adayı ,hamile olmadığı döneme göre günlük 3000-3500 arası kalori daha fazla alması tavsiye edilir.";
                }
                else if (26 < Convert.ToDouble(lblVucutKitleEndeksi.Text) && Convert.ToDouble(lblVucutKitleEndeksi.Text) < 29)
                {
                    pbVucutKitle.Image = OnePlusCalorie.UI.Properties.Resources.Obez;
                    pbVucutKitle.SizeMode = PictureBoxSizeMode.Zoom;
                    if (cmbHamilelikDurumu.SelectedIndex == 0)
                        txtBilgi.Text = "Anne adayının bu dönemde günlük ekstra kalori kısıtlaması yapılabilir ancak günlük kalori tüketiminin 1500 kaloriden az 1800 kaloriden fazla olmamasına dikkat edilmelidir .";
                    else if (cmbHamilelikDurumu.SelectedIndex == 1)
                        txtBilgi.Text = "Anne adayına ek günlük  3000-3500 arası kalori alması tavsiye edilir.";
                    else
                        txtBilgi.Text = "Anne adayı ,hamile olmadığı döneme göre günlük 3000-3500 arası kalori daha fazla alması tavsiye edilir.";
                }
                else if (Convert.ToDouble(lblVucutKitleEndeksi.Text) > 29)
                {
                    pbVucutKitle.Image = OnePlusCalorie.UI.Properties.Resources.MorbidObez;
                    pbVucutKitle.SizeMode = PictureBoxSizeMode.Zoom;
                    if (cmbHamilelikDurumu.SelectedIndex == 0)
                        txtBilgi.Text = "Anne adayının bu dönemde günlük ekstra kalori kısıtlaması yapılabilir ancak günlük kalori tüketiminin 1500 kaloriden az 1800 kkaloriden fazla olmamasına dikkat edilmelidir .";
                    else if (cmbHamilelikDurumu.SelectedIndex == 1)
                        txtBilgi.Text = "Anne adayına ek günlük  3000-3500 arası kalori alması tavsiye edilir.";
                    else
                        txtBilgi.Text = "Anne adayı ,hamile olmadığı döneme göre günlük 3000-3500 arası kalori daha fazla alması tavsiye edilir.";

                }



                Metotlar.HepsiniKapat(grpProfilBilgileri);
            }
            


        }
        private void VucutKitleResim()
        {
            if (Convert.ToDouble(lblVucutKitleEndeksi.Text) < 24.90)
            {
                pbVucutKitle.Image = OnePlusCalorie.UI.Properties.Resources.Normal;
                pbVucutKitle.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (24.90 < Convert.ToDouble(lblVucutKitleEndeksi.Text) && Convert.ToDouble(lblVucutKitleEndeksi.Text) < 29.90)
            {
                pbVucutKitle.Image = OnePlusCalorie.UI.Properties.Resources.FazlaKilolu;
                pbVucutKitle.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (29.90 < Convert.ToDouble(lblVucutKitleEndeksi.Text) && Convert.ToDouble(lblVucutKitleEndeksi.Text) < 39.90)
            {
                pbVucutKitle.Image = OnePlusCalorie.UI.Properties.Resources.Obez;
                pbVucutKitle.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (39.90 < Convert.ToDouble(lblVucutKitleEndeksi.Text) && Convert.ToDouble(lblVucutKitleEndeksi.Text) < 40.90)
            {
                pbVucutKitle.Image = OnePlusCalorie.UI.Properties.Resources.MorbidObez;
                pbVucutKitle.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (50 < Convert.ToDouble(lblVucutKitleEndeksi.Text))
            {
                pbVucutKitle.Image = OnePlusCalorie.UI.Properties.Resources.SuperObez;
                pbVucutKitle.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            lblVucutKitleEndeksi.Text = Convert.ToString(decimal.Round((decimal)VucutKitleEndeksiHesapla(), 2, MidpointRounding.AwayFromZero));
            lblIdealVucutAgirligi.Text = Convert.ToString(decimal.Round((decimal)IdealVucutAgirligiHesaplama(), 2, MidpointRounding.AwayFromZero));

            var profilBilgisi = db.ProfilBilgileri.FirstOrDefault(x => x.KullaniciID == _kullanici.ID);
            if (profilBilgisi == null)
            {
                profilBilgisi = new ProfilBilgisi();
                if (pbProfilResmi.Tag != null)
                {
                    profilBilgisi.ProfilResmi = Guid.NewGuid() + pbProfilResmi.Tag.ToString();
                }
                profilBilgisi.Ad = txtAd.Text;
                profilBilgisi.Soyad = txtSoyad.Text;
                profilBilgisi.Kilo = Convert.ToDouble(txtKilo.Text);
                profilBilgisi.Boy = Convert.ToDouble(txtBoy.Text);
                profilBilgisi.GuncellemeTarihi = DateTime.Now;
                profilBilgisi.Yas = Convert.ToInt32(txtYas.Text);
                profilBilgisi.YasamTarzi = cmbYasamTarzi.SelectedItem.ToString();
                profilBilgisi.Cinsiyet = cmbCinsiyet.SelectedItem.ToString();
                profilBilgisi.KullaniciID = _kullanici.ID;


                lblVucutKitleEndeksi.Text = Convert.ToString(VucutKitleEndeksiHesapla());
                lblIdealVucutAgirligi.Text = Convert.ToString(IdealVucutAgirligiHesaplama());




                profilBilgisi.VucutKitleEndeksi = Convert.ToDouble(lblVucutKitleEndeksi.Text);
                if (profilBilgisi.ProfilResmi != null)
                {
                    pbProfilResmi.Image.Save(Application.StartupPath + "/Images/" + profilBilgisi.ProfilResmi);
                }
                


                db.ProfilBilgileri.Add(profilBilgisi);
                VucutKitleResim();
                db.SaveChanges();
            }
            else if (profilBilgisi != null)
            {
                lblVucutKitleEndeksi.Text = Convert.ToString(decimal.Round((decimal)VucutKitleEndeksiHesapla(), 2, MidpointRounding.AwayFromZero));
                lblIdealVucutAgirligi.Text = Convert.ToString(decimal.Round((decimal)IdealVucutAgirligiHesaplama(), 2, MidpointRounding.AwayFromZero));

                if (pbProfilResmi.Image != null)
                {
                    profilBilgisi.ProfilResmi = Guid.NewGuid() + pbProfilResmi.Tag.ToString();
                }
                profilBilgisi.Ad = txtAd.Text;
                profilBilgisi.Soyad = txtSoyad.Text;
                profilBilgisi.Kilo = Convert.ToDouble(txtKilo.Text);
                profilBilgisi.Boy = Convert.ToDouble(txtBoy.Text);
                profilBilgisi.GuncellemeTarihi = DateTime.Now;
                profilBilgisi.Yas = Convert.ToInt32(txtYas.Text);
                profilBilgisi.YasamTarzi = cmbYasamTarzi.SelectedItem.ToString();
                profilBilgisi.Cinsiyet = cmbCinsiyet.SelectedItem.ToString();
                profilBilgisi.KullaniciID = _kullanici.ID;


                lblVucutKitleEndeksi.Text = Convert.ToString(VucutKitleEndeksiHesapla());
                lblIdealVucutAgirligi.Text = Convert.ToString(IdealVucutAgirligiHesaplama());

                profilBilgisi.VucutKitleEndeksi = Convert.ToDouble(lblVucutKitleEndeksi.Text);

                pbProfilResmi.Image.Save(Application.StartupPath + "/Images/" + profilBilgisi.ProfilResmi);



                db.SaveChanges();
                VucutKitleResim();
                MessageBox.Show("Guncellenmistir");
            }


            if (Convert.ToDouble(lblVucutKitleEndeksi.Text) < 19.8)
            {
                pbVucutKitle.Image = OnePlusCalorie.UI.Properties.Resources.Normal;
                pbVucutKitle.SizeMode = PictureBoxSizeMode.Zoom;
                if (cmbHamilelikDurumu.SelectedIndex == 0)
                    txtBilgi.Text = "Anne adayının bu dönemde günlük 2500  kalori alması tavsiye edilir.";
                else if (cmbHamilelikDurumu.SelectedIndex == 1)
                    txtBilgi.Text = "Anne adayına ek günlük  3000-3500 kalori alması tavsiye edilir.";
                else
                    txtBilgi.Text = "Anne adayı ,hamile olmadığı döneme göre günlük 4000-4500 kalori daha fazla alması tavsiye edilir.";
            }
            else if (19.8 < Convert.ToDouble(lblVucutKitleEndeksi.Text) && Convert.ToDouble(lblVucutKitleEndeksi.Text) < 26)
            {
                pbVucutKitle.Image = OnePlusCalorie.UI.Properties.Resources.FazlaKilolu;
                pbVucutKitle.SizeMode = PictureBoxSizeMode.Zoom;
                if (cmbHamilelikDurumu.SelectedIndex == 0)
                    txtBilgi.Text = "Anne adayının bu dönemde günlük ekstra kalori almasına ihityaç yoktur.";
                else if (cmbHamilelikDurumu.SelectedIndex == 1)
                    txtBilgi.Text = "Anne adayına ek günlük  3000-3500 arası kalori alması tavsiye edilir.";
                else
                    txtBilgi.Text = "Anne adayı ,hamile olmadığı döneme göre günlük 3000-3500 arası kalori daha fazla alması tavsiye edilir.";
            }
            else if (26 < Convert.ToDouble(lblVucutKitleEndeksi.Text) && Convert.ToDouble(lblVucutKitleEndeksi.Text) < 29)
            {
                pbVucutKitle.Image = OnePlusCalorie.UI.Properties.Resources.Obez;
                pbVucutKitle.SizeMode = PictureBoxSizeMode.Zoom;
                if (cmbHamilelikDurumu.SelectedIndex == 0)
                    txtBilgi.Text = "Anne adayının bu dönemde günlük ekstra kalori kısıtlaması yapılabilir ancak günlük kalori tüketiminin 1500 kaloriden az 1800 kkaloriden fazla olmamasına dikkat edilmelidir .";
                else if (cmbHamilelikDurumu.SelectedIndex == 1)
                    txtBilgi.Text = "Anne adayına ek günlük  3000-3500 arası kalori alması tavsiye edilir.";
                else
                    txtBilgi.Text = "Anne adayı ,hamile olmadığı döneme göre günlük 3000-3500 arası kalori daha fazla alması tavsiye edilir.";
            }
            else if (Convert.ToDouble(lblVucutKitleEndeksi.Text) > 29)
            {
                pbVucutKitle.Image = OnePlusCalorie.UI.Properties.Resources.MorbidObez;
                pbVucutKitle.SizeMode = PictureBoxSizeMode.Zoom;
                if (cmbHamilelikDurumu.SelectedIndex == 0)
                    txtBilgi.Text = "Anne adayının bu dönemde günlük ekstra kalori kısıtlaması yapılabilir ancak günlük kalori tüketiminin 1500 kaloriden az 1800 kkaloriden fazla olmamasına dikkat edilmelidir .";
                else if (cmbHamilelikDurumu.SelectedIndex == 1)
                    txtBilgi.Text = "Anne adayına ek günlük  3000-3500 arası kalori alması tavsiye edilir.";
                else
                    txtBilgi.Text = "Anne adayı ,hamile olmadığı döneme göre günlük 3000-3500 arası kalori daha fazla alması tavsiye edilir.";

            }



            Metotlar.HepsiniKapat(grpProfilBilgileri);

        }

        private double VucutKitleEndeksiHesapla()
        {
            if(Convert.ToDouble(txtBoy.Text) < 5)
            {
                double boy = Convert.ToDouble(txtBoy.Text) * 100;
                double kilo = Convert.ToDouble(txtKilo.Text);
                double VKE = kilo / ((boy * boy)/10000);

                return VKE;
            }
            else
            {
                double boy = Convert.ToDouble(txtBoy.Text);
                double kilo = Convert.ToDouble(txtKilo.Text);
                double VKE = kilo / ((boy * boy)/10000);

                return VKE;
            }
        }

        private double IdealVucutAgirligiHesaplama()
        {
            if (cmbCinsiyet.SelectedText == "Kadın")
            {
                if (Convert.ToDouble(txtBoy.Text) < 5)
                {
                    double boy = Convert.ToDouble(txtBoy.Text) * 100;
                    double kilo = Convert.ToDouble(txtKilo.Text);
                    double IVA = 45.5 + (2.3 * ((boy/2.54) - 60));

                    return IVA;
                }
                else
                {
                    double boy = Convert.ToDouble(txtBoy.Text);
                    double kilo = Convert.ToDouble(txtKilo.Text);
                    double IVA = 45.5 + (2.3 * ((boy / 2.54) - 60));

                    return IVA;
                }
            }
            else if (cmbCinsiyet.SelectedText == "Erkek")
            {
                if (Convert.ToDouble(txtBoy.Text) < 5)
                {
                    double boy = Convert.ToDouble(txtBoy.Text) * 100;
                    double kilo = Convert.ToDouble(txtKilo.Text);
                    double IVA = 50 + (2.3 * ((boy / 2.54) - 60));

                    return IVA;
                }
                else
                {
                    double boy = Convert.ToDouble(txtBoy.Text);
                    double kilo = Convert.ToDouble(txtKilo.Text);
                    double IVA = 50 + (2.3 * ((boy / 2.54) - 60));

                    return IVA;
                }
            }
            else
            {
                if (Convert.ToDouble(txtBoy.Text) < 5)
                {
                    double boy = Convert.ToDouble(txtBoy.Text) * 100;
                    double kilo = Convert.ToDouble(txtKilo.Text);
                    double IVA = 47 + (2.3 * ((boy / 2.54) - 60));

                    return IVA;
                }
                else
                {
                    double boy = Convert.ToDouble(txtBoy.Text);
                    double kilo = Convert.ToDouble(txtKilo.Text);
                    double IVA = 47 + (2.3 * ((boy / 2.54) - 60));

                    return IVA;
                }
            }




        }

        private void btnProfilResimEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofp = new OpenFileDialog();
            ofp.Filter = "Profil Resmi(png,jpg,gif)|*.png;*.jpg;*.gif;";
            DialogResult dr = ofp.ShowDialog();

            if (dr == DialogResult.OK)
            {
                pbProfilResmi.Image = Image.FromFile(ofp.FileName);
                pbProfilResmi.Tag = Path.GetExtension(ofp.FileName); //GetExtention secilen dosyanin uzantisini alir (noktadan sonraki kisim).
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Metotlar.HepsiniAc(grpProfilBilgileri);
        }
    }
}
