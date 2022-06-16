using System;

namespace Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1=new Urun();
            urun1.Adi = "YMuz";
            urun1.Aciklama = "Yerli";
            urun1.Fiyati = 19.99;
            urun1.UrunAdedi = 59;
            Urun urun2 = new Urun();
            urun2.Adi = "Muz";
            urun2.Aciklama = "İthal";
            urun2.Fiyati = 29.99;
            urun2.UrunAdedi = 29;

            Urun urun3 = new Urun();
            urun3.Adi = "Ananas";
            urun3.Aciklama = "Ananas";
            urun3.Fiyati = 99.99;
            urun3.UrunAdedi = 9;

            Urun[] Urunler = new Urun[] { urun1,urun2,urun3 };

            foreach (Urun U in Urunler) 
            {
            Console.WriteLine(" Ürün adı:"+U.Adi+" Fiyat:"+U.Fiyati+" Açıklama:"+U.Aciklama+" Urun adedi:"+U.UrunAdedi);
          
       
                Console.WriteLine("----------------------------------------------------------");
            }

            Console.WriteLine("--------------------------Metodlar--------------------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);
          
        }
    }
}
