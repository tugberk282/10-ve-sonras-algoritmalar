using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)                     //su baz alınarak derecelendirme yaptım.0ın altı katı, 0-100 arası sıvı, 100ün üzeri gaz olarak belirttim
        {
            decimal sıcaklık;

            Console.WriteLine("Sıckalık değerini giriniz: ");
            sıcaklık = Convert.ToInt32(Console.ReadLine());

            if (sıcaklık <= 0)
            {
                Console.WriteLine("Sıcaklığını girdiğiniz madde gaz formunda!");
            }
            else if (sıcaklık > 0 && sıcaklık<100)
            {
                Console.WriteLine("Sıcaklığını girdiğiniz madde sıvı formunda!");
            }
            else
            {
                Console.WriteLine("Sıcaklığını girdiğiniz madde gaz formunda!");
            }



        }
    }
}
