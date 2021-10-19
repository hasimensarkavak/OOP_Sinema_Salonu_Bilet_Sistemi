using System;
using System.Windows.Forms;

public class IndirimliBilet  : Bilet,IBilet
{
	private string indirimKodu = "INDIRIM"; //örnek indirim kodu olsun diye
	public string IndirimKodu
    {
        get
        {
            return indirimKodu;
        }
    }
    private int indirimMiktar = 15; // Yüzde olarak düşündüm

    public override void Yazdir() //normal biletten farklı olması için override kullandım
    {
        string koltukBilgileri = "";
        foreach (Koltuk koltuk in secilenKoltuklar)
        {
            koltukBilgileri += koltuk.SiraNo + "-" + koltuk.KoltukNo + "\n";
        }
        double toplamTutar = fiyat * secilenKoltuklar.Count;
        string box_msg = "MÜŞTERİ BİLGİLERİ\n" +
            "Ad: " + Ad + "\n" +
            "Soyad: " + Soyad + "\n" +
            "TC: " + Tc + "\n" +
            "\nGÖSTERİM BİLGİLERİ\n" +
            "Film: " + Gosterim.filmAd + "\n" +
            "Salon: " + Gosterim.salonNo + "\n" +
            "Seans: " + Gosterim.seans + "\n" +
            "Tarih: " + Gosterim.tarih + "\n" +
            "\nKOLTUK BİLGİLERİ\n" +
            koltukBilgileri + "\n" +
            "FİYAT BİLGİLERİ\n" +
            "İndirim Kodu: " + indirimKodu + "\n" +
            "İndirim Tutarı: %"+ indirimMiktar +"\n" +
            "İndirimsiz Fiyat: "+ toplamTutar + "TL\n" +
            "\nToplam Tutar: " + (toplamTutar-(toplamTutar*indirimMiktar)/100+"TL");

        string box_title = "Bilet Alındı";

        MessageBox.Show(box_msg, box_title);
    }
}
