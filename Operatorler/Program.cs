using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atama ve islemli Aatama
            int x = 3;
            int y = 3;
            y = y + 2;

            System.Console.WriteLine(y);
            y += 2;
            System.Console.WriteLine(y);
            y /= 1;
            System.Console.WriteLine(y);
            x *= 2;
            System.Console.WriteLine(x);

            // Mantiksal Operatorler
            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
              System.Console.WriteLine("Perfect!");

            if(isSuccess || isCompleted)
              System.Console.WriteLine("Great!");

            if(isSuccess && !isCompleted)
              System.Console.WriteLine("Fine!");

            //Mantiksal Operatorler
            int a = 3;
            int b = 4;
            bool sonuc = a < b;

            System.Console.WriteLine(sonuc);
            sonuc = a > b;

            System.Console.WriteLine(sonuc);
            sonuc = a >= b;

            System.Console.WriteLine(sonuc);
            sonuc = a <= b;

            System.Console.WriteLine(sonuc);
            sonuc = a == b;

            System.Console.WriteLine(sonuc);
            sonuc = a != b;
        }
    }
}
