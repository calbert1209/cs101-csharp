using System;
using Xunit;
using cs101;
using System.Collections.Generic;

namespace cs101Tests
{
    public class SorterTests
    {
        private List<int> GenerateRandomInts(int count, int min, int max)
        {
            var output = new List<int>();
            var rdm = new Random();
            for (var i = 0; i < count; i++)
            {
                output.Add(rdm.Next(min, max));
            }
            return output;
        }

        [Fact]
        public void ShouldReturnMergeSortedArray() 
        {
            var testList = GenerateRandomInts(10, 1, 13);
            var expected = new List<int>(testList);
            expected.Sort();
            var actual = Sorter.MergeSort(testList);
            Assert.Equal(expected, actual);
        }
    }
}