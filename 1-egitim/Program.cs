using System;

namespace _1_egitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[4];

            for (int i = 0; i<isimler.Length; i++)
            {
                Console.Write($"{i+1}. isimi girin: ");
                isimler[i] = Console.ReadLine();
            }

            Console.Write("Kayitli isimler: ");

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.Write(isimler[i] + " ");
            }

            Console.Read();
        }
    }
}
