using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)                                                //direnç ve akım değerleri istenip iki tel arasındaki gerilimin belirlendiği algoritma
        {
            decimal gerilim;
            decimal akım;
            decimal direnç;


            Console.WriteLine("Direnç değerini girin: ");
            direnç = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Akım değerini giriniz: ");
            akım = Convert.ToInt32(Console.ReadLine());

            gerilim = akım * direnç;    // V=I*R formülü ile gerilim hesaplanacak

            Console.WriteLine("Denklemdeki gerilim değeri: " + gerilim + "dir");
            Console.ReadKey();
        }
    }
}
