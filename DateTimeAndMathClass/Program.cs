using System;

namespace DateTimeAndMathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString);
            Console.WriteLine(DateTime.Now.ToShortDateString);
            Console.WriteLine(DateTime.Now.ToLongTimeString);
            Console.WriteLine(DateTime.Now.ToShortTimeString);

            // Datetime format
            Console.WriteLine(DateTime.Now.ToString("dd")); //22
            Console.WriteLine(DateTime.Now.ToString("ddd")); //Tue
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Tuesday

            Console.WriteLine(DateTime.Now.ToString("MM")); //02
            Console.WriteLine(DateTime.Now.ToString("MMM")); //Feb
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //February

            Console.WriteLine(DateTime.Now.ToString("yy")); //22
            Console.WriteLine(DateTime.Now.ToString("yyy")); //2022

            //Math Kutuphanesi
            Console.WriteLine(Math.Abs(-25)); //25
            Console.WriteLine(Math.Sin(10)); //Sinus
            Console.WriteLine(Math.Cos(10)); //Cosinus
            Console.WriteLine(Math.Tan(10)); //Tanjant

            Console.WriteLine(Math.Ceiling(22.3)); //23
            Console.WriteLine(Math.Round(22.3)); //22
            Console.WriteLine(Math.Round(22.7)); //23
            Console.WriteLine(Math.Floor(22.7)); //22

            Console.WriteLine(Math.Max(2, 6)); //6
            Console.WriteLine(Math.Min(2, 6)); //2

            Console.WriteLine(Math.Pow(2, 6)); //64
            Console.WriteLine(Math.Sqrt(81)); //9

            Console.WriteLine(Math.Log(9)); //9 un e tabanindaki logaritmik karsiligini verir.
            Console.WriteLine(Math.Exp(9)); //e uzeri 9 u verir.
            Console.WriteLine(Math.Log10(10)); //1
        }
    }
}
