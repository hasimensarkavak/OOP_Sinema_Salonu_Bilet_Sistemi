using System;
using System.Collections.Generic;
using System.Windows.Forms;


public class Bilet:IBilet
{
    private string ad;
    private string soyad;
    private string tc;
    public string Ad
    {
        get
        {
            return ad;
        }
        set
        {
            ad = value.ToUpper();
        }
    }
    public string Soyad
    {
        get
        {
            return soyad;
        }
        set
        {
            soyad = value.ToUpper();
        }
    }
    public string Tc
    {
        get
        {
            return tc;
        }
        set
        {
            tc = value;
        }
    }
    public Gosterim Gosterim { get; set; }

    protected List<Koltuk> secilenKoltuklar = new List<Koltuk> { };
    public List<Koltuk> SecilenKoltuklar
    {
        get { return secilenKoltuklar; }
        set { secilenKoltuklar = value; }
    }

    protected double fiyat = 24.00; //indirimli bilettede kullanmak için protected

    public void SecilenKoltuk() //seçilen koltukları gösterimden buluyoruz
    {
        foreach (Koltuk koltuk in Gosterim.koltuklar)
        {
            if (koltuk.Secildi == true)
            {
                secilenKoltuklar.Add(koltuk);
            }
        }
    }

    public virtual void Yazdir() //indirimli bilette farklı kullanmak için virtual
    {
        string koltukBilgileri="";
        foreach (Koltuk koltuk in secilenKoltuklar)
        {
            koltukBilgileri += koltuk.SiraNo + "-" + koltuk.KoltukNo + "\n";
        }
        double toplamTutar = fiyat * secilenKoltuklar.Count;
        string box_msg = "MÜŞTERİ BİLGİLERİ\n" +
            "Ad: " + ad + "\n" +
            "Soyad: " + soyad + "\n" +
            "TC: " + tc + "\n" +
            "\nGÖSTERİM BİLGİLERİ\n" +
            "Film: " + Gosterim.filmAd + "\n" +
            "Salon: " + Gosterim.salonNo + "\n" +
            "Seans: " + Gosterim.seans + "\n" +
            "Tarih: " + Gosterim.tarih + "\n" +
            "\nKOLTUK BİLGİLERİ\n" +
            koltukBilgileri + "\n"+
            "\nToplam Tutar: " + toplamTutar+"TL";

        string box_title = "Bilet Alındı";

        MessageBox.Show(box_msg,box_title);
    }
}
