using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            int sonuc = Topla(a,b);
            Console.WriteLine(a+b);
            Console.WriteLine(sonuc);

            Metodlar ornek = new Metodlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArttirVeTopla(ref a, ref b);
        }

        public int Topla(int value1, int value2)
        {
            return (value1 + value2); 
        }
    }

    class Metodlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirVeTopla(ref int deger1, ref int deger2)
        {
            deger1+=1;
            deger2+=1;
            return (deger1+deger2);
        }
    }
}
