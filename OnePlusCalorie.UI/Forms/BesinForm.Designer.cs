namespace OnePlusCalorie.UI.Forms
{
    partial class BesinForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBesinKayit = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.txtBesinAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBesinArama = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAramaKriteri = new System.Windows.Forms.ComboBox();
            this.txtAdAra = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.grpBesinDegerleri = new System.Windows.Forms.GroupBox();
            this.lblGizliBesinID = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDegerlerBesinKategori = new System.Windows.Forms.ComboBox();
            this.txtDegerlerBesinAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbxBesinListesi = new System.Windows.Forms.ListBox();
            this.btnBesinDegeriEkle = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtKalsiyum = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSodyum = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPotasyum = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtKolestrol = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtYag = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProtein = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLif = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKarbonhidrat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAgirlik = new System.Windows.Forms.TextBox();
            this.lblBesinBilgileri = new System.Windows.Forms.Label();
            this.grpBesinKayit.SuspendLayout();
            this.grpBesinArama.SuspendLayout();
            this.grpBesinDegerleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBesinKayit
            // 
            this.grpBesinKayit.Controls.Add(this.btnEkle);
            this.grpBesinKayit.Controls.Add(this.label6);
            this.grpBesinKayit.Controls.Add(this.cmbKategori);
            this.grpBesinKayit.Controls.Add(this.txtBesinAd);
            this.grpBesinKayit.Controls.Add(this.label1);
            this.grpBesinKayit.ForeColor = System.Drawing.Color.White;
            this.grpBesinKayit.Location = new System.Drawing.Point(12, 12);
            this.grpBesinKayit.Name = "grpBesinKayit";
            this.grpBesinKayit.Size = new System.Drawing.Size(319, 183);
            this.grpBesinKayit.TabIndex = 0;
            this.grpBesinKayit.TabStop = false;
            this.grpBesinKayit.Text = "Besin Kayıt Bölümü";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(106)))));
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.Location = new System.Drawing.Point(193, 130);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(120, 47);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Besin Adı:";
            // 
            // cmbKategori
            // 
            this.cmbKategori.BackColor = System.Drawing.Color.White;
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(15, 102);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(179, 23);
            this.cmbKategori.TabIndex = 1;
            // 
            // txtBesinAd
            // 
            this.txtBesinAd.BackColor = System.Drawing.Color.White;
            this.txtBesinAd.Location = new System.Drawing.Point(15, 43);
            this.txtBesinAd.Name = "txtBesinAd";
            this.txtBesinAd.Size = new System.Drawing.Size(179, 23);
            this.txtBesinAd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Besin Kategorisi:";
            // 
            // grpBesinArama
            // 
            this.grpBesinArama.Controls.Add(this.btnAra);
            this.grpBesinArama.Controls.Add(this.label3);
            this.grpBesinArama.Controls.Add(this.label2);
            this.grpBesinArama.Controls.Add(this.cmbAramaKriteri);
            this.grpBesinArama.Controls.Add(this.txtAdAra);
            this.grpBesinArama.ForeColor = System.Drawing.Color.White;
            this.grpBesinArama.Location = new System.Drawing.Point(346, 12);
            this.grpBesinArama.Name = "grpBesinArama";
            this.grpBesinArama.Size = new System.Drawing.Size(308, 183);
            this.grpBesinArama.TabIndex = 1;
            this.grpBesinArama.TabStop = false;
            this.grpBesinArama.Text = "Besin Arama";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(106)))));
            this.btnAra.FlatAppearance.BorderSize = 0;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAra.Location = new System.Drawing.Point(182, 130);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(120, 47);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ad ile Arama Kriteri:";
            // 
            // cmbAramaKriteri
            // 
            this.cmbAramaKriteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAramaKriteri.FormattingEnabled = true;
            this.cmbAramaKriteri.Items.AddRange(new object[] {
            "ile başlayanlar",
            "içerenler",
            "ile bitenler"});
            this.cmbAramaKriteri.Location = new System.Drawing.Point(21, 43);
            this.cmbAramaKriteri.Name = "cmbAramaKriteri";
            this.cmbAramaKriteri.Size = new System.Drawing.Size(185, 23);
            this.cmbAramaKriteri.TabIndex = 7;
            // 
            // txtAdAra
            // 
            this.txtAdAra.Location = new System.Drawing.Point(21, 102);
            this.txtAdAra.Name = "txtAdAra";
            this.txtAdAra.Size = new System.Drawing.Size(185, 23);
            this.txtAdAra.TabIndex = 6;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(106)))));
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSil.Location = new System.Drawing.Point(587, 277);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(177, 47);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Besin Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // grpBesinDegerleri
            // 
            this.grpBesinDegerleri.Controls.Add(this.lblGizliBesinID);
            this.grpBesinDegerleri.Controls.Add(this.btnGuncelle);
            this.grpBesinDegerleri.Controls.Add(this.label4);
            this.grpBesinDegerleri.Controls.Add(this.cmbDegerlerBesinKategori);
            this.grpBesinDegerleri.Controls.Add(this.btnSil);
            this.grpBesinDegerleri.Controls.Add(this.txtDegerlerBesinAdi);
            this.grpBesinDegerleri.Controls.Add(this.label5);
            this.grpBesinDegerleri.Controls.Add(this.lbxBesinListesi);
            this.grpBesinDegerleri.Controls.Add(this.btnBesinDegeriEkle);
            this.grpBesinDegerleri.Controls.Add(this.label15);
            this.grpBesinDegerleri.Controls.Add(this.txtKalsiyum);
            this.grpBesinDegerleri.Controls.Add(this.label14);
            this.grpBesinDegerleri.Controls.Add(this.txtSodyum);
            this.grpBesinDegerleri.Controls.Add(this.label13);
            this.grpBesinDegerleri.Controls.Add(this.txtPotasyum);
            this.grpBesinDegerleri.Controls.Add(this.label12);
            this.grpBesinDegerleri.Controls.Add(this.txtKolestrol);
            this.grpBesinDegerleri.Controls.Add(this.label11);
            this.grpBesinDegerleri.Controls.Add(this.txtYag);
            this.grpBesinDegerleri.Controls.Add(this.label10);
            this.grpBesinDegerleri.Controls.Add(this.txtProtein);
            this.grpBesinDegerleri.Controls.Add(this.label9);
            this.grpBesinDegerleri.Controls.Add(this.txtLif);
            this.grpBesinDegerleri.Controls.Add(this.label8);
            this.grpBesinDegerleri.Controls.Add(this.txtKarbonhidrat);
            this.grpBesinDegerleri.Controls.Add(this.label7);
            this.grpBesinDegerleri.Controls.Add(this.txtAgirlik);
            this.grpBesinDegerleri.ForeColor = System.Drawing.Color.White;
            this.grpBesinDegerleri.Location = new System.Drawing.Point(12, 201);
            this.grpBesinDegerleri.Name = "grpBesinDegerleri";
            this.grpBesinDegerleri.Size = new System.Drawing.Size(1002, 346);
            this.grpBesinDegerleri.TabIndex = 7;
            this.grpBesinDegerleri.TabStop = false;
            this.grpBesinDegerleri.Text = "Besin Değerleri Bölümü";
            // 
            // lblGizliBesinID
            // 
            this.lblGizliBesinID.AutoSize = true;
            this.lblGizliBesinID.Location = new System.Drawing.Point(348, 19);
            this.lblGizliBesinID.Name = "lblGizliBesinID";
            this.lblGizliBesinID.Size = new System.Drawing.Size(85, 15);
            this.lblGizliBesinID.TabIndex = 28;
            this.lblGizliBesinID.Text = "GIZLE BESIN ID";
            this.lblGizliBesinID.Visible = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(106)))));
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuncelle.Location = new System.Drawing.Point(346, 234);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(177, 90);
            this.btnGuncelle.TabIndex = 27;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(346, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Besin Adı:";
            // 
            // cmbDegerlerBesinKategori
            // 
            this.cmbDegerlerBesinKategori.BackColor = System.Drawing.Color.White;
            this.cmbDegerlerBesinKategori.FormattingEnabled = true;
            this.cmbDegerlerBesinKategori.Location = new System.Drawing.Point(346, 127);
            this.cmbDegerlerBesinKategori.Name = "cmbDegerlerBesinKategori";
            this.cmbDegerlerBesinKategori.Size = new System.Drawing.Size(179, 23);
            this.cmbDegerlerBesinKategori.TabIndex = 24;
            // 
            // txtDegerlerBesinAdi
            // 
            this.txtDegerlerBesinAdi.BackColor = System.Drawing.Color.White;
            this.txtDegerlerBesinAdi.Location = new System.Drawing.Point(346, 68);
            this.txtDegerlerBesinAdi.Name = "txtDegerlerBesinAdi";
            this.txtDegerlerBesinAdi.Size = new System.Drawing.Size(179, 23);
            this.txtDegerlerBesinAdi.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(346, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Besin Kategorisi:";
            // 
            // lbxBesinListesi
            // 
            this.lbxBesinListesi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbxBesinListesi.FormattingEnabled = true;
            this.lbxBesinListesi.ItemHeight = 15;
            this.lbxBesinListesi.Location = new System.Drawing.Point(15, 22);
            this.lbxBesinListesi.Name = "lbxBesinListesi";
            this.lbxBesinListesi.Size = new System.Drawing.Size(298, 304);
            this.lbxBesinListesi.TabIndex = 22;
            this.lbxBesinListesi.SelectedIndexChanged += new System.EventHandler(this.lbxBesinListesi_SelectedIndexChanged);
            // 
            // btnBesinDegeriEkle
            // 
            this.btnBesinDegeriEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(106)))));
            this.btnBesinDegeriEkle.FlatAppearance.BorderSize = 0;
            this.btnBesinDegeriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBesinDegeriEkle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBesinDegeriEkle.Location = new System.Drawing.Point(805, 278);
            this.btnBesinDegeriEkle.Name = "btnBesinDegeriEkle";
            this.btnBesinDegeriEkle.Size = new System.Drawing.Size(186, 46);
            this.btnBesinDegeriEkle.TabIndex = 21;
            this.btnBesinDegeriEkle.Text = "Besin Değeri Ekle";
            this.btnBesinDegeriEkle.UseVisualStyleBackColor = false;
            this.btnBesinDegeriEkle.Click += new System.EventHandler(this.btnBesinDegeriEkle_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(814, 213);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 20);
            this.label15.TabIndex = 20;
            this.label15.Text = "Kalsiyum:";
            // 
            // txtKalsiyum
            // 
            this.txtKalsiyum.Location = new System.Drawing.Point(814, 236);
            this.txtKalsiyum.Name = "txtKalsiyum";
            this.txtKalsiyum.Size = new System.Drawing.Size(177, 23);
            this.txtKalsiyum.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(814, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 20);
            this.label14.TabIndex = 18;
            this.label14.Text = "Sodyum:";
            // 
            // txtSodyum
            // 
            this.txtSodyum.Location = new System.Drawing.Point(814, 126);
            this.txtSodyum.Name = "txtSodyum";
            this.txtSodyum.Size = new System.Drawing.Size(177, 23);
            this.txtSodyum.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(814, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "Potasyum:";
            // 
            // txtPotasyum
            // 
            this.txtPotasyum.Location = new System.Drawing.Point(814, 183);
            this.txtPotasyum.Name = "txtPotasyum";
            this.txtPotasyum.Size = new System.Drawing.Size(177, 23);
            this.txtPotasyum.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(814, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Kolestrol:";
            // 
            // txtKolestrol
            // 
            this.txtKolestrol.Location = new System.Drawing.Point(814, 69);
            this.txtKolestrol.Name = "txtKolestrol";
            this.txtKolestrol.Size = new System.Drawing.Size(177, 23);
            this.txtKolestrol.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(587, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Yağ:";
            // 
            // txtYag
            // 
            this.txtYag.Location = new System.Drawing.Point(587, 126);
            this.txtYag.Name = "txtYag";
            this.txtYag.Size = new System.Drawing.Size(177, 23);
            this.txtYag.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(587, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Lif:";
            // 
            // txtProtein
            // 
            this.txtProtein.Location = new System.Drawing.Point(587, 179);
            this.txtProtein.Name = "txtProtein";
            this.txtProtein.Size = new System.Drawing.Size(177, 23);
            this.txtProtein.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(587, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Protein:";
            // 
            // txtLif
            // 
            this.txtLif.Location = new System.Drawing.Point(587, 234);
            this.txtLif.Name = "txtLif";
            this.txtLif.Size = new System.Drawing.Size(177, 23);
            this.txtLif.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(587, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Karbonhidrat:";
            // 
            // txtKarbonhidrat
            // 
            this.txtKarbonhidrat.Location = new System.Drawing.Point(587, 69);
            this.txtKarbonhidrat.Name = "txtKarbonhidrat";
            this.txtKarbonhidrat.Size = new System.Drawing.Size(177, 23);
            this.txtKarbonhidrat.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(346, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ağırlık (Gram):";
            // 
            // txtAgirlik
            // 
            this.txtAgirlik.Location = new System.Drawing.Point(346, 185);
            this.txtAgirlik.Name = "txtAgirlik";
            this.txtAgirlik.Size = new System.Drawing.Size(177, 23);
            this.txtAgirlik.TabIndex = 0;
            // 
            // lblBesinBilgileri
            // 
            this.lblBesinBilgileri.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblBesinBilgileri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBesinBilgileri.ForeColor = System.Drawing.Color.Black;
            this.lblBesinBilgileri.Location = new System.Drawing.Point(660, 12);
            this.lblBesinBilgileri.Name = "lblBesinBilgileri";
            this.lblBesinBilgileri.Size = new System.Drawing.Size(354, 183);
            this.lblBesinBilgileri.TabIndex = 8;
            this.lblBesinBilgileri.Text = "Besin Detayları için Besin aradıktan sonra besin listesinden secim yapınız.";
            this.lblBesinBilgileri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BesinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1019, 551);
            this.Controls.Add(this.lblBesinBilgileri);
            this.Controls.Add(this.grpBesinDegerleri);
            this.Controls.Add(this.grpBesinArama);
            this.Controls.Add(this.grpBesinKayit);
            this.Name = "BesinForm";
            this.Text = "BESİNLER";
            this.Load += new System.EventHandler(this.BesinForm_Load);
            this.grpBesinKayit.ResumeLayout(false);
            this.grpBesinKayit.PerformLayout();
            this.grpBesinArama.ResumeLayout(false);
            this.grpBesinArama.PerformLayout();
            this.grpBesinDegerleri.ResumeLayout(false);
            this.grpBesinDegerleri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpBesinKayit;
        private GroupBox grpBesinArama;
        private Label label1;
        private GroupBox grpBesinDegerleri;
        private Button btnEkle;
        private Label label6;
        private ComboBox cmbKategori;
        private TextBox txtBesinAd;
        private Button btnBesinDegeriEkle;
        private Label label15;
        private TextBox txtKalsiyum;
        private Label label14;
        private TextBox txtSodyum;
        private Label label13;
        private TextBox txtPotasyum;
        private Label label12;
        private TextBox txtKolestrol;
        private Label label11;
        private TextBox txtYag;
        private Label label10;
        private TextBox txtProtein;
        private Label label9;
        private TextBox txtLif;
        private Label label8;
        private TextBox txtKarbonhidrat;
        private Label label7;
        private TextBox txtAgirlik;
        private Label label3;
        private Label label2;
        private ComboBox cmbAramaKriteri;
        private TextBox txtAdAra;
        private Button btnSil;
        private Button btnGuncelle;
        private Label label4;
        private ComboBox cmbDegerlerBesinKategori;
        private TextBox txtDegerlerBesinAdi;
        private Label label5;
        private ListBox lbxBesinListesi;
        private Label lblBesinBilgileri;
        private Label lblGizliBesinID;
        private Button btnAra;
    }
}