using System;

namespace ConsoleAppItems
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.Write("Adınız : ");

            a = Console.ReadLine();

            Console.WriteLine("Sizin Adınız {0}",a);

            Console.ReadKey();        
        }
    }
}
