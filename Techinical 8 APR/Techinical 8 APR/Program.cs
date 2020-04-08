using System;
using System.Collections.Generic;
namespace Techinical_8_APR
{
    class Program
    {
        // Method for Palindrome : Bool
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(IsPalindrome("racecar"));
            Console.WriteLine(IsPalindrome("drive"));
            string[] strarr = new string[3] { "hi", "hey", "hello" };
            int[] intarr = new int[10] { 10, 3, 4, 6, 7, 2, 5, 9, 14, 67 };
            Print(Bubble(intarr));
        }
        static bool IsPalindrome(string a)
        {
            for (int i = 0; i < a.Length/2; i++)
            {
                if (a[i] != a[a.Length-1-i])
                {
                    return false;
                }
            }
            return true;
        }
        static int[] Bubble(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
        static void Print(Array arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

    }
}
