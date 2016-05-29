using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class Program
    {
        static void Main(string[] args)
        {
            string str = "SoftUni";
            Console.WriteLine(str);
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("str[{0}]={1}", i,str[i]);
            }

            Console.WriteLine(str.IndexOf("Uni"));
            Console.WriteLine(str.Substring(0,4));
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
        }
    }

