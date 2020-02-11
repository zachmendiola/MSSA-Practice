using System;

namespace Date_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the month.");
            string a = Console.ReadLine();
            int m = Convert.ToInt32(a);
            Console.WriteLine("Please enter the day.");
            string b = Console.ReadLine();
            int d = Convert.ToInt32(b);
            Console.WriteLine("Please enter the year.");
            string c = Console.ReadLine();
            int y = Convert.ToInt32(c);
            Console.WriteLine("Please enter days to be added.");
            string addition = Console.ReadLine();
            int add = Convert.ToInt32(addition);
            d = d + add;
            while (d > 31)
            {
                if (m == 1 && d > 31)
                {
                    m = 2;
                    d = d - 31;
                }
                if (m == 2 && y % 4 == 0 && d > 29)
                {
                    m = 3;
                    d = d - 29;
                }
                if (m == 2 && d > 28)
                {
                    m = 3;
                    d = d - 28;
                }
                if (m == 3 && d > 31)
                {
                    m = 4;
                    d = d - 31;
                }
                if (m == 4 && d > 30)
                {
                    m = 5;
                    d = d - 30;
                }
                if (m == 5 && d > 31)
                {
                    m = 6;
                    d = d - 31;
                }
                if (m == 6 && d > 30)
                {
                    m = 7;
                    d = d - 30;
                }
                if (m == 7 && d > 31)
                {
                    m = 8;
                    d = d - 31;
                }
                if (m == 8 && d > 31)
                {
                    m = 9;
                    d = d - 31;
                }
                if (m == 9 && d > 30)
                {
                    m = 10;
                    d = d - 30;
                }
                if (m == 10 && d > 31)
                {
                    m = 11;
                    d = d - 31;
                }
                if (m == 11 && d > 30)
                {
                    m = 12;
                    d = d - 30;
                }
                if (m == 12 && d > 31)
                {
                    y = y + 1;
                    m = 1;
                    d = d - 31;
                }
            }
            Console.WriteLine(m);
            Console.WriteLine(d);
            Console.WriteLine(y);
        }
    }
}
