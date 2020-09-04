﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomness
{
    class Program
    {
        //Function to get random number
        static readonly Random getrandom = new Random();

        static void Main(string[] args)
        {
            for (var counter = 1; counter < 10; counter++)
                Console.WriteLine($"Random Number: {RandomNumber(counter, counter+10):N0}");
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
