using System.Collections.Generic;
using PermutationIIDomain.Models;
using Xunit;

namespace PermutationIITests.Models
{
    public class SuperArrayTests
    {
        [Fact]
        public void PermuteUnique_Should_Return_Unique_Permutations()
        {
            var numbers = new []{ 1, 1, 2 };
            var expectedResult = new List<List<int>>
            {
                new List<int> { 1, 1, 2 },
                new List<int> { 1, 2, 1 },
                new List<int> { 2, 1, 1 }
            };

            var result = SuperArray.PermuteUnique(numbers);

            Assert.Equal(result, expectedResult);
        }
    }
}