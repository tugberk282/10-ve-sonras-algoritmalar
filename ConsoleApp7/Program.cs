using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)                                                       //girilen sayının tek mi çift mi olduğunu söyleyen algoritma
        {
           int sayı1;

            Console.WriteLine("Bir sayı değeri girin: ");
            sayı1 = Convert.ToInt32(Console.ReadLine());

            if (sayı1 == 0 || sayı1 % 2 == 0)
            {
                Console.WriteLine("Sayı çifttir");
            }
            else
            {
                Console.WriteLine("Sayı tektir");
            }
        }
    }
}
