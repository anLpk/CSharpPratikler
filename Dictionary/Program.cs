using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> kullanicilar = new Dictionary<int, string>();

            kullanicilar.Add(10, "Anil");
            kullanicilar.Add(12, "Lara");
            kullanicilar.Add(14, "Pak");

            Console.WriteLine(kullanicilar[12]);

            foreach(var item in kullanicilar)
              Console.WriteLine(item);

            Console.WriteLine(kullanicilar.Count);
            Console.WriteLine(kullanicilar.ContainsKey(12));
            Console.WriteLine(kullanicilar.ContainsValue("Pak"));

            Console.WriteLine(kullanicilar.Remove(12));

            foreach(var item in kullanicilar.Keys)
              Console.WriteLine(item);

            foreach(var item in kullanicilar.Values)
              Console.WriteLine(item);
        }
    }
}
