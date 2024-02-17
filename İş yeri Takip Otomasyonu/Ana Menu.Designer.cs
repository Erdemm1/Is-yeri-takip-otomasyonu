namespace İş_yeri_Takip_Otomasyonu
{
    partial class Ana_Menu
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
            this.BtnMalzemeEkleForm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnFiyatGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMalzemeAra = new System.Windows.Forms.TextBox();
            this.BtnMalzemeSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnHareketler = new System.Windows.Forms.Button();
            this.BtnSatısYap = new System.Windows.Forms.Button();
            this.TxtMiktar = new System.Windows.Forms.TextBox();
            this.TxtStokYenile = new System.Windows.Forms.TextBox();
            this.BtnAl = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnMalzemeEkleForm
            // 
            this.BtnMalzemeEkleForm.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMalzemeEkleForm.Location = new System.Drawing.Point(32, 55);
            this.BtnMalzemeEkleForm.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMalzemeEkleForm.Name = "BtnMalzemeEkleForm";
            this.BtnMalzemeEkleForm.Size = new System.Drawing.Size(246, 33);
            this.BtnMalzemeEkleForm.TabIndex = 0;
            this.BtnMalzemeEkleForm.Text = "Malzeme Ekle";
            this.BtnMalzemeEkleForm.UseVisualStyleBackColor = true;
            this.BtnMalzemeEkleForm.Click += new System.EventHandler(this.BtnMalzemeEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(754, 314);
            this.dataGridView1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(285, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 343);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Malzemeler";
            // 
            // BtnFiyatGuncelle
            // 
            this.BtnFiyatGuncelle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnFiyatGuncelle.Location = new System.Drawing.Point(32, 96);
            this.BtnFiyatGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFiyatGuncelle.Name = "BtnFiyatGuncelle";
            this.BtnFiyatGuncelle.Size = new System.Drawing.Size(246, 33);
            this.BtnFiyatGuncelle.TabIndex = 10;
            this.BtnFiyatGuncelle.Text = "Malzeme Fiyat Guncelle";
            this.BtnFiyatGuncelle.UseVisualStyleBackColor = true;
            this.BtnFiyatGuncelle.Click += new System.EventHandler(this.BtnFiyatGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Malzeme Ara";
            // 
            // TxtMalzemeAra
            // 
            this.TxtMalzemeAra.Location = new System.Drawing.Point(462, 12);
            this.TxtMalzemeAra.Name = "TxtMalzemeAra";
            this.TxtMalzemeAra.Size = new System.Drawing.Size(210, 30);
            this.TxtMalzemeAra.TabIndex = 12;
            this.TxtMalzemeAra.TextChanged += new System.EventHandler(this.TxtMalzemeAra_TextChanged);
            // 
            // BtnMalzemeSil
            // 
            this.BtnMalzemeSil.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMalzemeSil.Location = new System.Drawing.Point(35, 137);
            this.BtnMalzemeSil.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMalzemeSil.Name = "BtnMalzemeSil";
            this.BtnMalzemeSil.Size = new System.Drawing.Size(246, 33);
            this.BtnMalzemeSil.TabIndex = 13;
            this.BtnMalzemeSil.Text = "Malzeme Sil";
            this.BtnMalzemeSil.UseVisualStyleBackColor = true;
            this.BtnMalzemeSil.Click += new System.EventHandler(this.BtnMalzemeSil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kasa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "0";
            // 
            // BtnHareketler
            // 
            this.BtnHareketler.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHareketler.Location = new System.Drawing.Point(32, 178);
            this.BtnHareketler.Margin = new System.Windows.Forms.Padding(4);
            this.BtnHareketler.Name = "BtnHareketler";
            this.BtnHareketler.Size = new System.Drawing.Size(246, 33);
            this.BtnHareketler.TabIndex = 16;
            this.BtnHareketler.Text = "Satılan Malzeme Kayıt";
            this.BtnHareketler.UseVisualStyleBackColor = true;
            this.BtnHareketler.Click += new System.EventHandler(this.BtnHareketler_Click);
            // 
            // BtnSatısYap
            // 
            this.BtnSatısYap.Location = new System.Drawing.Point(16, 270);
            this.BtnSatısYap.Name = "BtnSatısYap";
            this.BtnSatısYap.Size = new System.Drawing.Size(114, 31);
            this.BtnSatısYap.TabIndex = 17;
            this.BtnSatısYap.Text = "Satış Yap";
            this.BtnSatısYap.UseVisualStyleBackColor = true;
            this.BtnSatısYap.Click += new System.EventHandler(this.BtnSatısYap_Click);
            // 
            // TxtMiktar
            // 
            this.TxtMiktar.Location = new System.Drawing.Point(136, 271);
            this.TxtMiktar.Name = "TxtMiktar";
            this.TxtMiktar.Size = new System.Drawing.Size(146, 30);
            this.TxtMiktar.TabIndex = 18;
            // 
            // TxtStokYenile
            // 
            this.TxtStokYenile.Location = new System.Drawing.Point(137, 319);
            this.TxtStokYenile.Name = "TxtStokYenile";
            this.TxtStokYenile.Size = new System.Drawing.Size(146, 30);
            this.TxtStokYenile.TabIndex = 20;
            // 
            // BtnAl
            // 
            this.BtnAl.Location = new System.Drawing.Point(17, 318);
            this.BtnAl.Name = "BtnAl";
            this.BtnAl.Size = new System.Drawing.Size(114, 31);
            this.BtnAl.TabIndex = 19;
            this.BtnAl.Text = "Alım Yap";
            this.BtnAl.UseVisualStyleBackColor = true;
            this.BtnAl.Click += new System.EventHandler(this.BtnAl_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(32, 219);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 33);
            this.button1.TabIndex = 21;
            this.button1.Text = "Programı Sonlandır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ana_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1051, 435);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtStokYenile);
            this.Controls.Add(this.BtnAl);
            this.Controls.Add(this.TxtMiktar);
            this.Controls.Add(this.BtnSatısYap);
            this.Controls.Add(this.BtnHareketler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnMalzemeSil);
            this.Controls.Add(this.TxtMalzemeAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnFiyatGuncelle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnMalzemeEkleForm);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ana_Menu";
            this.Text = "Ana_Menu";
            this.Load += new System.EventHandler(this.Ana_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnMalzemeEkleForm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnFiyatGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMalzemeAra;
        private System.Windows.Forms.Button BtnMalzemeSil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnHareketler;
        private System.Windows.Forms.Button BtnSatısYap;
        private System.Windows.Forms.TextBox TxtMiktar;
        private System.Windows.Forms.TextBox TxtStokYenile;
        private System.Windows.Forms.Button BtnAl;
        private System.Windows.Forms.Button button1;
    }
}