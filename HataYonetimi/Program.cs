using System;

namespace HataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayi giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmis oldugunuz sayi: " + sayi);
            }
            catch(Exception ex)
            {
                //throw ArgumentNullException("Hata: "+ ex.Message.ToString());
                Console.WriteLine("Hata: "+ ex.Message.ToString());
            }

            try
            {
               //int a = int.Parse(null); 
               //int a = int.Parse("test");
               int a = int.Parse("-20000000000000");
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Bos deger girdiniz");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun degil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Cok kucuk ya da cok buyuk bir deger girdiniz.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Islem basari ile tamamlandi");
            }
        }
    }
}
