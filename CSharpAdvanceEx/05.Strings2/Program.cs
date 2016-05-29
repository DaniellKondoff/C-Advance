using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class Program
    {
        static void Main()
        {
            string firstName = "Steve";
            string lastName = "Jobs";
            int age = 56;
            Console.WriteLine(firstName + " " + lastName + " (age: " + age + ")");

            string allLangs = "C#, Java; HTML, CSS; PHP, SQL";
            string[] langs = allLangs.Split(new char[] { ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in langs)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Langs = " + string.Join(", ", langs));
            Console.WriteLine("  \n\n Software  University  ".Trim());


        }
    }

