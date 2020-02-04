using System;

namespace Multiple_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encasing for loop that contains the larger iterations and increments each time the counter goes up and down.
            for (int j = 0; j < 5; j++)
            {
                //For loop that counts up to 10.
                for (int i = 0; i <= 10; i++)
                {
                    //Prints value of 'i' to console.
                    Console.WriteLine(i);
                }
                //For loop that counts down to 0.
                for (int i = 10; i >= 0; i--)
                {
                    //Prints value of 'i' to console.
                    Console.WriteLine(i);
                }
            }
        }
    }
}
