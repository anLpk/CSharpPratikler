using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            // string
            string name = "Anil";
            string surname = "Pak";
            var prefferedName = "Neil";

            int age = 32;
            var birthYear = 1990;

            // byte
            byte b = 5; // 1byte
            sbyte c = 5; // 1byte
            short s = 5; // 2byte
            ushort us = 5; // 2byte

            // integer
            Int16 i16 = 2; // 2byte
            int i = 2; // 4byte
            int i32 = 2; // 4byte
            Int64 i64 = 2; //8 byte

            uint ui = 2; //4byte
            long l = 4; //8byte
            ulong ul = 4; //8byte

            // Reel sayilar
            float f = 5; //4byte
            double d = 5; //8byte
            decimal de = 5; //16byte

            char ch = '2'; //2byte

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            //Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            // Donusumler
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString(); //"2020" -> "20" + "20"

            int int21 = int20 + int.Parse(str20); // 40

            // datetime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);

            DateTime date1 = DateTime.Now;
            DateTime date2 = DateTime.UtcNow;
            DateTime date3 = DateTime.Today;

            System.Console.WriteLine(date1); // 13/02/2022 12:33:24 PM
            System.Console.WriteLine(date2); // 13/02/2022 1:33:24 AM
            System.Console.WriteLine(date3); // 13/02/2022 12:00:00 AM
        }
    }
}
