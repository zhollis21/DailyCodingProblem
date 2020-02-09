using DailyCodingProblem;
using DailyCodingProblem.Models;
using Xunit;

namespace DailyCodingProblemUnitTests.Models
{
    public class BinaryNodeTests
    {
        [Fact]
        public void Equals_BothNodesAreNull_ReturnsEqual()
        {
            BinaryNode n1 = null;
            BinaryNode n2 = null;

            Assert.True(n1 == n2);
            Assert.False(n1 != n2);
        }

        [Fact]
        public void Equals_N1IsNullButN2IsNotNull_ReturnsNotEqual()
        {
            BinaryNode n1 = new BinaryNode(0);
            BinaryNode n2 = null;

            Assert.False(n1 == n2);
            Assert.True(n1 != n2);
        }

        [Fact]
        public void Equals_N1IsNotNullButN2IsNull_ReturnsNotEqual()
        {
            BinaryNode n1 = null;
            BinaryNode n2 = new BinaryNode(0);

            Assert.False(n1 == n2);
            Assert.True(n1 != n2);
        }

        [Fact]
        public void Equals_BothNodesAreDefaultNodes_ReturnsEqual()
        {
            BinaryNode n1 = new BinaryNode(0);
            BinaryNode n2 = new BinaryNode(0);

            Assert.True(n1 == n2);
            Assert.False(n1 != n2);
        }

        [Fact]
        public void Equals_N1ValueIsDifferentThanN2Value_ReturnsNotEqual()
        {
            BinaryNode n1 = new BinaryNode(1);
            BinaryNode n2 = new BinaryNode(2);

            Assert.False(n1 == n2);
            Assert.True(n1 != n2);
        }

        [Fact]
        public void Equals_ValueIsTheSameForBoth_ReturnsEqual()
        {
            BinaryNode n1 = new BinaryNode(21);
            BinaryNode n2 = new BinaryNode(21);

            Assert.True(n1 == n2);
            Assert.False(n1 != n2);
        }

        [Fact]
        public void Equals_N1AndN2HaveDifferentGrandChildren_ReturnsNotEqual()
        {
            // Grandchildren
            BinaryNode n1Grandchild = new BinaryNode(1);
            BinaryNode n2Grandchild = new BinaryNode(2);

            // Children
            BinaryNode n1Child = new BinaryNode(21, n1Grandchild, null);
            BinaryNode n2Child = new BinaryNode(21, n2Grandchild, null);

            // Root
            BinaryNode n1 = new BinaryNode(21, null, n1Child);
            BinaryNode n2 = new BinaryNode(21, null, n2Child);

            Assert.False(n1 == n2);
            Assert.True(n1 != n2);
        }

        [Fact]
        public void Equals_N1AndN2HaveMatchingGrandChildren_ReturnsEqual()
        {
            // Grandchildren
            BinaryNode n1Grandchild = new BinaryNode(21);
            BinaryNode n2Grandchild = new BinaryNode(21);

            // Children
            BinaryNode n1Child = new BinaryNode(21, n1Grandchild, null);
            BinaryNode n2Child = new BinaryNode(21, n2Grandchild, null);

            // Root
            BinaryNode n1 = new BinaryNode(21, null, n1Child);
            BinaryNode n2 = new BinaryNode(21, null, n2Child);

            Assert.True(n1 == n2);
            Assert.False(n1 != n2);
        }
    }
}
