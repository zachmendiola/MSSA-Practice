using System;
using System.Collections.Generic;
namespace Technical_Mentor_Call_18_Mar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(IsUnique("dsfhlkj"));
            Console.WriteLine(IsUnique("llll"));
        }
        // Method String If Unique 
        static bool IsUnique(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (dict.ContainsKey(str[i]))
                {
                    return false;
                }
                else
                {
                    dict.Add(str[i], 1);
                }
            }
            return true;
        }

    }
}
