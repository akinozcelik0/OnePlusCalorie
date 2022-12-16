namespace OnePlusCalorie.UI.Forms
{
    partial class KaloriForm
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
            this.grpBesinArama = new System.Windows.Forms.GroupBox();
            this.lblGizliBesinID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAramaKriteri = new System.Windows.Forms.ComboBox();
            this.txtAdAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.lbxBesinListesi = new System.Windows.Forms.ListBox();
            this.lblBesinBilgileri = new System.Windows.Forms.Label();
            this.grpKaloriEkleme = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtBesinAgirligi = new System.Windows.Forms.TextBox();
            this.txtKaloriDegeri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblKaloriDegeri = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblBesinAgirligiDegeri = new System.Windows.Forms.Label();
            this.lblBesinKaloriYazisi = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grpBesinArama.SuspendLayout();
            this.grpKaloriEkleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBesinArama
            // 
            this.grpBesinArama.Controls.Add(this.lblGizliBesinID);
            this.grpBesinArama.Controls.Add(this.label3);
            this.grpBesinArama.Controls.Add(this.label2);
            this.grpBesinArama.Controls.Add(this.cmbAramaKriteri);
            this.grpBesinArama.Controls.Add(this.txtAdAra);
            this.grpBesinArama.Controls.Add(this.btnAra);
            this.grpBesinArama.ForeColor = System.Drawing.Color.White;
            this.grpBesinArama.Location = new System.Drawing.Point(12, 12);
            this.grpBesinArama.Name = "grpBesinArama";
            this.grpBesinArama.Size = new System.Drawing.Size(308, 183);
            this.grpBesinArama.TabIndex = 2;
            this.grpBesinArama.TabStop = false;
            this.grpBesinArama.Text = "Besin Arama";
            // 
            // lblGizliBesinID
            // 
            this.lblGizliBesinID.AutoSize = true;
            this.lblGizliBesinID.Location = new System.Drawing.Point(216, 18);
            this.lblGizliBesinID.Name = "lblGizliBesinID";
            this.lblGizliBesinID.Size = new System.Drawing.Size(74, 15);
            this.lblGizliBesinID.TabIndex = 10;
            this.lblGizliBesinID.Text = "Gizli Besin ID";
            this.lblGizliBesinID.Visible = false;
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
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(106)))));
            this.btnAra.FlatAppearance.BorderSize = 0;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAra.Location = new System.Drawing.Point(182, 130);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(120, 47);
            this.btnAra.TabIndex = 5;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // lbxBesinListesi
            // 
            this.lbxBesinListesi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbxBesinListesi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbxBesinListesi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.lbxBesinListesi.FormattingEnabled = true;
            this.lbxBesinListesi.ItemHeight = 20;
            this.lbxBesinListesi.Location = new System.Drawing.Point(12, 208);
            this.lbxBesinListesi.Name = "lbxBesinListesi";
            this.lbxBesinListesi.Size = new System.Drawing.Size(308, 324);
            this.lbxBesinListesi.TabIndex = 23;
            this.lbxBesinListesi.SelectedIndexChanged += new System.EventHandler(this.lbxBesinListesi_SelectedIndexChanged);
            // 
            // lblBesinBilgileri
            // 
            this.lblBesinBilgileri.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblBesinBilgileri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBesinBilgileri.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBesinBilgileri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.lblBesinBilgileri.Location = new System.Drawing.Point(355, 12);
            this.lblBesinBilgileri.Name = "lblBesinBilgileri";
            this.lblBesinBilgileri.Size = new System.Drawing.Size(308, 520);
            this.lblBesinBilgileri.TabIndex = 24;
            this.lblBesinBilgileri.Text = "Besin Detayları için \r\nbesin aradıktan sonra besin listesinden secim yapınız.\r\n\r\n" +
    "<------\r\n";
            this.lblBesinBilgileri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpKaloriEkleme
            // 
            this.grpKaloriEkleme.Controls.Add(this.btnGuncelle);
            this.grpKaloriEkleme.Controls.Add(this.txtBesinAgirligi);
            this.grpKaloriEkleme.Controls.Add(this.txtKaloriDegeri);
            this.grpKaloriEkleme.Controls.Add(this.label1);
            this.grpKaloriEkleme.Controls.Add(this.label4);
            this.grpKaloriEkleme.Controls.Add(this.btnEkle);
            this.grpKaloriEkleme.ForeColor = System.Drawing.Color.White;
            this.grpKaloriEkleme.Location = new System.Drawing.Point(694, 12);
            this.grpKaloriEkleme.Name = "grpKaloriEkleme";
            this.grpKaloriEkleme.Size = new System.Drawing.Size(308, 145);
            this.grpKaloriEkleme.TabIndex = 25;
            this.grpKaloriEkleme.TabStop = false;
            this.grpKaloriEkleme.Text = "Kalori Değeri Ekleme";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(106)))));
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuncelle.Location = new System.Drawing.Point(177, 42);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(125, 83);
            this.btnGuncelle.TabIndex = 26;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtBesinAgirligi
            // 
            this.txtBesinAgirligi.Location = new System.Drawing.Point(13, 102);
            this.txtBesinAgirligi.Name = "txtBesinAgirligi";
            this.txtBesinAgirligi.Size = new System.Drawing.Size(143, 23);
            this.txtBesinAgirligi.TabIndex = 11;
            // 
            // txtKaloriDegeri
            // 
            this.txtKaloriDegeri.Location = new System.Drawing.Point(13, 42);
            this.txtKaloriDegeri.Name = "txtKaloriDegeri";
            this.txtKaloriDegeri.Size = new System.Drawing.Size(143, 23);
            this.txtKaloriDegeri.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Besin Ağırlığı (Gram):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kalori Değeri (Kcal):";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(106)))));
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.Location = new System.Drawing.Point(177, 42);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(125, 83);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OnePlusCalorie.UI.Properties.Resources.KaloriAtesIcon;
            this.pictureBox1.Location = new System.Drawing.Point(722, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // lblKaloriDegeri
            // 
            this.lblKaloriDegeri.BackColor = System.Drawing.Color.Transparent;
            this.lblKaloriDegeri.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKaloriDegeri.ForeColor = System.Drawing.Color.White;
            this.lblKaloriDegeri.Location = new System.Drawing.Point(869, 227);
            this.lblKaloriDegeri.Name = "lblKaloriDegeri";
            this.lblKaloriDegeri.Size = new System.Drawing.Size(99, 38);
            this.lblKaloriDegeri.TabIndex = 27;
            this.lblKaloriDegeri.Text = ".....";
            this.lblKaloriDegeri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OnePlusCalorie.UI.Properties.Resources.KaloriGramIcon;
            this.pictureBox2.Location = new System.Drawing.Point(722, 402);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(246, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // lblBesinAgirligiDegeri
            // 
            this.lblBesinAgirligiDegeri.BackColor = System.Drawing.Color.Transparent;
            this.lblBesinAgirligiDegeri.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBesinAgirligiDegeri.ForeColor = System.Drawing.Color.White;
            this.lblBesinAgirligiDegeri.Location = new System.Drawing.Point(871, 383);
            this.lblBesinAgirligiDegeri.Name = "lblBesinAgirligiDegeri";
            this.lblBesinAgirligiDegeri.Size = new System.Drawing.Size(99, 38);
            this.lblBesinAgirligiDegeri.TabIndex = 29;
            this.lblBesinAgirligiDegeri.Text = ".....";
            this.lblBesinAgirligiDegeri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBesinKaloriYazisi
            // 
            this.lblBesinKaloriYazisi.BackColor = System.Drawing.Color.Transparent;
            this.lblBesinKaloriYazisi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBesinKaloriYazisi.ForeColor = System.Drawing.Color.White;
            this.lblBesinKaloriYazisi.Location = new System.Drawing.Point(722, 227);
            this.lblBesinKaloriYazisi.Name = "lblBesinKaloriYazisi";
            this.lblBesinKaloriYazisi.Size = new System.Drawing.Size(141, 38);
            this.lblBesinKaloriYazisi.TabIndex = 30;
            this.lblBesinKaloriYazisi.Text = "Besin Kalorisi:";
            this.lblBesinKaloriYazisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(722, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 38);
            this.label8.TabIndex = 31;
            this.label8.Text = "Besin Ağırlığı:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KaloriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1019, 551);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblBesinKaloriYazisi);
            this.Controls.Add(this.lblBesinAgirligiDegeri);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblKaloriDegeri);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpKaloriEkleme);
            this.Controls.Add(this.lblBesinBilgileri);
            this.Controls.Add(this.lbxBesinListesi);
            this.Controls.Add(this.grpBesinArama);
            this.Name = "KaloriForm";
            this.Text = "KALORİ HESABI";
            this.Load += new System.EventHandler(this.KaloriForm_Load);
            this.grpBesinArama.ResumeLayout(false);
            this.grpBesinArama.PerformLayout();
            this.grpKaloriEkleme.ResumeLayout(false);
            this.grpKaloriEkleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpBesinArama;
        private Label label3;
        private Label label2;
        private ComboBox cmbAramaKriteri;
        private TextBox txtAdAra;
        private Button btnAra;
        private ListBox lbxBesinListesi;
        private Label lblBesinBilgileri;
        private GroupBox grpKaloriEkleme;
        private TextBox txtBesinAgirligi;
        private TextBox txtKaloriDegeri;
        private Label label1;
        private Label label4;
        private Button btnEkle;
        private Button btnGuncelle;
        private Label lblGizliBesinID;
        private PictureBox pictureBox1;
        private Label lblKaloriDegeri;
        private PictureBox pictureBox2;
        private Label lblBesinAgirligiDegeri;
        private Label lblBesinKaloriYazisi;
        private Label label8;
    }
}