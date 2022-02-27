using System;
using System.Collections;
using System.Collections.Generic;
            
namespace Arraylist
{
     class Program
    {
        static void Main(string[] args)
        {
           // System.Collections namespace

            ArrayList liste = new ArrayList();
            liste.Add("Ayşe");
            liste.Add("20");
            liste.Add(true);
            liste.Add('A');

            // içerisindeki verilere erişme


            Console.WriteLine(liste[1]);
            foreach (var i in liste)
              Console.WriteLine(i);

            Console.WriteLine("**********AddRange************");
            //Birden fazla elemanı toplu halde eklemek.
            string[] renkler = { "kırmızı", "sarı", "mor" };
            List<int> sayilar = new List<int>()
            {
                1,2,3,47,8,96,7
            };
            liste.AddRange(renkler);
           liste.AddRange(sayilar);

           foreach (var i in liste)
                Console.WriteLine(i);

            // Sort
            //Console.WriteLine("*******SORT**************");
            // liste.Sort(); 

            // Binary Search
           // Console.WriteLine("********Binary Search*******");
           // Console.WriteLine(liste.BinarySearch(2));

            // Reverse 
            Console.WriteLine("********Reverse*******");
            liste.Reverse();
            foreach (var i in liste)
             Console.WriteLine(i);

            // Clear
            Console.WriteLine("********Clear*******");
            liste.Clear();
            foreach (var i in liste)
                Console.WriteLine(i);


        }
    }
}
