using System;

namespace Inlämningsuppgifter4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange sidlängd för triangeln: ");
            int sidlängd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= sidlängd; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}