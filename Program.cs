using System;
using System.Linq;

namespace Randomness
{
    class Program
    {
        //Function to get random number
        static readonly Random random = new Random();

        static void Main(string[] args)
        {
            for (var counter = 1; counter < 10; counter++)
                Console.WriteLine($"Random Number (between {counter},{counter + 10}): {RandomNumber(counter, counter+10):N0}");

            for (var counter = 1; counter < 10; counter++)
                Console.WriteLine($"Random Text (length: {counter}) => {RandomText(counter)}");

            Console.WriteLine("\nPress <Enter> to exit.");
            Console.ReadLine();
        }

        #region Numbers

        /// <summary>
        /// Generates a random integer number 
        /// </summary>
        /// <param name="min">Minimum number</param>
        /// <param name="max">Maximum number</param>
        /// <returns>Returns a random integer within the specified range.</returns>
        static int RandomNumber(int min, int max)
        {
            lock (random) // synchronize
            {
                return random.Next(min, max);
            }
        }

        #endregion

        #region Text

        /// <summary>
        /// Generates a random alpha-numeric string based on the length specified.
        /// </summary>
        /// <param name="length">Length of alpha-numeric string to generate.</param>
        /// <returns></returns>
        static string RandomText(int length)
        {
            const string chars = 
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new String(Enumerable.Repeat(chars, length)
              .Select(sub => sub[random.Next(sub.Length)]).ToArray());
        }

        #endregion
    }
}
