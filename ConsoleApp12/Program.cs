using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)                 //çalışanların sabit ücret aldığı, çocuk sayısına göre extra aile ücreti aldıkları algoritma
        {
             double maas = 5000;
             int cocukSayisi;
            double sonMaas;


            Console.WriteLine("Kaç çocuğunuz olduğunu yazınız: ");
            cocukSayisi = Convert.ToInt32(Console.ReadLine());

            if (cocukSayisi == 1) 
            {
                sonMaas = (maas * 0.05) + maas;
                Console.WriteLine("Maaşınız " + sonMaas + " olarak belirlendi");
            }
            else if (cocukSayisi == 2)
            {
                sonMaas = (maas * 0.10) + maas;
                Console.WriteLine("Maaşınız " + sonMaas + " olarak belirlendi");
            }
            else if  (cocukSayisi >= 3)
            {
                sonMaas = (maas * 0.15) + maas;
                Console.WriteLine("Maaşınız " + sonMaas + " olarak belirlendi");
            }
            
        }
    }
}
