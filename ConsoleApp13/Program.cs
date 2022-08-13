using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)                                       //sabit saat ücretiyle çalışan işçilerin 40 saati geçince he saat 2x maaş almasını göstren algoritma
        {
            int calismaSaati;
            int saatÜcreti = 30;
            int sonMaas;

            Console.WriteLine("Toplamda kaç saat çalıştığınızı yazınız ");
            calismaSaati = Convert.ToInt32(Console.ReadLine());


            if (calismaSaati <= 40)
            {
                sonMaas = (calismaSaati * saatÜcreti);
                Console.WriteLine("Maaşınız " + sonMaas + " olarak belirlendi");
            }
            else if (calismaSaati > 40)
            {
                sonMaas = (((calismaSaati - 40) * 2) * saatÜcreti) + 1200;
                Console.WriteLine("Maaşınız mesainizle birlikte " + sonMaas + " olarak belirlendi");
            }
        }
    }
}
