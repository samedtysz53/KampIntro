using System;

namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] s1 = new int[] { 20,50,60};
            int[] s2 = new int[] { 150,550,70};

            s1 = s2;
            s2[0] = 999;
            Console.WriteLine(s1[0]);
        }
    }
}
