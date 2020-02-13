using DailyCodingProblem;
using Xunit;
using System.Collections.Generic;
using DailyCodingProblem.Models;

namespace DailyCodingProblemUnitTests
{
    public class Problems1Through25Tests
    {
        #region Problem 1

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
        public void Problem1_RangeOfSums_ReturnsExpectedBool(int sum, bool expectedResult)
        {
            int[] numbers = new int[] { 10, 15, 3, 7 };

            bool actualResult = Problems1Through25.Problem1(numbers, sum);

            Assert.Equal(expectedResult, actualResult);
        }

        #endregion

        #region Problem 2

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 120, 60, 40, 30, 24 })]
        [InlineData(new int[] { 5, 4, 3, 2, 1 }, new int[] { 24, 30, 40, 60, 120 })]
        [InlineData(new int[] { 3, 2, 1 }, new int[] { 2, 3, 6 })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 6, 3, 2 })]
        public void Problem2_HappyPath_ReturnsExpectedIntArray(int[] input, int[] expectedResult)
        {
            List<int> actualResult = Problems1Through25.Problem2(input);

            Assert.Equal(expectedResult, actualResult);
        }

        #endregion

        #region Problem 3

        [Fact]
        public void Problem3Serialize_RootIsNull_ReturnsExpectedString()
        {
            const string expected = "null,";

            BinaryNode nodeTree = null;

            string serializedNodeTree = Problems1Through25.Problem3Serialize(nodeTree);

            Assert.Equal(expected, serializedNodeTree);
        }

        [Fact]
        public void Problem3Serialize_RootOnlyTree_ReturnsExpectedString()
        {
            const string expected = "0,null,null,";

            var nodeTree = new BinaryNode(0);

            string serializedNodeTree = Problems1Through25.Problem3Serialize(nodeTree);

            Assert.Equal(expected, serializedNodeTree);
        }

        [Fact]
        public void Problem3Serialize_Partial2LayeredTree_ReturnsExpectedString()
        {
            const string expected = "0,null,2,null,null,";

            var nodeTree =
                new BinaryNode(
                    0,
                    null,
                    new BinaryNode(2));

            string serializedNodeTree = Problems1Through25.Problem3Serialize(nodeTree);

            Assert.Equal(expected, serializedNodeTree);
        }

        [Fact]
        public void Problem3Serialize_Full2LayeredTree_ReturnsExpectedString()
        {
            const string expected = "0,1,null,null,2,null,null,";

            var nodeTree =
                new BinaryNode(
                    0,
                    new BinaryNode(1),
                    new BinaryNode(2));

            string serializedNodeTree = Problems1Through25.Problem3Serialize(nodeTree);

            Assert.Equal(expected, serializedNodeTree);
        }

        [Fact]
        public void Problem3Serialize_Partial3LayeredTree_ReturnsExpectedString()
        {
            const string expected = "0,1,11,null,null,null,2,null,null,";

            var nodeTree =
                new BinaryNode(
                    0,
                    new BinaryNode(
                        1,
                        new BinaryNode(11),
                        null),
                    new BinaryNode(2));

            string serializedNodeTree = Problems1Through25.Problem3Serialize(nodeTree);

            Assert.Equal(expected, serializedNodeTree);
        }

        [Fact]
        public void Problem3Serialize_Full3LayeredTree_ReturnsExpectedString()
        {
            const string expected = "0,1,11,null,null,12,null,null,2,21,null,null,22,null,null,";

            var nodeTree =
                new BinaryNode(
                    0,
                    new BinaryNode(
                        1,
                        new BinaryNode(11),
                        new BinaryNode(12)),
                    new BinaryNode(
                        2,
                        new BinaryNode(21),
                        new BinaryNode(22)));

            string serializedNodeTree = Problems1Through25.Problem3Serialize(nodeTree);

            Assert.Equal(expected, serializedNodeTree);
        }

        [Fact]
        public void Problem3Deserialize_RootIsNull_ReturnsExpectedString()
        {
            BinaryNode expectedNodeTree = null;

            const string serializedNodeTree = "null,";

            BinaryNode deserializedNodeTree = Problems1Through25.Problem3Deserialize(serializedNodeTree);

            Assert.Equal(expectedNodeTree, deserializedNodeTree);
        }

        [Fact]
        public void Problem3Deserialize_RootOnlyTree_ReturnsExpectedString()
        {
            var expectedNodeTree = new BinaryNode(0);

            const string serializedNodeTree = "0,null,null,";

            BinaryNode deserializedNodeTree = Problems1Through25.Problem3Deserialize(serializedNodeTree);

            Assert.Equal(expectedNodeTree, deserializedNodeTree);
        }

        [Fact]
        public void Problem3Deserialize_Partial2LayeredTree_ReturnsExpectedString()
        {
            var expectedNodeTree =
                new BinaryNode(
                    0,
                    null,
                    new BinaryNode(2));

            const string serializedNodeTree = "0,null,2,null,null,";

            BinaryNode deserializedNodeTree = Problems1Through25.Problem3Deserialize(serializedNodeTree);

            Assert.Equal(expectedNodeTree, deserializedNodeTree);
        }

        [Fact]
        public void Problem3Deserialize_Full2LayeredTree_ReturnsExpectedString()
        {
            var expectedNodeTree =
                new BinaryNode(
                    0,
                    new BinaryNode(1),
                    new BinaryNode(2));

            const string serializedNodeTree = "0,1,null,null,2,null,null,";

            BinaryNode deserializedNodeTree = Problems1Through25.Problem3Deserialize(serializedNodeTree);

            Assert.Equal(expectedNodeTree, deserializedNodeTree);
        }

        [Fact]
        public void Problem3Deserialize_Partial3LayeredTree_ReturnsExpectedString()
        {
            var expectedNodeTree =
                new BinaryNode(
                    0,
                    new BinaryNode(
                        1,
                        new BinaryNode(11),
                        null),
                    new BinaryNode(2));

            const string serializedNodeTree = "0,1,11,null,null,null,2,null,null,";

            BinaryNode deserializedNodeTree = Problems1Through25.Problem3Deserialize(serializedNodeTree);

            Assert.Equal(expectedNodeTree, deserializedNodeTree);
        }

        [Fact]
        public void Problem3Deserialize_Full3LayeredTree_ReturnsExpectedString()
        {
            var expectedNodeTree =
                new BinaryNode(
                    0,
                    new BinaryNode(
                        1,
                        new BinaryNode(11),
                        new BinaryNode(12)),
                    new BinaryNode(
                        2,
                        new BinaryNode(21),
                        new BinaryNode(22)));

            const string serializedNodeTree = "0,1,11,null,null,12,null,null,2,21,null,null,22,null,null,";

            BinaryNode deserializedNodeTree = Problems1Through25.Problem3Deserialize(serializedNodeTree);

            Assert.Equal(expectedNodeTree, deserializedNodeTree);
        }

        #endregion

        #region Problem 4

        [Theory]
        [InlineData(new int[] { 3, 4, -1, 1 }, 2)]
        [InlineData(new int[] { 1, 2, 0 }, 3)]
        [InlineData(new int[] { }, 1)]
        [InlineData(new int[] { 1, 2, 3, 7, 8, 9, 5, 4 }, 6)]
        [InlineData(new int[] { -7, 8, -9, int.MaxValue, int.MinValue }, 1)]
        public void Problem4_HappyPath_ReturnsExpectedInt(int[] input, int expectedResult)
        {
            int actualResult = Problems1Through25.Problem4(input);

            Assert.Equal(expectedResult, actualResult);
        }

        #endregion

        #region Problem 5

        [Theory]
        [InlineData(3, 4)]
        [InlineData(4, 3)]
        [InlineData(-3, -4)]
        [InlineData(0, 0)]
        [InlineData(int.MaxValue, int.MinValue)]
        public void Problem5GetFirst_HappyPath_ReturnsExpectedInt(int first, int last)
        {
            var pair = new Pair(first, last);

            var actual = Problems1Through25.Problem5GetFirst(pair);

            Assert.Equal(first, actual);
        }

        [Theory]
        [InlineData(3, 4)]
        [InlineData(4, 3)]
        [InlineData(-3, -4)]
        [InlineData(0, 0)]
        [InlineData(int.MaxValue, int.MinValue)]
        public void Problem5GetLast_HappyPath_ReturnsExpectedInt(int first, int last)
        {
            var pair = new Pair(first, last);

            var actual = Problems1Through25.Problem5GetLast(pair);

            Assert.Equal(last, actual);
        }

        #endregion

        #region Problem 6

        [Theory]
        [InlineData(255, 255, 255, "FFFFFF")]
        [InlineData(255, 256, 300, "FFFFFF")]
        [InlineData(0, 0, 0, "000000")]
        [InlineData(148, 0, 211, "9400D3")]
        [InlineData(148, -1, 211, "9400D3")]
        [InlineData(144, 195, 212, "90C3D4")]
        [InlineData(212, 53, 12, "D4350C")]
        public void Problem6_HappyPath_ReturnsExpectedString(int r, int g, int b, string expectedResult)
        {
            string actualResult = Problems1Through25.Problem6(r, g, b);

            Assert.Equal(expectedResult, actualResult);
        }

        #endregion
    }
}
