using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)                                                     //girilen sayının kaç basamaklı olduğunu bulan algoritma
        {
            int sayı1;
            int sayac=0;

            Console.WriteLine("Bir sayı değeri girin: ");
            sayı1 = Convert.ToInt32(Console.ReadLine());


            if (sayı1 > 0 && sayı1 <= 99999)
            {
             


                while (sayı1 > 0)
                {
                    sayı1 /= 10;
                    sayac++;

                   

                }
                Console.WriteLine("Girilen sayı " + sayac + " basamaklıdır");
            }
            else
            {
                Console.WriteLine("Sayı belirlenen aralikta değildir");   //0-99.999
            }

          
           



            
        }
    }
}
