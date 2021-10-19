using System;
using System.Windows.Forms;
using System.Drawing;
public class Koltuk
{
    public int SiraNo { get; set; }
    public int KoltukNo { get; set; }
    public string BosDolu { get; set; }
    public bool Secildi { get; set; }

    public Button button = new Button(); //Koltuk seçimini buttonla yapmak istedim nesnelere button atadım

    public void ButtonBilgileriDoldur() //button bilgileri tanımlanıyor
    {
        button.Name =  SiraNo.ToString() + "-" + KoltukNo.ToString();
        button.Text = SiraNo.ToString() + "-" + KoltukNo.ToString();
        button.Width = button.Height = 40;
        button.Left = 45 * KoltukNo;
        button.Top = 45 * SiraNo;
        button.Click += YerAyirma;

        if (BosDolu == "dolu")
        {
            button.BackColor = Color.Red;
        }
        else if (BosDolu == "bos")
        {
            button.BackColor = Color.Aqua;
        }
        else
        {
            var secim = MessageBox.Show("sinema.txt Dosyasında Koltuk Dolu/Bos Girişi Hatalı!!!\nLütfen Düzeltip Tekrar Deneyin...");
            if (secim == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }
    }

    public void YerAyirma(object sender, EventArgs e) //button özellikleri
    {
        //Button btn = (Button)sender;
        if (button.BackColor == Color.Red)
        {
            MessageBox.Show("Koltuk Dolu Başka Bir Koltuk Seçmeyi Deneyin...");
        }
        else if (button.BackColor == Color.Aqua)
        {
            button.BackColor = Color.Green;
            Secildi = true;
        }
        else if (button.BackColor == Color.Green)
        {
            button.BackColor = Color.Aqua;
            Secildi = false;
        }
    }
}
