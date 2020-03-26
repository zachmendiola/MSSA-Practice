using System;

namespace Mod_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        Coffee coffee1 = new Coffee();
        public struct Coffee
        {
            public EventArgs e;
            public delegate void OutOfBeansHandler(Coffee coffee, EventArgs args);
            public event OutOfBeansHandler OutOfBeans;

            int currentStockLevel;
            int minimumStockLevel;
            public void MakeCoffee()
            {
                currentStockLevel--;
                if (currentStockLevel < minimumStockLevel)
                if (OutOfBeans != null)
                {
                    OutOfBeans(this, e);
                }
            }
            public void HandleOutOfBeans(Coffee c, EventArgs e)
            {
                Console.WriteLine("You fill the bean container with a new box.");
                currentStockLevel += 10;
            }
        }

    }
}
