namespace İş_yeri_Takip_Otomasyonu
{
    partial class FiyatGuncelle
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
            this.LblUsdSat = new System.Windows.Forms.Label();
            this.LblUsdAl = new System.Windows.Forms.Label();
            this.TxtUSDSatis = new System.Windows.Forms.TextBox();
            this.TxtUSDAlis = new System.Windows.Forms.TextBox();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.TxtStok = new System.Windows.Forms.TextBox();
            this.TxtSatisFiyati = new System.Windows.Forms.TextBox();
            this.TxtAlisFiyati = new System.Windows.Forms.TextBox();
            this.TxtMalzemeAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMalzemeAra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnAnaMenu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblUsdSat
            // 
            this.LblUsdSat.AutoSize = true;
            this.LblUsdSat.Location = new System.Drawing.Point(321, 185);
            this.LblUsdSat.Name = "LblUsdSat";
            this.LblUsdSat.Size = new System.Drawing.Size(64, 24);
            this.LblUsdSat.TabIndex = 32;
            this.LblUsdSat.Text = "label9";
            this.LblUsdSat.Visible = false;
            // 
            // LblUsdAl
            // 
            this.LblUsdAl.AutoSize = true;
            this.LblUsdAl.Location = new System.Drawing.Point(320, 155);
            this.LblUsdAl.Name = "LblUsdAl";
            this.LblUsdAl.Size = new System.Drawing.Size(65, 24);
            this.LblUsdAl.TabIndex = 31;
            this.LblUsdAl.Text = "label8";
            this.LblUsdAl.Visible = false;
            // 
            // TxtUSDSatis
            // 
            this.TxtUSDSatis.Enabled = false;
            this.TxtUSDSatis.Location = new System.Drawing.Point(151, 185);
            this.TxtUSDSatis.Name = "TxtUSDSatis";
            this.TxtUSDSatis.Size = new System.Drawing.Size(163, 30);
            this.TxtUSDSatis.TabIndex = 30;
            this.TxtUSDSatis.Text = "0";
            // 
            // TxtUSDAlis
            // 
            this.TxtUSDAlis.Enabled = false;
            this.TxtUSDAlis.Location = new System.Drawing.Point(151, 152);
            this.TxtUSDAlis.Name = "TxtUSDAlis";
            this.TxtUSDAlis.Size = new System.Drawing.Size(163, 30);
            this.TxtUSDAlis.TabIndex = 29;
            this.TxtUSDAlis.Text = "0";
            // 
            // MskTarih
            // 
            this.MskTarih.Location = new System.Drawing.Point(151, 222);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(163, 30);
            this.MskTarih.TabIndex = 28;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // TxtStok
            // 
            this.TxtStok.Location = new System.Drawing.Point(151, 117);
            this.TxtStok.Name = "TxtStok";
            this.TxtStok.Size = new System.Drawing.Size(162, 30);
            this.TxtStok.TabIndex = 27;
            // 
            // TxtSatisFiyati
            // 
            this.TxtSatisFiyati.Location = new System.Drawing.Point(151, 81);
            this.TxtSatisFiyati.Name = "TxtSatisFiyati";
            this.TxtSatisFiyati.Size = new System.Drawing.Size(163, 30);
            this.TxtSatisFiyati.TabIndex = 26;
            this.TxtSatisFiyati.TextChanged += new System.EventHandler(this.TxtSatisFiyati_TextChanged);
            // 
            // TxtAlisFiyati
            // 
            this.TxtAlisFiyati.Location = new System.Drawing.Point(151, 48);
            this.TxtAlisFiyati.Name = "TxtAlisFiyati";
            this.TxtAlisFiyati.Size = new System.Drawing.Size(163, 30);
            this.TxtAlisFiyati.TabIndex = 25;
            this.TxtAlisFiyati.TextChanged += new System.EventHandler(this.TxtAlisFiyati_TextChanged);
            // 
            // TxtMalzemeAdi
            // 
            this.TxtMalzemeAdi.Enabled = false;
            this.TxtMalzemeAdi.Location = new System.Drawing.Point(151, 12);
            this.TxtMalzemeAdi.Name = "TxtMalzemeAdi";
            this.TxtMalzemeAdi.Size = new System.Drawing.Size(163, 30);
            this.TxtMalzemeAdi.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 24);
            this.label7.TabIndex = 23;
            this.label7.Text = "USD Satış:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "USD Alış:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 221);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Alındığı Tarih:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Satış Fiyatı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Alış Fiyatı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Stok:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Malzeme Adı:";
            // 
            // TxtMalzemeAra
            // 
            this.TxtMalzemeAra.Location = new System.Drawing.Point(532, 6);
            this.TxtMalzemeAra.Name = "TxtMalzemeAra";
            this.TxtMalzemeAra.Size = new System.Drawing.Size(212, 30);
            this.TxtMalzemeAra.TabIndex = 35;
            this.TxtMalzemeAra.TextChanged += new System.EventHandler(this.TxtMalzemeAra_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 24);
            this.label8.TabIndex = 34;
            this.label8.Text = "Malzeme Ara";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(326, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 398);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Malzemeler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(551, 369);
            this.dataGridView1.TabIndex = 8;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(151, 258);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(162, 46);
            this.BtnGuncelle.TabIndex = 36;
            this.BtnGuncelle.Text = "Guncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnAnaMenu
            // 
            this.BtnAnaMenu.Location = new System.Drawing.Point(151, 310);
            this.BtnAnaMenu.Name = "BtnAnaMenu";
            this.BtnAnaMenu.Size = new System.Drawing.Size(162, 46);
            this.BtnAnaMenu.TabIndex = 37;
            this.BtnAnaMenu.Text = "Ana Menü";
            this.BtnAnaMenu.UseVisualStyleBackColor = true;
            this.BtnAnaMenu.Click += new System.EventHandler(this.BtnAnaMenu_Click);
            // 
            // FiyatGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1120, 599);
            this.Controls.Add(this.BtnAnaMenu);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.TxtMalzemeAra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblUsdSat);
            this.Controls.Add(this.LblUsdAl);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FiyatGuncelle";
            this.Text = "FiyatGuncelle";
            this.Load += new System.EventHandler(this.FiyatGuncelle_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUsdSat;
        private System.Windows.Forms.Label LblUsdAl;
        private System.Windows.Forms.TextBox TxtUSDSatis;
        private System.Windows.Forms.TextBox TxtUSDAlis;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private System.Windows.Forms.TextBox TxtStok;
        private System.Windows.Forms.TextBox TxtSatisFiyati;
        private System.Windows.Forms.TextBox TxtAlisFiyati;
        private System.Windows.Forms.TextBox TxtMalzemeAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMalzemeAra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnAnaMenu;
    }
}