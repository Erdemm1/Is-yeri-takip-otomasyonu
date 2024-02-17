using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace İş_yeri_Takip_Otomasyonu
{
    public partial class Ana_Menu : Form
    {
        public Ana_Menu()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-48R5JDT\SQLEXPRESS01;Initial Catalog=DBNalburMalzemeTakip;Integrated Security=True");

        private void Ana_Menu_Load(object sender, EventArgs e)
        {
            HareketleriTopla();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select AD,ALISFIYATI,SATISFIYATI,STOK,USDALIS,USDSATIS,TARIH from TBLMalzeme", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

            // Form yüklendiğinde hareketleri topla ve kasa tablosunu güncelle
            HareketleriTopla();

        }
        private void BtnMalzemeEkle_Click(object sender, EventArgs e)
        {
            Malzeme_Ekle malzeme_Ekle = new Malzeme_Ekle();
            this.Hide();
            malzeme_Ekle.Show();
        }
        private void BtnFiyatGuncelle_Click(object sender, EventArgs e)
        {
            FiyatGuncelle fiyatGuncelle = new FiyatGuncelle();
            this.Hide();
            fiyatGuncelle.Show();
        }
        private void TxtMalzemeAra_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();

            try
            {
                SqlCommand komut = new SqlCommand("SELECT * FROM TBLMalzeme WHERE AD LIKE @p1", baglanti);
                komut.Parameters.AddWithValue("@p1", "%" + TxtMalzemeAra.Text + "%");

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void BtnMalzemeSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                // Seçilen hücrenin bulunduğu satırın indeksi
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

                // Seçilen hücrenin "AD" sütunundaki değeri
                string malzemeAdi = dataGridView1.Rows[rowIndex].Cells["AD"].Value.ToString();

                if (MessageBox.Show(malzemeAdi + " adlı malzemeyi silmek istediğinize emin misiniz?", "Malzeme Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (baglanti.State == ConnectionState.Closed)
                        {
                            baglanti.Open();
                        }

                        SqlCommand komut = new SqlCommand("DELETE FROM TBLMalzeme WHERE AD = @p1", baglanti);
                        komut.Parameters.AddWithValue("@p1", malzemeAdi);

                        komut.ExecuteNonQuery();
                        MessageBox.Show("Malzeme silindi.");

                        // Yeniden yükleme işlemi
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBLMalzeme", baglanti);
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata oluştu: " + ex.Message);
                    }
                    finally
                    {
                        baglanti.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz malzemeyi seçin.");
            }
        }
        private void BtnHareketler_Click(object sender, EventArgs e)
        {
            Hareketler hareketler = new Hareketler();
            this.Hide();
            hareketler.Show();
        }

        private void BtnSatısYap_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                string malzemeAdi = dataGridView1.Rows[rowIndex].Cells["AD"].Value.ToString();

                // Satış miktarını TextBox'tan alın
                if (int.TryParse(TxtMiktar.Text, out int satisMiktari))
                {
                    // Seçili malzemenin stok miktarından satış miktarını çıkarın
                    int stokMiktari = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["STOK"].Value);
                    if (satisMiktari > stokMiktari)
                    {
                        MessageBox.Show("Stok yetersiz.");
                        return;
                    }

                    // Seçili malzemenin satış fiyatından alış fiyatını çıkartıp, miktar ile çarparak toplam tutarı hesapla
                    double satisFiyati = Convert.ToDouble(dataGridView1.Rows[rowIndex].Cells["SATISFIYATI"].Value);
                    double alisFiyati = Convert.ToDouble(dataGridView1.Rows[rowIndex].Cells["ALISFIYATI"].Value);
                    double toplamTutar = satisFiyati  * satisMiktari;

                    // Güncellenmiş stok miktarını veritabanına kaydedin
                    try
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("UPDATE TBLMalzeme SET STOK = STOK - @satisMiktari WHERE AD = @malzemeAdi", baglanti);
                        komut.Parameters.AddWithValue("@satisMiktari", satisMiktari);
                        komut.Parameters.AddWithValue("@malzemeAdi", malzemeAdi);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Satış işlemi gerçekleştirildi.");


                        // Satış hareketini TBLHAREKETLER tablosuna ekle
                        baglanti.Open();
                        SqlCommand hareketKomut = new SqlCommand("INSERT INTO TBLHAREKETLER (AD, STOK, ALISFIYATI, SATISFIYATI, KAR, TARIH) VALUES (@malzemeAdi, @satisMiktari, @alisFiyati, @satisFiyati, @kar, @tarih)", baglanti);
                        hareketKomut.Parameters.AddWithValue("@malzemeAdi", malzemeAdi);
                        hareketKomut.Parameters.AddWithValue("@satisMiktari", satisMiktari);
                        hareketKomut.Parameters.AddWithValue("@alisFiyati", alisFiyati);
                        hareketKomut.Parameters.AddWithValue("@satisFiyati", satisFiyati);
                        hareketKomut.Parameters.AddWithValue("@kar", toplamTutar);
                        hareketKomut.Parameters.AddWithValue("@tarih", DateTime.Now);
                        hareketKomut.ExecuteNonQuery();
                        baglanti.Close();

                        YenidenYukle();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata oluştu: " + ex.Message);
                    }
                    finally
                    {
                        // Bağlantıyı kapatın
                        baglanti.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Geçersiz miktar girişi.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen satış yapmak istediğiniz malzemeyi seçin.");
            }
        }
        private void YenidenYukle()
        {
            HareketleriTopla();
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                SqlCommand komut = new SqlCommand("select AD,ALISFIYATI,SATISFIYATI,STOK,USDALIS,USDSATIS,TARIH from TBLMalzeme", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
                baglanti.Close();
        }
        private void HareketleriTopla()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                SqlCommand komut = new SqlCommand("SELECT SUM(KAR)+SUM(GIDER) FROM TBLHAREKETLER", baglanti);
                object result = komut.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    decimal toplamKar = Convert.ToDecimal(result);
                    label3.Text = toplamKar.ToString("C"); // "C" formatı Türk Lirası cinsinden gösterir.
                }
                else
                {
                    label3.Text = "Toplam Kar: 0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            baglanti.Close();
        }

        private void BtnAl_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxtStokYenile.Text, out int stokYenileMiktari))
            {
                // Seçili hücrenin bulunduğu satırın indeksi
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

                // Seçili hücrenin "AD" sütunundaki değeri
                string malzemeAdi = dataGridView1.Rows[rowIndex].Cells["AD"].Value.ToString();

                // Seçili hücrenin "ALISFIYATI" sütunundaki değeri
                decimal alisFiyati = Convert.ToDecimal(dataGridView1.Rows[rowIndex].Cells["ALISFIYATI"].Value);

                // Toplam tutarı hesapla
                decimal toplamTutar = alisFiyati * Convert.ToDecimal(TxtStokYenile.Text);

                // Gider hesapla
                decimal gider = -toplamTutar;

                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }

                    // TBLHAREKETLER tablosuna kayıt ekle
                    SqlCommand hareketKomut = new SqlCommand("INSERT INTO TBLHAREKETLER (AD, STOK, ALISFIYATI, SATISFIYATI, KAR, TARIH, GIDER) VALUES (@malzemeAdi, @stokYenileMiktari, @alisFiyati, 0, 0, @tarih, @gider)", baglanti);
                    hareketKomut.Parameters.AddWithValue("@malzemeAdi", malzemeAdi);
                    hareketKomut.Parameters.AddWithValue("@stokYenileMiktari", stokYenileMiktari);
                    hareketKomut.Parameters.AddWithValue("@alisFiyati", alisFiyati);
                    hareketKomut.Parameters.AddWithValue("@tarih", DateTime.Now);
                    hareketKomut.Parameters.AddWithValue("@gider", gider);
                    hareketKomut.ExecuteNonQuery();

                    MessageBox.Show("Alım işlemi gerçekleştirildi.");

                    // Stokları güncelle
                    SqlCommand stokGuncelleKomut = new SqlCommand("UPDATE TBLMalzeme SET STOK = STOK + @stokYenileMiktari WHERE AD = @malzemeAdi", baglanti);
                    stokGuncelleKomut.Parameters.AddWithValue("@stokYenileMiktari", stokYenileMiktari);
                    stokGuncelleKomut.Parameters.AddWithValue("@malzemeAdi", malzemeAdi);
                    stokGuncelleKomut.ExecuteNonQuery();

                    MessageBox.Show("Stok güncellendi.");

                    YenidenYukle();
                    HareketleriTopla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Geçersiz miktar girişi.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
