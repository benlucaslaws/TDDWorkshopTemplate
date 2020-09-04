using System.Collections.Generic;

namespace FizzBuzz.Logic
{
    public class FizzBuzzService
    {
        /// <summary>
        /// Creates an IEnumerable of strings representing the numbers from 1 to 100, with the following substitutions:
        /// - If the number is a multiple of 3 but not 5, return "Fizz"
        /// - If the number is a multiple of 5 but not 3, return "Buzz"
        /// - If the number is a multiple of both 3 and 5 return "FizzBuzz"
        /// - If the number is not a multiple of either 3 or 5, return the number as a string
        /// </summary>
        /// <returns>An IEnumerable containing 100 strings based on the above rules</returns>
        public IEnumerable<string> CreateFizzBuzzEnumerable()
        {
            return default(List<string>);
        }
    }
}
