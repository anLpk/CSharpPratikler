using System;

namespace RecursiveExtensionMetodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekursif - Oz yinelemeli, kendi kendini cagiran fonksyon
            int result = 1;
            for(int i = 1; i < 5; i++)
              result = result * 3;
            Console.WriteLine(result);

            Islemler islemler = new Islemler();
            Console.WriteLine(islemler.Expo(3,4));

            //Extension Metodlar
            string ifade = "Zikiriye Urkmez Cengiz";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);

            if(sonuc)
              Console.WriteLine(ifade.RemoveWhiteSpaces());
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());
        }
    }

    public class Islemler
    {
        public int Expo(int sayi, int us)
        {
            if(us<2)
              return sayi;
            return Expo(sayi, us-1) * sayi;
        }
        //Expo(3,4)
        //Expo(3,3) * 3;
        //Expo(3,2) * 3 * 3;
        //Expo(3,1) * 3 * 3 * 3;
        //=> 3^4
    }

    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("*", dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }
    }
}
