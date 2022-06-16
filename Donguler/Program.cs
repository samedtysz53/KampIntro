using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Kurs1 = "Yazılım geliştirme kursu";
            string Kurs2 = "programlamaya başlangıç eğitim";
            string Kurs3 = "Java";


            String[] Kurslar = new string[] 
            {
            "Yazılım geliştirme kursu","programlamaya başlangıç eğitim","Java","c# dersi"
            };

            for (int i=0;i<Kurslar.Length;i++) 
            {
                Console.WriteLine(Kurslar[i]);
            }
            foreach (String k in Kurslar) 
            {
            
                Console.WriteLine(k);
                Console.WriteLine("|----------------------------|");

            }
            Console.WriteLine("sayfa sonu - footer");

        }
    }
}
