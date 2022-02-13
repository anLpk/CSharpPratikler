using System;

namespace DongulerWhileForEach
{
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lutfen bir sayı giriniz : ");
            int sayi1 = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi1)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi);


            char character = 'a';
            while (character < 'z')
            {
                Console.WriteLine(character);
                character++;
            }

            System.Console.WriteLine("*** Foreach ***");
            string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };

            foreach (var araba in arabalar)
            {
               Console.WriteLine(araba);
            }
        }
    }
}
