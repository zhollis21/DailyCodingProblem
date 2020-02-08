using DailyCodingProblem;
using Xunit;
using System.Linq;
using System.Collections.Generic;

namespace DailyCodingProblemUnitTests
{
    public class Problems1Through25Tests : Problems1Through25
    {
        [Theory]
        [InlineData(9, false)]
        [InlineData(10, true)]
        [InlineData(11, false)]
        [InlineData(12, false)]
        [InlineData(13, true)]
        [InlineData(14, false)]
        [InlineData(15, false)]
        [InlineData(16, false)]
        [InlineData(17, true)]
        [InlineData(18, true)]
        [InlineData(19, false)]
        [InlineData(20, false)]
        [InlineData(21, false)]
        [InlineData(22, true)]
        [InlineData(23, false)]
        [InlineData(24, false)]
        [InlineData(25, true)]
        [InlineData(26, false)]
        public void Problem1_HappyPath_ReturnsCorrectList(int sum, bool expectedResult)
        {
            int[] numbers = new int[] { 10, 15, 3, 7 };

            bool actualResult = Problem1(numbers.ToList(), sum);

            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 120, 60, 40, 30, 24 })]
        [InlineData(new int[] { 5, 4, 3, 2, 1 }, new int[] { 24, 30, 40, 60, 120 })]
        [InlineData(new int[] { 3, 2, 1 }, new int[] { 2, 3, 6 })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 6, 3, 2 })]
        public void Problem2_HappyPath_ReturnsCorrectList(int[] input, int[] expectedResult)
        {
            List<int> actualResult = Problem2(input.ToList());

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
