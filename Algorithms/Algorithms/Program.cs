using System;
using System.Collections.Generic;
namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(gcd(20,8));
            LinkedList<int> linky = new LinkedList<int>();
            for (int i = 0; i < 11; i++)
            {
                linky.AddFirst(i);
            }
            foreach (int number in linky)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine(linky.Find(5));
        }
        static int gcd(int a, int b)
        {
            while (b != 0)
            {
                int t;
                t = a;
                a = b;
                b = t % b;
            }
            return a;
        }
    }
}
