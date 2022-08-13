using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)                                                       //taban alanı ve yüksekliği verilen üçgenin alanını hesaplayan algoritma
        {
            int yükseklik;
            int tabanUzunluğu;
            decimal üçgenAlanı;

            Console.WriteLine("Yüksekliği giriniz: ");
            yükseklik = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Taban uzunluğunu giriniz: ");
            tabanUzunluğu = Convert.ToInt32(Console.ReadLine());

            üçgenAlanı = (yükseklik * tabanUzunluğu) / 2;

            Console.WriteLine("Üçgenin alanı: " +üçgenAlanı + "dır");
            Console.ReadKey();
        }
    }
}
