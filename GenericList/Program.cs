using System;
using System.Collections.Generic;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            // T -> obejct turundedir

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(24);
            sayiListesi.Add(25);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("mavi");
            renkListesi.Add("kirmizi");
            renkListesi.Add("mor");

            foreach (var sayi in sayiListesi)
              Console.WriteLine(sayi);

            foreach (var renk in renkListesi)
              Console.WriteLine(renk);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi * 2));
            renkListesi.ForEach(renk => Console.WriteLine(renk.ToUpper()));

            sayiListesi.Remove(23);
            sayiListesi.RemoveAt(0);

            if(sayiListesi.Contains(25))
              Console.WriteLine("Buldum!");

            Console.WriteLine(renkListesi.BinarySearch("SARI"));

            //diziyi listeye cevirme
            string[] hayvanlar = {"kedi", "kopek", "at"};
            List<string> hayvanListesi = new List<string>(hayvanlar);

            hayvanListesi.Clear();

            //List icerisinde nesne tutmak
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "Anil";
            kullanici1.Soyisim = "Pak";
            kullanici1.Yas = 32;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici1.Isim = "Lara";
            kullanici1.Soyisim = "Pak";
            kullanici1.Yas = 29;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();

            yeniListe.Add(new Kullanicilar(){
              Isim="Daniel",
              Soyisim = "Amokachi",
              Yas = 50
            });
        }
    }

    public class Kullanicilar
    {
        string isim;
        string soyisim;
        int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim {get => soyisim; set => soyisim = value; }

        public int Yas { get => yas; set => yas = value; }
    }
}
