using System;

namespace TipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion - Bilincsiz Donusum
            byte a = 5;
            sbyte b = 30;
            shortt c = 10;

            int d = a + b + c;
            System.Console.WriteLine("d:" + d);

            long h = d;
            System.Console.WriteLine("h:" + h);

            float i = h;
            System.Console.WriteLine("i:" + i);

            //Explicit Conversion - Bilincli Donusum
            int x = 4;
            byte y = (byte)x;
            System.Console.WriteLine("y:" + y);

            int z = 100;
            byte t = (byte)z;
            System.Console.WriteLine("t:" + t);

            float w = 10.3f;
            byte v = (byte)w;
            System.Console.WriteLine("v:" + v);

            // *** ToString Methodu ***
            int xx = 6;
            string yy = xx.ToString();

            string s1= "10", s2 = "20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
        }

        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            rakam2 = Int32.Parse(metin2);
        }
    }
}
