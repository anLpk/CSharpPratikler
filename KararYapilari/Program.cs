using System;

namespace KararYapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if(time>=6 && time < 11)
                Console.WriteLine("Gunaydin!");
            else if(time <= 18)
                Console.WriteLine("Iyi Gunler!");
            else
                Console.WriteLine("Iyi Geceler!");

            string sonuc = time <= 18 ? "Iyi Gunler!" : "Iyi Geceler!";

            sonuc = time >= 6 && time < 11 ? "Gundaydin" : time<=18 ? "Iyi Gunler!" : "Iyi Geceler";

            Console.WriteLine(sonuc);
        }

        static void SwitchCaseCondition(string[] args)
        {
            int month = DateTime.Now.Month;

            //Expression
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak Ayindasiniz!");
                break;
                
                case 2:
                    Console.WriteLine("Subat Ayindasiniz!");
                break;
                
                case 3:
                    Console.WriteLine("Mart Ayindasiniz!");
                break;
                
                case 4:
                    Console.WriteLine("Nisan Ayindasiniz!");
                break;
                                
                default:
                    Console.WriteLine("Yanlis veri girdiniz!");
                break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kis Ayindasiniz!");
                break;
                
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Ilkbahar Ayindasiniz!");
                break;
                
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz Ayindasiniz!");
                break;
                
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar Ayindasiniz!");
                break;
                                
                default:
                    Console.WriteLine("Yanlis veri girdiniz!");
                break;
            }
        }
    }
}
