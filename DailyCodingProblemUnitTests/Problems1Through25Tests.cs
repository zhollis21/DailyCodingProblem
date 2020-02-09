using DailyCodingProblem;
using Xunit;
using System.Linq;
using System.Collections.Generic;
using DailyCodingProblem.Models;

namespace DailyCodingProblemUnitTests
{
    public class Problems1Through25Tests
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

            bool actualResult = Problems1Through25.Problem1(numbers.ToList(), sum);

            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 120, 60, 40, 30, 24 })]
        [InlineData(new int[] { 5, 4, 3, 2, 1 }, new int[] { 24, 30, 40, 60, 120 })]
        [InlineData(new int[] { 3, 2, 1 }, new int[] { 2, 3, 6 })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 6, 3, 2 })]
        public void Problem2_HappyPath_ReturnsCorrectList(int[] input, int[] expectedResult)
        {
            List<int> actualResult = Problems1Through25.Problem2(input.ToList());

            Assert.Equal(expectedResult, actualResult);
        }

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
    }
}
