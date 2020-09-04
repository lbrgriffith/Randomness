using System;

namespace Randomness
{
    class Program
    {
        //Function to get random number
        static readonly Random getrandom = new Random();

        static void Main(string[] args)
        {
            for (var counter = 1; counter < 10; counter++)
                Console.WriteLine($"Random Number (between {counter},{counter + 10}): {RandomNumber(counter, counter+10):N0}");

            Console.WriteLine("\nPress <Enter> to exit.");
            Console.ReadLine();
        }

        static int RandomNumber(int min, int max)
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(min, max);
            }
        }
    }
}
