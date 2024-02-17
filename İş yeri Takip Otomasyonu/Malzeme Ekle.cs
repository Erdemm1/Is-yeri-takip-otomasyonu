using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.Sql;
using System.Data.SqlClient;

namespace İş_yeri_Takip_Otomasyonu
{
    public partial class Malzeme_Ekle : Form
    {
        public Malzeme_Ekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-48R5JDT\SQLEXPRESS01;Initial Catalog=DBNalburMalzemeTakip;Integrated Security=True");
        private void BtnMalzemeEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            try
            {
                SqlCommand komut = new SqlCommand("INSERT INTO TBLMalzeme (AD, ALISFIYATI, SATISFIYATI, STOK, USDALIS, USDSATIS, TARIH) " +
                                                  "VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", baglanti);

                komut.Parameters.AddWithValue("@p1", TxtMalzemeAdi.Text);
                komut.Parameters.AddWithValue("@p2", Convert.ToDouble(TxtAlisFiyati.Text));
                komut.Parameters.AddWithValue("@p3", Convert.ToDouble(TxtSatisFiyati.Text));
                komut.Parameters.AddWithValue("@p4", int.Parse(TxtStok.Text));
                komut.Parameters.AddWithValue("@p5", TxtUSDAlis.Text);
                komut.Parameters.AddWithValue("@p6", TxtUSDSatis.Text);
                

                // MskTarih.Text'i uygun bir tarih formatına dönüştürün
                if (DateTime.TryParse(MskTarih.Text, out DateTime tarih))
                {
                    komut.Parameters.AddWithValue("@p7", tarih);
                }
                else
                {
                    MessageBox.Show("Geçersiz Tarih Formatı");
                    return; // Hata durumunda işlemi sonlandır
                }

                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                TxtMalzemeAdi.Text = "";
                TxtAlisFiyati.Text = "";
                TxtSatisFiyati.Text = "";
                TxtStok.Text = "";
                TxtUSDAlis.Text = "";
                TxtUSDSatis.Text = "";
                MskTarih.Text = "";
                baglanti.Close();

            }
        }




        private void MskTarih_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void TxtAlisFiyati_TextChanged(object sender, EventArgs e)
        {
            UsdAlisHesaplaVeGuncelle();
        }
        private void TxtStok_TextChanged(object sender, EventArgs e)
        {
        }
        private void TxtSatisFiyati_TextChanged(object sender, EventArgs e)
        {
            UsdSatisHesaplaVeGuncelle();
        }
        private void Malzeme_Ekle_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);
            string dolarAlis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            LblUsdSat.Text = dolarAlis;
            string dolarSatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            LblUsdAl.Text = dolarSatis;
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
