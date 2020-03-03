using System;
using System.Collections.Generic;
namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrayal = new int[3, 3] { { 11, 2, 4 }, { 4, 5, 6 }, { 10, 8, -12 } };
            diagonalDifference(arrayal);
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
        public static int diagonalDifference(int[,] arr)
        {
            int primary = 0;
            int secondary = 0;
            for (int k = 0; k < 3; k++)
            {
                primary = primary+ arr[k, k];
                secondary = secondary + arr[3 - 1 - k, 0 + k];

            }
            Console.WriteLine(primary);
            Console.WriteLine(secondary);
            int ans = primary - secondary;
            if (ans < 0)
            {
                ans = ans * -1;
            }
         
            Console.WriteLine(ans);
            return ans;
        }
    }
}
