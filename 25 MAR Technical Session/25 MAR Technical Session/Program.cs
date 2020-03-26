using System;
using System.Collections.Generic;

namespace _25_MAR_Technical_Session
{
    class Program
    {
        static void Main(string[] args)
        {
            //accept two integers and return remainder
            Console.WriteLine("Hello World!");
            Remaining(1, 1);
            Remaining(1, 0);
            Console.WriteLine(DuplicateRemover("hheelloo"));
        }
        static int Remaining(int a, int b)
        {
            try
            {
                int result = a % b;
                return result;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Please enter a number other than zero for the divisor");
            }
            return 0;
        }
        static string DuplicateRemover(string a)
        {
            List<char> list = new List<char>();
            string newString = string.Empty;
            for (int i = 0; i < a.Length; i++)
            {
                if (!list.Contains(a[i]))
                {
                    list.Add(a[i]);
                }
                else
                {
                    continue;
                }
            }
            foreach (char item in list)
            {
                newString += item;
            }
            return newString;
        }
    }
}
