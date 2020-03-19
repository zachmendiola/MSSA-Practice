using System;

namespace _19_MAR_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Rectangle myRectangle = new Rectangle();
            myRectangle.Length = 10;
            myRectangle.Width = 2;
            Console.WriteLine(myRectangle.ComputeArea());
            int x = 10;
            int y = 15;
            Printing(Swap(x, y));
        }
        public static int[] Swap(int x, int y)
        {
            int[] arr = new int[2] {0, 0};
            int temp = 0;
            temp = x;
            x = y;
            y = temp;
            arr[0] = x;
            arr[1] = y;
            return arr;
        }
        public static void Printing(Array arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Rectangle
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public double ComputeArea()
        {
            double area = Length * Width;
            return area;
        }
        public double ComputePerimeter()
        {
            double perimeter = 2 * (Length + Width);
            return perimeter;
        }

    }
}
