using System;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Type safety - Tip Güvenliği
            // Do not repeat yourself - kendini tekrarlama
            string KategoriEtiketi = "Kategori";
            int OgrenciSayisi = 53000;
            double FaizOranı = 7.53;
            bool SistemGirisi = false;
            double DolarDun = 1;
            double DolarBugun = 20;

            if (DolarDun>DolarBugun) 
            {
                Console.WriteLine("Azalış");
            }
            else if (DolarBugun>DolarDun){ Console.WriteLine("artış"); }
            else { Console.WriteLine("değişmedi"); }

            if (SistemGirisi==true) 
            {
                Console.WriteLine("Ayarlar");
            
            }
            else 
            {
                Console.WriteLine("Giriş yap");
            }
        }
    }
}
