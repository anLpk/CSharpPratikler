using System;

namespace MetodOverLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";
            int outSayi;

            bool sonuc = int.TryParse(sayi, out outSayi);

            if(sonuc)
            {
                Console.WriteLine("Basarili!");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Basarisiz");
            }

            Metodlar metod = new Metodlar();
            metod.Topla(4, 5, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            //Metod Overloading
            int ifade = 999;
            metod.EkranaYazdir(ifade);
            metod.EkranaYazdir("Anil", "Pak");

            //Metod Imzasi
            //MetodAdi+ParametreSayisi+Parametre
        }
    }

    class Metodlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}
