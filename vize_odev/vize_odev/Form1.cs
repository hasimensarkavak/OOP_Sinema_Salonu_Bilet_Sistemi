using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace vize_odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const string FILE_NAME = "sinema.txt";

        public Gosterim secilenGosterim = new Gosterim(); //Gösterimleri ayrı ayrı göstermek için ayrı ayrı tanımladım
        public Gosterim gosterim1= new Gosterim();
        public Gosterim gosterim2 = new Gosterim();
        public Gosterim gosterim3 = new Gosterim();

        public void EkranTemizle() // ekran temizleme fonk
        {
            salonPanel.Controls.Clear();
            textBox1.Clear();
            textBox2.Clear();
            maskedTextBox1.Clear();
            salonBox.Text = "";
            indirimKoduBox.Clear();
            checkBox1.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            indirimKoduBox.Enabled = false;
            Dosya dosya = new Dosya(FILE_NAME);
            dosya.DosyaKontrol();
        }
        private void salonBox_SelectedIndexChanged_1(object sender, EventArgs e) //gösterim seçimi
        {
            
            if (salonBox.SelectedItem.ToString() == "Salon 1, Avangers, 12:30, 9 Haziran")
            {
                gosterim1.KoltuklariAl(FILE_NAME,"1");
                gosterim1.filmAd = "Avangers";
                gosterim1.seans = "12:30";
                gosterim1.tarih = "9 Haziran";
                gosterim1.KoltuklariGoster(salonPanel);
                secilenGosterim = gosterim1;
            }
            if (salonBox.SelectedItem.ToString() == "Salon 2, G.O.R.A, 16:00, 12 Haziran")
            {
                gosterim2.KoltuklariAl(FILE_NAME,"2");
                gosterim2.filmAd = "G.O.R.A";
                gosterim2.seans = "16:00";
                gosterim2.tarih = "12 Haziran";
                gosterim2.KoltuklariGoster(salonPanel);
                secilenGosterim = gosterim2;
            }
            if (salonBox.SelectedItem.ToString() == "Salon 3, Interstellar, 14:20, 29 Haziran")
            {
                gosterim3.KoltuklariAl(FILE_NAME,"3");
                gosterim3.filmAd = "Interstellar";
                gosterim3.seans = "14:20";
                gosterim3.tarih = "29 Haziran";
                gosterim3.KoltuklariGoster(salonPanel);
                secilenGosterim = gosterim3;
            }
        }

       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                indirimKoduBox.Enabled = true;
            }
            else
            {
                indirimKoduBox.Enabled = false;
            }
        }

        private void btBilet_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                IndirimliBilet indirimli = new IndirimliBilet();
                if (indirimKoduBox.Text==indirimli.IndirimKodu)
                {
                    indirimli.Ad = textBox1.Text;
                    indirimli.Soyad = textBox2.Text;
                    indirimli.Tc = maskedTextBox1.Text;
                    indirimli.Gosterim = secilenGosterim;
                    indirimli.SecilenKoltuk();
                    indirimli.Yazdir();
                    EkranTemizle();
                }
                else
                {
                    MessageBox.Show("İndirim Kodunuz Hatalı Büyük Küçük Harflere Dikkat Ediniz!!!");
                    return;
                }
                
            }
            else
            {
                Bilet bilet = new Bilet();
                bilet.Ad = textBox1.Text;
                bilet.Soyad = textBox2.Text;
                bilet.Tc = maskedTextBox1.Text;
                bilet.Gosterim = secilenGosterim;
                bilet.SecilenKoltuk();
                bilet.Yazdir();
                EkranTemizle();
            }
        }
    }
}
