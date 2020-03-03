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
            Console.WriteLine(Bracketing("{[(())]}"));
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
        static bool Bracketing(string bracket)
        {
            Stack<char> temp = new Stack<char>();
            int f = 0;
            foreach (char brack in bracket)
            {
                temp.Push(brack);
                if (brack == ')' || brack == ']' || brack == '}')
                {
                    temp.Pop();

                    char pop = temp.Pop();
                    if (brack == ')' && pop != '(')
                    {
                        f++;
                    }
                    if (brack == ']' && pop != '[')
                    {
                        f++;
                    }
                    if (brack == '}' && pop != '{')
                    {
                        f++;
                    }
                }
                else
                {
                    continue;
                }
            }
            if (f > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
