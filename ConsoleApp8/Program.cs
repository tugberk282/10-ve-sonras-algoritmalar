using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)                                             //girilen sayının 3 ve 5e tam bölündüğünü kontrol edip söyleyen algoritma
        {
            int sayı1;

            Console.WriteLine("Bir sayı değeri girin: ");
            sayı1 = Convert.ToInt32(Console.ReadLine());

            if (sayı1 % 5 == 0 && sayı1 % 3 == 0)
            {
                Console.WriteLine("Sayı 3 ve 5e tam bölünüyor!");
            }
            else
            {
                Console.WriteLine("Sayı 3 veya 5e tam bölünmüyor");
            }
        }
    }
}
     

