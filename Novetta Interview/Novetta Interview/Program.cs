using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace interview23apr
{
    class Program
    {
        static void Main(string[] args)
        {
            string ye = "RA/c/e*ca) r";
            int[] arr = new int[3] { 6, 7, 8 };
            Console.WriteLine("Hello World!");
            Console.WriteLine(IsPalindrome(ye));
            arr.Contains(6);
        }

        static bool IsPowerOfTwo(int a)
        {
            while (a > 0)
            {
                if (a % 2 == 0)
                {
                    a = a / 2;
                    IsPowerOfTwo(a);
                }
                if (a % 2 != 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }
        public int[] TwoSum(int[] nums, int target)
        {
            int[] returning = new int[2] { 0, 0};
            for (int i = 0; i < nums.Length; i++)
            {
                int exists = target - nums[i];
                if (nums.Contains(exists))
                {
                    returning[0] = nums[i];
                    returning[1] = exists;
                }
            }
            
            return returning;
        }
        static public bool IsPalindrome(string s)
        {
            char[] letters = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            s = s.ToLower();
            for (int i = 0; i < s.Length; i++)
            {
                if (!letters.Contains(s[i]))
                {
                   Console.Write(s[i]);
                }
            }
            Console.WriteLine(s);
            Console.WriteLine(s[3].GetType());
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
