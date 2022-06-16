using System;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
             kurs kurs1 = new kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursEgitmen = "Samed";
            kurs1.İzlenmeOranı = 53000;

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "java";
            kurs2.KursEgitmen = "kamil";
            kurs2.İzlenmeOranı = 530;

            kurs kurs3 = new kurs();
            kurs3.KursAdi = "c++";
            kurs3.KursEgitmen = "yılmaz";
            kurs3.İzlenmeOranı = 5000;

            kurs kurs4 = new kurs();
            kurs4.KursAdi = "python";
            kurs4.KursEgitmen = "ela";
            kurs4.İzlenmeOranı = 8000;

            kurs[] kurslar = new kurs[] { kurs1,kurs2,kurs3,kurs4};

            foreach (var k in kurslar) 
            {
                Console.WriteLine(" kurs adı:"+k.KursAdi+" \n Eğitmen adı:"+k.KursEgitmen+"\n izlenme:"+k.İzlenmeOranı+"\n -----------");
            
            }
        }
    }
}
class kurs
{
    public string KursAdi { get; set; }
    public string KursEgitmen  { get; set; }
    public int İzlenmeOranı { get; set; }
}
