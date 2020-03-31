using System;

namespace Interfaces
{
    class Program
    {
        // Notes:
        // Classes can take from multiple classes but only 1 interface
        // Interfaces can be used in classes to port methods without reinventing them yourself
        // Interface will work with any class that implements it
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Coffee arabica = new Coffee();
            arabica.name = "Arabica";
            arabica.strength = 5;
            Coffee darkRoast = new Coffee();
            darkRoast.name = "Dark Roast";
            darkRoast.strength = 10;
            Larry<int, Coffee> larry = new Larry<int, Coffee>();
        }
    }
    interface IComparable
    {
        public int CompareTo(Object strength);
    }
    public class Coffee : IComparable
    {
        public string name { get; set; }
        public int strength { get; set; }

        public int CompareTo(object name)
        {
            throw new NotImplementedException();
        }

        public void PrintMe()
        {
            Console.WriteLine("Hello, this is {0}.", name);
        }
    }
    // Generic class, uses two types
    public class Larry<Type1, Type2>
    {
        public Type1 Type1Prop { get; set; }
        public Type2 Type2Prop { get; set; }
    }
}
