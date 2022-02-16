using System;

namespace Diziler
{
 class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5];

            string[] hayvanlar = { "Kedi", "Kopek", "Kus", "Maymun" };
            int[] dizi;
            dizi = new int[5];
            renkler[0] = "Mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[3]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);
           
           Console.WriteLine("Lutfen dizinin eleman sayısıni giriniz");
           int diziUzunlugu = int.Parse(Console.ReadLine());
           int[] sayiDizisi = new int[diziUzunlugu];

           for (int i = 0; i < diziUzunlugu; i++)
           {
               Console.WriteLine("Lütfen {0}. sayıyı giriniz", i+1);
               sayiDizisi[i] = int.Parse(Console.ReadLine());
               
           }

           int toplam = 0;
           foreach (var sayi in sayiDizisi)
           {
               toplam+=sayi;
           }
            Console.WriteLine("Ortalama: " + toplam/diziUzunlugu);
        }
    }
}
