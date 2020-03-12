using System;
using System.Collections.Generic;
namespace First_Duplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(FirstDup("aabbccjkklo"));
        }
        static char FirstDup(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (!dict.ContainsKey(str[i]))
                {
                    dict.Add(str[i], 1);
                }
                else
                {
                    dict[str[i]]++;
                }
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (dict.ContainsKey(str[i]) && dict[str[i]] == 1)
                {
                    return str[i];
                }
            }
            return '.';
        }
    }
}
