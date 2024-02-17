namespace İş_yeri_Takip_Otomasyonu
{
    partial class Malzeme_Ekle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtMalzemeAdi = new System.Windows.Forms.TextBox();
            this.TxtAlisFiyati = new System.Windows.Forms.TextBox();
            this.TxtSatisFiyati = new System.Windows.Forms.TextBox();
            this.TxtStok = new System.Windows.Forms.TextBox();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.TxtUSDAlis = new System.Windows.Forms.TextBox();
            this.TxtUSDSatis = new System.Windows.Forms.TextBox();
            this.BtnMalzemeEkle = new System.Windows.Forms.Button();
            this.LblUsdAl = new System.Windows.Forms.Label();
            this.LblUsdSat = new System.Windows.Forms.Label();
            this.BtnAnaMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Malzeme Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stok:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alış Fiyatı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Satış Fiyatı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 221);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alındığı Tarih:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "USD Alış:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "USD Satış:";
            // 
            // TxtMalzemeAdi
            // 
            this.TxtMalzemeAdi.Location = new System.Drawing.Point(178, 12);
            this.TxtMalzemeAdi.Name = "TxtMalzemeAdi";
            this.TxtMalzemeAdi.Size = new System.Drawing.Size(163, 30);
            this.TxtMalzemeAdi.TabIndex = 7;
            // 
            // TxtAlisFiyati
            // 
            this.TxtAlisFiyati.Location = new System.Drawing.Point(178, 48);
            this.TxtAlisFiyati.Name = "TxtAlisFiyati";
            this.TxtAlisFiyati.Size = new System.Drawing.Size(163, 30);
            this.TxtAlisFiyati.TabIndex = 8;
            this.TxtAlisFiyati.TextChanged += new System.EventHandler(this.TxtAlisFiyati_TextChanged);
            // 
            // TxtSatisFiyati
            // 
            this.TxtSatisFiyati.Location = new System.Drawing.Point(178, 81);
            this.TxtSatisFiyati.Name = "TxtSatisFiyati";
            this.TxtSatisFiyati.Size = new System.Drawing.Size(163, 30);
            this.TxtSatisFiyati.TabIndex = 9;
            this.TxtSatisFiyati.TextChanged += new System.EventHandler(this.TxtSatisFiyati_TextChanged);
            // 
            // TxtStok
            // 
            this.TxtStok.Location = new System.Drawing.Point(178, 117);
            this.TxtStok.Name = "TxtStok";
            this.TxtStok.Size = new System.Drawing.Size(162, 30);
            this.TxtStok.TabIndex = 10;
            this.TxtStok.TextChanged += new System.EventHandler(this.TxtStok_TextChanged);
            // 
            // MskTarih
            // 
            this.MskTarih.Location = new System.Drawing.Point(178, 222);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(163, 30);
            this.MskTarih.TabIndex = 11;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            this.MskTarih.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MskTarih_MaskInputRejected);
            // 
            // TxtUSDAlis
            // 
            this.TxtUSDAlis.Enabled = false;
            this.TxtUSDAlis.Location = new System.Drawing.Point(178, 152);
            this.TxtUSDAlis.Name = "TxtUSDAlis";
            this.TxtUSDAlis.Size = new System.Drawing.Size(163, 30);
            this.TxtUSDAlis.TabIndex = 12;
            this.TxtUSDAlis.Text = "0";
            // 
            // TxtUSDSatis
            // 
            this.TxtUSDSatis.Enabled = false;
            this.TxtUSDSatis.Location = new System.Drawing.Point(178, 185);
            this.TxtUSDSatis.Name = "TxtUSDSatis";
            this.TxtUSDSatis.Size = new System.Drawing.Size(163, 30);
            this.TxtUSDSatis.TabIndex = 13;
            this.TxtUSDSatis.Text = "0";
            // 
            // BtnMalzemeEkle
            // 
            this.BtnMalzemeEkle.Location = new System.Drawing.Point(95, 270);
            this.BtnMalzemeEkle.Name = "BtnMalzemeEkle";
            this.BtnMalzemeEkle.Size = new System.Drawing.Size(160, 42);
            this.BtnMalzemeEkle.TabIndex = 14;
            this.BtnMalzemeEkle.Text = "Ekle";
            this.BtnMalzemeEkle.UseVisualStyleBackColor = true;
            this.BtnMalzemeEkle.Click += new System.EventHandler(this.BtnMalzemeEkle_Click);
            // 
            // LblUsdAl
            // 
            this.LblUsdAl.AutoSize = true;
            this.LblUsdAl.Location = new System.Drawing.Point(347, 155);
            this.LblUsdAl.Name = "LblUsdAl";
            this.LblUsdAl.Size = new System.Drawing.Size(65, 24);
            this.LblUsdAl.TabIndex = 15;
            this.LblUsdAl.Text = "label8";
            this.LblUsdAl.Visible = false;
            // 
            // LblUsdSat
            // 
            this.LblUsdSat.AutoSize = true;
            this.LblUsdSat.Location = new System.Drawing.Point(348, 185);
            this.LblUsdSat.Name = "LblUsdSat";
            this.LblUsdSat.Size = new System.Drawing.Size(64, 24);
            this.LblUsdSat.TabIndex = 16;
            this.LblUsdSat.Text = "label9";
            this.LblUsdSat.Visible = false;
            // 
            // BtnAnaMenu
            // 
            this.BtnAnaMenu.Location = new System.Drawing.Point(261, 270);
            this.BtnAnaMenu.Name = "BtnAnaMenu";
            this.BtnAnaMenu.Size = new System.Drawing.Size(160, 42);
            this.BtnAnaMenu.TabIndex = 17;
            this.BtnAnaMenu.Text = "Ana Menü";
            this.BtnAnaMenu.UseVisualStyleBackColor = true;
            this.BtnAnaMenu.Click += new System.EventHandler(this.BtnAnaMenu_Click);
            // 
            // Malzeme_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(548, 380);
            this.Controls.Add(this.BtnAnaMenu);
            this.Controls.Add(this.LblUsdSat);
            this.Controls.Add(this.LblUsdAl);
            this.Controls.Add(this.BtnMalzemeEkle);
            this.Controls.Add(this.TxtUSDSatis);
            this.Controls.Add(this.TxtUSDAlis);
            this.Controls.Add(this.MskTarih);
            this.Controls.Add(this.TxtStok);
            this.Controls.Add(this.TxtSatisFiyati);
            this.Controls.Add(this.TxtAlisFiyati);
            this.Controls.Add(this.TxtMalzemeAdi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Malzeme_Ekle";
            this.Text = "Malzeme_Ekle";
            this.Load += new System.EventHandler(this.Malzeme_Ekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtMalzemeAdi;
        private System.Windows.Forms.TextBox TxtAlisFiyati;
        private System.Windows.Forms.TextBox TxtSatisFiyati;
        private System.Windows.Forms.TextBox TxtStok;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private System.Windows.Forms.TextBox TxtUSDAlis;
        private System.Windows.Forms.TextBox TxtUSDSatis;
        private System.Windows.Forms.Button BtnMalzemeEkle;
        private System.Windows.Forms.Label LblUsdAl;
        private System.Windows.Forms.Label LblUsdSat;
        private System.Windows.Forms.Button BtnAnaMenu;
    }
}