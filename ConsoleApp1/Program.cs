using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)                         //a b ve c değerleri istenen 2.derece denklemin köklerini bulan algoritma
        {
            double a, b, c;
            double delta;
            double kok1, kok2; ;


            Console.WriteLine("a değerini girin: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("b değerini girin: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("c değerini girin: ");
            c = Convert.ToInt32(Console.ReadLine());

            delta = b * b - (4 * a * c);

            if (delta < 0)
            {
                Console.WriteLine("reel kök yok!");

            }
            else if (delta == 0)
            {
                kok1 = -b / (2 * a);
                kok2 = -b / (2 * a);
                Console.WriteLine("KÖK1:" + kok1, "KÖK2:" + kok2);
                Console.WriteLine("kökler eşittir");

            }
            else if (delta > 0)
            {
                kok1 = (-b + (Math.Sqrt(delta)) / (2 * a));
                kok2 = (-b + (Math.Sqrt(delta)) / (2 * a));
                Console.WriteLine("iki farklı kök var ");
                Console.WriteLine("KÖK1:" + kok1, "KÖK2:" + kok2);

            }
        }
    }
}
