using System;

namespace assignment
{
    class Solution
    {
        static void Main(string[] args)
        {
            //The first section initializes the loop and declares the variable i.
            //The second section sets the loop to reiterate until a condition is met, in this case when i < 5.
            //The third section establishes the incrementation of the loop, the notation 'i++' is basically i + 1.
            for (int i = 0; i < 5; i++)
            {
                //This line will write the value of the variable i during each iteration of the loop. This will basically act as a counter from 0-4, since the loop stops at 5.
                Console.WriteLine(i);
                //This loop will be broken when 'i' is incremented to 5.
            }

            //The first section in this loop declares the variable higher than the previous loop.
            //The second section also sets the condition opposite to the previous loop.
            //The third section decrements instead of increments.
            for (int i = 20; i > 0; i--)
            {
                //This line will write the value of the variable 'i' during each iteration. This loop is different from the previous loop because it will act as a countdown, not a counter.
                Console.WriteLine(i);
                //This loop will be broken when 'i' is decremented to 0.
            }

            //This line declares the variable before the start of the loop.
            int n = 0;
            //This line means that while the loop meets this condition, it will continue. In this case it is when n < 5.
            while (n < 5)
            {
                //This line will write the value of the variable 'n' during each iteration. This loop will effective function as a counter in the console.
                Console.WriteLine(n);
                //This line increments the variable 'n' after each iteration.
                n++;
                //After the fifth iteration, 'n' will increment to 5, where it will not meet the criteria to continue the loop. The loop will then end.
            }
            
            //This line sets the variable 'j' as 0.
            int j = 0;
            //This line means that while 'j' is less than 10, the loop will continue.
            while(j < 10)
            {
                //This loop differs in that it uses string to let the user know what the value of 'j' is, instead of assuming the user knows what is being printed into the console.
                Console.WriteLine("Value of j: {0}", j);
                //This line increments the variable 'j' by one each iteration.
                j++;
                //This loop will be broken when j is incremented to 10.
            }

            //References: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/for, https://www.tutorialsteacher.com/csharp/csharp-while-loop, https://www.w3schools.com/cs/cs_while_loop.asp,
            //References: https://www.w3schools.com/cs/cs_for_loop.asp
        }
    }
}
