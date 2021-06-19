using System;
using PermutationIIDomain.Models;

namespace PermutationIIConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new []{ 1, 1, 2 };
            var result = SuperArray.PermuteUnique(numbers);
            
            result.ForEach(outer => {
                Console.Write("[");
                outer.ForEach(inner => Console.Write($" {inner}, "));
                Console.WriteLine("]");
            });
        }
    }
}
