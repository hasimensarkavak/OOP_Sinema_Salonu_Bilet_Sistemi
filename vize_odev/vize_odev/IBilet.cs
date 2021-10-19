using System;
using System.Collections.Generic;
public interface IBilet
{
	public string Ad { get; set; }
	public string Soyad { get; set; }
	public string Tc { get; set; }
	public Gosterim Gosterim { get; set; }
	public List<Koltuk> SecilenKoltuklar { get; set; }
	public void Yazdir();
}
