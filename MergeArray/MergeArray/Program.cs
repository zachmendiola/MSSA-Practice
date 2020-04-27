using System;
using System.Collections.Generic;

namespace MergeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 10;
            Console.WriteLine("Hello World!");
            int[] arr1 = new int[3] {1, 2, 3};
            int[] arr2 = new int[3] {1, 2, 3};
            int[] arr3 = new int[3] {1, 2, 3};
            Print(Merger(arr1, arr2, arr3));
            countSwaps(arr1);
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("yes", 42);
            Console.WriteLine(dict["yes"]);
            string time = "07:19:10PM";
            int h = Int32.Parse(time.Substring(0, 2));
            string sy = y.ToString();
            Console.WriteLine(sy.GetType());
            Console.WriteLine(sy);

        }
        static void countSwaps(int[] a)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
                count++;
            }
            Console.WriteLine("Array is sorted in {0} swaps.", count);
            Console.WriteLine("First Element: {0}", a[0]);
            Console.WriteLine("Last Element: {0}", a[a.Length - 1]);
        }
        static int[] Merger(int[] a, int[] b, int[] c)
        {
            int count = 0;
            int[] arr = new int[9] {0,0,0,0,0,0,0,0,0};
            int aCount = 0;
            int bCount = 0;
            int cCount = 0;
            bool aDone = false;
            bool bDone = false;
            bool cDone = false;
            int total = a.Length + b.Length + c.Length;
            for (int i = 0; i < total && aCount < a.Length && bCount < b.Length && cCount < c.Length; i++)
            {
                if (bDone && cDone || bDone && a[aCount] <= c[cCount] || cDone && a[aCount] <= b[bCount] || a[aCount] <= b[bCount] && a[aCount] <= c[cCount])
                {
                    arr[count] = a[aCount];
                    aCount++;
                    if (aCount == a.Length-1)
                    {
                        aDone = true;
                    }
                    count++;
                }
                if (aDone && cDone || aDone && b[bCount] <= c[cCount] || cDone && b[bCount] <= a[aCount] || b[bCount] <= a[aCount] && b[bCount] <= c[cCount])
                {
                    arr[count] = b[bCount];
                    bCount++;
                    if (bCount == b.Length-1)
                    {
                        bDone = true;
                    }
                    count++;
                }
                if (aDone && bDone || aDone && c[cCount] <= b[bCount] || bDone && c[cCount] <= a[aCount] || c[cCount] <= a[aCount] && c[cCount] <= b[bCount])
                {
                    arr[count] = c[cCount];
                    cCount++;
                    if (cCount == c.Length-1)
                    {
                        cDone = true;
                    }
                    count++;
                }
            }
            return arr;
        }
        static void Print(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        static int[] Merger2(int[] a, int[] b, int[] c)
        {
            int total = a.Length + b.Length + c.Length;
            int[] arr = new int[total];
            int aCount = 0;
            int bCount = 0;
            int cCount = 0;
            while (aCount != a.Length-1 && bCount != b.Length-1 && cCount != c.Length-1)
            {
                if 
            }
            return arr;
        }
    }
}
