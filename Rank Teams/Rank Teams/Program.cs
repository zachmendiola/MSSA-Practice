using System;
using System.Collections.Generic;
namespace Rank_Teams
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            Dictionary<string, int> points = new Dictionary<string, int>();
            dict.Add("ABC", 3);
            dict.Add("ACB", 2);

            string p = "";
            int val = 0;
            foreach (KeyValuePair<string, int> keyValuePair in dict)
            {
                p = p + keyValuePair.Key;
                val = keyValuePair.Value;
                Console.WriteLine("{0}, {1}", p, val);
                p = "";
                val = 0;
            }
            for (int i = 0; i < p.Length; i++)
            {

            }
        }
    }
}
