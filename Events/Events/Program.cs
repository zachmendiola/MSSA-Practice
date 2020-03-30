using System;
using System.Collections.Generic;
using System.IO;
namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            int c = guess(ref a, b);
            Console.WriteLine("{0}, {1}, {2}", a, b, c);
        }
        public static int guess(ref int first, int second)

        {
            int temp = first;
            first = second;
            second = temp;
            return temp;
        }


    }
    class Burger
    {
        public string cheese { get; set; }
        public string lettuce { get; set; }
        public string meat { get; set; }
    }
   

}
