using System;

namespace ConsoleProgramlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Isminizi giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadinizi giriniz:");
            string surname = Console.ReadLine();
            Console.WriteLine($"Merhaba {name} {surname}");

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
        }
    }
}
