using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

public class Dosya //dosya işlemleri için ayrı class tanımladım
{
    private string FILE_NAME;
    public Dosya(string FILE_NAME)
    {
        this.FILE_NAME = FILE_NAME;
    }

    public void DosyaKontrol()
    {
        if (!File.Exists(FILE_NAME))
        {
            string box_msg = "Rastgele Bir Dosya Oluşturmak İçin \"Evet\" \nUygulamayı Kapatmak İçin \"Hayır\"";

            string box_title = "\"sinema.txt\" Dosya Bulunamadı!!!";

            var secim = MessageBox.Show(box_msg, box_title, MessageBoxButtons.YesNo);

            if (secim == DialogResult.Yes)
            {
                DosyaOlusturma();
                MessageBox.Show("Dosya Oluşturuldu...");
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }

	public void DosyaOlusturma() //rastgele salonlar oluşturma
	{
        FileStream fs = new FileStream(FILE_NAME, FileMode.CreateNew);
        StreamWriter sw = new StreamWriter(fs);
        int doluBos;
        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= 7; j++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    Random random = new Random();
                    doluBos = random.Next(2);
                    if (doluBos == 0)
                    {
                        sw.WriteLine("{0},{1},{2},bos", i, j, k);
                    }
                    else
                    {
                        sw.WriteLine("{0},{1},{2},dolu", i, j, k);
                    }
                }
            }
        }
        sw.Close();
        fs.Close();
    }
}
