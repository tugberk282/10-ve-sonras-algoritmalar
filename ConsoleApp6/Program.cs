using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)                             //notların istendiği ve 50 üzeri geçer not sayılan not algoritması                         
        {
            int sınav1;
            int sınav2;
            int sözlü;
            decimal ortalama;


            Console.WriteLine("İlk sınav notunuzu girin: ");
            sınav1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sınav notunuzu girin: ");
            sınav2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sözlü notunuzu girin: ");
            sözlü = Convert.ToInt32(Console.ReadLine());

            ortalama = (sınav1 * sınav2 * sözlü) / 3;

            if (ortalama >= 50)
            {
                Console.WriteLine("DErsten geçtiniz");
            }
            else
            {
                Console.WriteLine("Dersten kaldınız!");
            }



        }
    }
}
