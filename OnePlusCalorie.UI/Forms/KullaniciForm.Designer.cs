namespace OnePlusCalorie.UI.Forms
{
    partial class KullaniciForm
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
            this.grpKullaniciArama = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAramaKriteri = new System.Windows.Forms.ComboBox();
            this.txtAdAra = new System.Windows.Forms.TextBox();
            this.lbxKullaniciListesi = new System.Windows.Forms.ListBox();
            this.grpKullaniciListesi = new System.Windows.Forms.GroupBox();
            this.grpKullaniciArama.SuspendLayout();
            this.grpKullaniciListesi.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKullaniciArama
            // 
            this.grpKullaniciArama.Controls.Add(this.btnSil);
            this.grpKullaniciArama.Controls.Add(this.btnAra);
            this.grpKullaniciArama.Controls.Add(this.label3);
            this.grpKullaniciArama.Controls.Add(this.label2);
            this.grpKullaniciArama.Controls.Add(this.cmbAramaKriteri);
            this.grpKullaniciArama.Controls.Add(this.txtAdAra);
            this.grpKullaniciArama.ForeColor = System.Drawing.Color.White;
            this.grpKullaniciArama.Location = new System.Drawing.Point(88, 96);
            this.grpKullaniciArama.Name = "grpKullaniciArama";
            this.grpKullaniciArama.Size = new System.Drawing.Size(356, 376);
            this.grpKullaniciArama.TabIndex = 2;
            this.grpKullaniciArama.TabStop = false;
            this.grpKullaniciArama.Text = "Kullanıcı Arama";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(106)))));
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSil.Location = new System.Drawing.Point(35, 270);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(120, 47);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(106)))));
            this.btnAra.FlatAppearance.BorderSize = 0;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAra.Location = new System.Drawing.Point(199, 270);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(120, 47);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
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
            this.cmbAramaKriteri.Size = new System.Drawing.Size(298, 23);
            this.cmbAramaKriteri.TabIndex = 7;
            // 
            // txtAdAra
            // 
            this.txtAdAra.Location = new System.Drawing.Point(21, 102);
            this.txtAdAra.Name = "txtAdAra";
            this.txtAdAra.Size = new System.Drawing.Size(298, 23);
            this.txtAdAra.TabIndex = 6;
            // 
            // lbxKullaniciListesi
            // 
            this.lbxKullaniciListesi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbxKullaniciListesi.FormattingEnabled = true;
            this.lbxKullaniciListesi.ItemHeight = 15;
            this.lbxKullaniciListesi.Location = new System.Drawing.Point(6, 22);
            this.lbxKullaniciListesi.Name = "lbxKullaniciListesi";
            this.lbxKullaniciListesi.Size = new System.Drawing.Size(348, 349);
            this.lbxKullaniciListesi.TabIndex = 23;
            // 
            // grpKullaniciListesi
            // 
            this.grpKullaniciListesi.Controls.Add(this.lbxKullaniciListesi);
            this.grpKullaniciListesi.ForeColor = System.Drawing.Color.White;
            this.grpKullaniciListesi.Location = new System.Drawing.Point(499, 96);
            this.grpKullaniciListesi.Name = "grpKullaniciListesi";
            this.grpKullaniciListesi.Size = new System.Drawing.Size(360, 376);
            this.grpKullaniciListesi.TabIndex = 24;
            this.grpKullaniciListesi.TabStop = false;
            this.grpKullaniciListesi.Text = "Kullanıcı Listesi";
            // 
            // KullaniciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1019, 551);
            this.Controls.Add(this.grpKullaniciListesi);
            this.Controls.Add(this.grpKullaniciArama);
            this.Name = "KullaniciForm";
            this.Text = "KullaniciForm";
            this.grpKullaniciArama.ResumeLayout(false);
            this.grpKullaniciArama.PerformLayout();
            this.grpKullaniciListesi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpKullaniciArama;
        private Button btnAra;
        private Label label3;
        private Label label2;
        private ComboBox cmbAramaKriteri;
        private TextBox txtAdAra;
        private Button btnSil;
        private ListBox lbxKullaniciListesi;
        private GroupBox grpKullaniciListesi;
    }
}