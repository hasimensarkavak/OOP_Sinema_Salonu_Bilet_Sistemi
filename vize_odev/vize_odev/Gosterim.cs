using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
public class Gosterim
{
    public string filmAd;
    public string tarih;
    public int salonNo;
    public string seans;

    public List<Koltuk> koltuklar = new List<Koltuk> { }; //salon içindeki koltuklar

    public void KoltuklariAl(string FILE_NAME, string salon) //salona göre koltukları txt den çekiyoruz
    {
        FileStream fs = new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read);
        StreamReader sr = new StreamReader(fs);
        string satir;

        salonNo = Convert.ToInt32(salon);

        while ((satir = sr.ReadLine()) != null)
        {
            string[] veri = satir.Split(',');
            if (veri[0] == salon)
            {
                Koltuk koltuk = new Koltuk();
                koltuk.SiraNo = Convert.ToInt32(veri[1]);
                koltuk.KoltukNo = Convert.ToInt32(veri[2]); //koltuk nesneleri dolduruluyor
                koltuk.BosDolu = veri[3].ToLower();
                koltuk.ButtonBilgileriDoldur();
                koltuklar.Add(koltuk);
            }
        }
        fs.Close();
        sr.Close();
    }

    public void KoltuklariGoster(Panel panel) //panelde koltuk buttonları gösteriliyor
    {
        panel.Controls.Clear();

        foreach (Koltuk koltuk in koltuklar)
        {
            panel.Controls.Add(koltuk.button);
        }
    }
}
