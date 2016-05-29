using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class Program
    {
        static void Main(string[] args)
        {
            //List <int> numbers= new List<int>();
            //numbers.Add(5);
            //Console.WriteLine(numbers);

            List<string> names = new List<string>() {"Peter", "Maria", "Katya", "Todor"};

            names.Add("Kondov");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }

