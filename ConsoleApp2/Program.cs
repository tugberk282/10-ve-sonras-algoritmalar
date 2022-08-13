using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)                                     // bir ürünüe kar oranı ve vergisi eklenerek satış fiyatını bulan algoritma
        {
            decimal urunFiyat;
            decimal vergi ;
            decimal karOranı;
            decimal sonFiyat;
            decimal vHesap;
            decimal kHesap;


            Console.WriteLine("Alış fiyatı girin: ");
            urunFiyat = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("vergi oranı girin: ");
            vergi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("kar oranı girin: ");
            karOranı = Convert.ToInt32(Console.ReadLine());

            vHesap = urunFiyat * vergi / 100;
            kHesap = (vHesap + urunFiyat)* karOranı / 100;

            sonFiyat = kHesap + (urunFiyat + vHesap);

            Console.WriteLine("ürün satış fiyatı : " + sonFiyat + "türk lirası");

            



        }
    }
}
