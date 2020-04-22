using System;

namespace _22_Apr_Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = new int[5] { 1, 3, 7, 4, 9 };
            Console.WriteLine(HasSum(arr, 0));
        }
        static bool HasSum(int[] arr, int num)
        {
            for (int low = 0, high = arr.Length-1; low < arr.Length-1/2;)
            {
                Array.Sort(arr);
                int sum = arr[low] + arr[high];
                if (sum > num)
                {
                    high--;
                }
                if(sum < num)
                {
                    low++;
                }
                if (sum == num)
                {
                    return true;
                }
               
            }
            return false;
        }
    }
}
