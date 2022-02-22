using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namespace

            ArrayList liste = new ArrayList();
            liste.Add(2);
            liste.Add("Anil");
            liste.Add(null);
            liste.Add(true);

            foreach(var item in liste)
              Console.WriteLine(item);

            //AddRange
            string[] renkler = {"kirmizi", "yesil", "siyah"};
            List<int> sayilar = {1,2,3,4,5,6,7};

            liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach(var item in liste)
              Console.WriteLine(item);
        }
    }
}
