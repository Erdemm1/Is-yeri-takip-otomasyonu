using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İş_yeri_Takip_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if (TxtKullaniciAdi.Text == "admin" && TxtSifre.Text == "admin")
            {
                Ana_Menu ana_Menu = new Ana_Menu();
                this.Hide();
                ana_Menu.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı");
            }
        }
    }
}
