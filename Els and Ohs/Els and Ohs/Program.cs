using System;

namespace Els_and_Ohs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            foreach (var item in el(arr1))
            {
                Console.WriteLine(item);
            }
        }
        static int[] el(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                arr[arr.Length - 1] = 1;
                if (i == 0)
                {
                    arr[i] = 1;
                    count++;
                }
                else if (arr[i-1] == 1)
                {
                    continue;
                }
                else if (arr[i-1] == 0 && arr[i+1] == 0)
                {
                    arr[i] = 1;
                    count++;
                }
            }
            Console.WriteLine(arr.Length);
            Console.WriteLine(count);
            return arr;
        }
    }
}
