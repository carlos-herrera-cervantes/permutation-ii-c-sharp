using System.Collections.Generic;
using System.Linq;

namespace PermutationIIDomain.Models
{
    public class SuperArray
    {
        /// <summary>Returns the unique permutations of numbers</summary>
        /// <param name="numbers">Array of numbers</param>
        /// <returns>List of lists</returns>
        public static List<List<int>> PermuteUnique(int[] numbers)
        {
            var list = new List<List<int>>();
            Permute(numbers, 0, numbers.Length, list);
            return list;
        }

        /// <summary>Creates the permutations</summary>
        /// <param name="numbers">Array of numbers</param>
        /// <param name="list">List of lists</param>
        private static void Permute(int[] numbers, int i, int n, List<List<int>> list)
        {
            if (i == n - 1)
            {
                list.Add(numbers.ToList());
                return;
            }

            foreach (int j in Enumerable.Range(i, n - 1))
            {
                if (i < j && numbers[i] == numbers[j]) continue;

                int temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;

                Permute(numbers, i + 1, n, list);
            }
        }
    }
}