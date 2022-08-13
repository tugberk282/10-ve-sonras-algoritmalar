using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)                                                 //geçme şartının 50 olduğu, vizenin %30 finalin %70inin alındığı algoritma
        {
            double vize;
            double final;
            double toplamNot;
           

            Console.WriteLine("vize notunuzu girin: ");
            vize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("final notunuzu girin: ");
            final = Convert.ToInt32(Console.ReadLine());


            toplamNot = ((vize * 0.30) + (final * 0.70)) / 2;

            if (toplamNot >= 50 && final >= 50)
            {
                Console.WriteLine("Dersinizden geçtiniz. Notunuz :" + toplamNot);
            }
            else if (final < 50 )
            {
                Console.WriteLine("Dersten kaldınız.Final notunuz" + final + "yetersiz");
            }
            else if(toplamNot < 50)
            {
                Console.WriteLine("Dersten kaldınız.Final notunuz" + toplamNot + "yetersiz");
            }
   
        }
    }

    //Öğrencinin geçmek için hem toplam notunun hemde final notunun 50 üzeri gelmesi gerekmektedir!
}
    

