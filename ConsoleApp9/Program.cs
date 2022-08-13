using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)                                                               //girilen sayının 0-100 arasında olup olmadığını kontrol eden algoritma
        {
            int sayı1;

            Console.WriteLine("Bir sayı değeri girin: ");
            sayı1 = Convert.ToInt32(Console.ReadLine());

            if (0 < sayı1 && sayı1 < 100)
            {
                Console.WriteLine("Sayı 0-100 aralığındadır.");
            }
            else
            {
                Console.WriteLine("sayı 0-100 aralığında değildir");
            }
        }
    }
}
