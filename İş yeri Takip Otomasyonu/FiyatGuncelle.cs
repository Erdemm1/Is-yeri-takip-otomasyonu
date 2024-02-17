using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace İş_yeri_Takip_Otomasyonu
{
    public partial class FiyatGuncelle : Form
    {
        public FiyatGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-48R5JDT\SQLEXPRESS01;Initial Catalog=DBNalburMalzemeTakip;Integrated Security=True");

        private void FiyatGuncelle_Load(object sender, EventArgs e)
        {

            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);
            string dolarAlis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            LblUsdSat.Text = dolarAlis;
            string dolarSatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            LblUsdAl.Text = dolarSatis;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select AD,ALISFIYATI,SATISFIYATI,STOK,USDALIS,USDSATIS,TARIH from TBLMalzeme", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void TxtMalzemeAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-48R5JDT\SQLEXPRESS01;Initial Catalog=DBNalburMalzemeTakip;Integrated Security=True"))
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("SELECT * FROM TBLMalzeme WHERE AD LIKE @p1", baglanti);
                    komut.Parameters.AddWithValue("@p1", "%" + TxtMalzemeAra.Text + "%");

                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Seçilen satırdaki "AD" değerini alıp TxtAd.Text'e yazma
                TxtMalzemeAdi.Text = row.Cells["AD"].Value.ToString();
                TxtAlisFiyati.Text = row.Cells["ALISFIYATI"].Value.ToString();
                TxtSatisFiyati.Text = row.Cells["SATISFIYATI"].Value.ToString();
                TxtStok.Text = row.Cells["STOK"].Value.ToString();
                TxtUSDAlis.Text = row.Cells["USDALIS"].Value.ToString();
                TxtUSDSatis.Text = row.Cells["USDSATIS"].Value.ToString();
                MskTarih.Text = row.Cells["TARIH"].Value.ToString();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-48R5JDT\SQLEXPRESS01;Initial Catalog=DBNalburMalzemeTakip;Integrated Security=True"))
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("UPDATE TBLMalzeme SET ALISFIYATI = @alisFiyati, SATISFIYATI = @satisFiyati, STOK = @stok, USDALIS = @usdAlis, USDSATIS = @usdSatis, TARIH = @tarih WHERE AD = @ad", baglanti);

                    komut.Parameters.AddWithValue("@ad", TxtMalzemeAdi.Text);
                    komut.Parameters.AddWithValue("@alisFiyati", Convert.ToDouble(TxtAlisFiyati.Text));
                    komut.Parameters.AddWithValue("@satisFiyati", Convert.ToDouble(TxtSatisFiyati.Text));
                    komut.Parameters.AddWithValue("@stok", int.Parse(TxtStok.Text));
                    komut.Parameters.AddWithValue("@usdAlis", TxtUSDAlis.Text);
                    komut.Parameters.AddWithValue("@usdSatis", TxtUSDSatis.Text);
                    if (DateTime.TryParse(MskTarih.Text, out DateTime tarih))
                    {
                        komut.Parameters.AddWithValue("@tarih", tarih);
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz Tarih Formatı");
                        return;
                    }

                    komut.ExecuteNonQuery();
                    FiyatGuncelle_Load(sender, e);
                    MessageBox.Show("Malzeme Güncellendi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
        private void TxtAlisFiyati_TextChanged(object sender, EventArgs e)
        {
            UsdAlisHesaplaVeGuncelle();
        }
        private void TxtSatisFiyati_TextChanged(object sender, EventArgs e)
        {
            UsdSatisHesaplaVeGuncelle();
        }

        private void UsdSatisHesaplaVeGuncelle()
        {
            if (double.TryParse(TxtSatisFiyati.Text, out double satisFiyati))
            {
                double usdSatis = satisFiyati / Convert.ToDouble(LblUsdAl.Text, CultureInfo.InvariantCulture);
                TxtUSDSatis.Text = usdSatis.ToString("0.000", CultureInfo.InvariantCulture);
            }
            else
            {
                TxtUSDSatis.Text = "Geçersiz Giriş";
            }
        }
        private void UsdAlisHesaplaVeGuncelle()
        {
            if (double.TryParse(TxtAlisFiyati.Text, out double alisFiyati))
            {
                double usdAlis = alisFiyati / Convert.ToDouble(LblUsdSat.Text, CultureInfo.InvariantCulture);
                TxtUSDAlis.Text = usdAlis.ToString("0.000", CultureInfo.InvariantCulture);
            }
            else
            {
                TxtUSDAlis.Text = "Geçersiz Giriş";
            }
        }

        private void BtnAnaMenu_Click(object sender, EventArgs e)
        {
            Ana_Menu ana_Menu = new Ana_Menu();
            this.Hide();
            ana_Menu.Show();
        }

        
    }
}
