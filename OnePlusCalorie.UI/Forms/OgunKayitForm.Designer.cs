namespace OnePlusCalorie.UI.Forms
{
    partial class OgunKayitForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAramaKriteri = new System.Windows.Forms.ComboBox();
            this.txtAdAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.lbxBesinListesi = new System.Windows.Forms.ListBox();
            this.pnlOgun = new System.Windows.Forms.Panel();
            this.lblGizliOgunID = new System.Windows.Forms.Label();
            this.lblGizliBesinID = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOgunler = new System.Windows.Forms.ComboBox();
            this.dtpOgunTarihi = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOgunAra = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbArama = new System.Windows.Forms.ComboBox();
            this.dtpOgunArama = new System.Windows.Forms.DateTimePicker();
            this.dgvOgunRaporu = new System.Windows.Forms.DataGridView();
            this.lblTavsiye = new System.Windows.Forms.Label();
            this.grpBesinArama.SuspendLayout();
            this.pnlOgun.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgunRaporu)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBesinArama
            // 
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
            this.lbxBesinListesi.FormattingEnabled = true;
            this.lbxBesinListesi.ItemHeight = 15;
            this.lbxBesinListesi.Location = new System.Drawing.Point(12, 213);
            this.lbxBesinListesi.Name = "lbxBesinListesi";
            this.lbxBesinListesi.Size = new System.Drawing.Size(308, 319);
            this.lbxBesinListesi.TabIndex = 23;
            this.lbxBesinListesi.SelectedIndexChanged += new System.EventHandler(this.lbxBesinListesi_SelectedIndexChanged);
            // 
            // pnlOgun
            // 
            this.pnlOgun.Controls.Add(this.lblGizliOgunID);
            this.pnlOgun.Controls.Add(this.lblGizliBesinID);
            this.pnlOgun.Controls.Add(this.btnEkle);
            this.pnlOgun.Controls.Add(this.label4);
            this.pnlOgun.Controls.Add(this.label1);
            this.pnlOgun.Controls.Add(this.cmbOgunler);
            this.pnlOgun.Controls.Add(this.dtpOgunTarihi);
            this.pnlOgun.Location = new System.Drawing.Point(343, 19);
            this.pnlOgun.Name = "pnlOgun";
            this.pnlOgun.Size = new System.Drawing.Size(312, 176);
            this.pnlOgun.TabIndex = 24;
            // 
            // lblGizliOgunID
            // 
            this.lblGizliOgunID.AutoSize = true;
            this.lblGizliOgunID.ForeColor = System.Drawing.Color.White;
            this.lblGizliOgunID.Location = new System.Drawing.Point(235, 36);
            this.lblGizliOgunID.Name = "lblGizliOgunID";
            this.lblGizliOgunID.Size = new System.Drawing.Size(74, 15);
            this.lblGizliOgunID.TabIndex = 27;
            this.lblGizliOgunID.Text = "Gizli Besin ID";
            this.lblGizliOgunID.Visible = false;
            // 
            // lblGizliBesinID
            // 
            this.lblGizliBesinID.AutoSize = true;
            this.lblGizliBesinID.ForeColor = System.Drawing.Color.White;
            this.lblGizliBesinID.Location = new System.Drawing.Point(225, 12);
            this.lblGizliBesinID.Name = "lblGizliBesinID";
            this.lblGizliBesinID.Size = new System.Drawing.Size(74, 15);
            this.lblGizliBesinID.TabIndex = 26;
            this.lblGizliBesinID.Text = "Gizli Besin ID";
            this.lblGizliBesinID.Visible = false;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(106)))));
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(181, 123);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(120, 47);
            this.btnEkle.TabIndex = 25;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Öğün Seçimi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Öğün Tarihi:";
            // 
            // cmbOgunler
            // 
            this.cmbOgunler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOgunler.FormattingEnabled = true;
            this.cmbOgunler.Items.AddRange(new object[] {
            "Kahvaltı",
            "Ara Öğün-1",
            "Öğle Yemeği",
            "Ara Öğün-2",
            "Akşam Yemeği",
            "Ek Öğün"});
            this.cmbOgunler.Location = new System.Drawing.Point(23, 95);
            this.cmbOgunler.Name = "cmbOgunler";
            this.cmbOgunler.Size = new System.Drawing.Size(200, 23);
            this.cmbOgunler.TabIndex = 1;
            // 
            // dtpOgunTarihi
            // 
            this.dtpOgunTarihi.Location = new System.Drawing.Point(23, 36);
            this.dtpOgunTarihi.Name = "dtpOgunTarihi";
            this.dtpOgunTarihi.Size = new System.Drawing.Size(200, 23);
            this.dtpOgunTarihi.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnOgunAra);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbArama);
            this.panel1.Controls.Add(this.dtpOgunArama);
            this.panel1.Location = new System.Drawing.Point(692, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 176);
            this.panel1.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(235, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Gizli Besin ID";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(225, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Gizli Besin ID";
            this.label6.Visible = false;
            // 
            // btnOgunAra
            // 
            this.btnOgunAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(106)))));
            this.btnOgunAra.FlatAppearance.BorderSize = 0;
            this.btnOgunAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgunAra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOgunAra.ForeColor = System.Drawing.Color.White;
            this.btnOgunAra.Location = new System.Drawing.Point(23, 123);
            this.btnOgunAra.Name = "btnOgunAra";
            this.btnOgunAra.Size = new System.Drawing.Size(278, 47);
            this.btnOgunAra.TabIndex = 25;
            this.btnOgunAra.Text = "Öğün Ara";
            this.btnOgunAra.UseVisualStyleBackColor = false;
            this.btnOgunAra.Click += new System.EventHandler(this.btnOgunAra_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Aranacak Öğün Seçimi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(23, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Aranacak Öğün Tarihi:";
            // 
            // cbArama
            // 
            this.cbArama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArama.FormattingEnabled = true;
            this.cbArama.Items.AddRange(new object[] {
            "Kahvaltı",
            "Ara Öğün-1",
            "Öğle Yemeği",
            "Ara Öğün-2",
            "Akşam Yemeği",
            "Ek Öğün"});
            this.cbArama.Location = new System.Drawing.Point(23, 95);
            this.cbArama.Name = "cbArama";
            this.cbArama.Size = new System.Drawing.Size(200, 23);
            this.cbArama.TabIndex = 1;
            // 
            // dtpOgunArama
            // 
            this.dtpOgunArama.Location = new System.Drawing.Point(23, 36);
            this.dtpOgunArama.Name = "dtpOgunArama";
            this.dtpOgunArama.Size = new System.Drawing.Size(200, 23);
            this.dtpOgunArama.TabIndex = 0;
            // 
            // dgvOgunRaporu
            // 
            this.dgvOgunRaporu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOgunRaporu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgunRaporu.Location = new System.Drawing.Point(340, 213);
            this.dgvOgunRaporu.Name = "dgvOgunRaporu";
            this.dgvOgunRaporu.RowTemplate.Height = 25;
            this.dgvOgunRaporu.Size = new System.Drawing.Size(661, 204);
            this.dgvOgunRaporu.TabIndex = 26;
            // 
            // lblTavsiye
            // 
            this.lblTavsiye.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTavsiye.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTavsiye.Location = new System.Drawing.Point(340, 431);
            this.lblTavsiye.Name = "lblTavsiye";
            this.lblTavsiye.Size = new System.Drawing.Size(661, 100);
            this.lblTavsiye.TabIndex = 28;
            // 
            // OgunKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1019, 551);
            this.Controls.Add(this.lblTavsiye);
            this.Controls.Add(this.dgvOgunRaporu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlOgun);
            this.Controls.Add(this.lbxBesinListesi);
            this.Controls.Add(this.grpBesinArama);
            this.Name = "OgunKayitForm";
            this.Text = "ÖĞÜN KAYITLARI";
            this.grpBesinArama.ResumeLayout(false);
            this.grpBesinArama.PerformLayout();
            this.pnlOgun.ResumeLayout(false);
            this.pnlOgun.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgunRaporu)).EndInit();
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
        private Panel pnlOgun;
        private DateTimePicker dtpOgunTarihi;
        private ComboBox cmbOgunler;
        private Label label4;
        private Label label1;
        private Button btnEkle;
        private Label lblGizliBesinID;
        private Label lblGizliOgunID;
        private Panel panel1;
        private Label label5;
        private Label label6;
        private Button btnOgunAra;
        private Label label7;
        private Label label8;
        private ComboBox cbArama;
        private DateTimePicker dtpOgunArama;
        private DataGridView dgvOgunRaporu;
        private Label lblTavsiye;
    }
}