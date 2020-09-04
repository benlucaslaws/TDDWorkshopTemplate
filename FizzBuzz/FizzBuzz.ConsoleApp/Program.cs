using System;
using FizzBuzz.Logic;

namespace FizzBuzz.ConsoleApp
{
    class Program
    {
        /// <summary>
        /// Basic FizzBuzz implementation. Iterates from 1 to 100, printing "Fizz" for multiples of 3,
        /// "Buzz" for multiples of 5, "FizzBuzz" for multiples of both 3 and 5, or the
        /// number itself if it is not a multiple of either 3 or 5.
        /// </summary>
        static void Main()
        {
            var fizzBuzzService = new FizzBuzzService();
            var fizzBuzzStrings = fizzBuzzService.CreateFizzBuzzEnumerable();

            foreach (var fizzBuzzString in fizzBuzzStrings)
            {
                Console.WriteLine(fizzBuzzString);
            }

            Console.WriteLine("Complete! Press any key to exit...");
            Console.ReadKey();
        }
    }
}
