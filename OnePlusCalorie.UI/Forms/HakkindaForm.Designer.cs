﻿namespace OnePlusCalorie.UI.Forms
{
    partial class HakkindaForm
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
            this.txtHakkinda = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHakkinda
            // 
            this.txtHakkinda.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtHakkinda.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtHakkinda.Location = new System.Drawing.Point(218, 189);
            this.txtHakkinda.Multiline = true;
            this.txtHakkinda.Name = "txtHakkinda";
            this.txtHakkinda.Size = new System.Drawing.Size(591, 283);
            this.txtHakkinda.TabIndex = 0;
            this.txtHakkinda.Text = "     Bu proje Grup ŞİMŞEK tarafından geliştirilmiştir.\r\n\r\n\r\n\r\n                   " +
    "         Akın Özçelik\r\n                         İrem Ceren Bulut\r\n              " +
    "             Zeynep Gül Işık";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OnePlusCalorie.UI.Properties.Resources.LogoOnePlus;
            this.pictureBox1.Location = new System.Drawing.Point(330, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(530, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "OnePlusCalorie";
            // 
            // HakkindaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1019, 551);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtHakkinda);
            this.Name = "HakkindaForm";
            this.Text = "HAKKINDA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtHakkinda;
        private PictureBox pictureBox1;
        private Label label1;
    }
}