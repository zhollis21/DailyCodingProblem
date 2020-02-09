using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DailyCodingProblem.Models
{
    public class BinaryNode
    {
        public int Value { get; set; }

        public BinaryNode LeftChild { get; set; }

        public BinaryNode RightChild { get; set; }

        public BinaryNode()
        {
        }

        public BinaryNode(int value)
        {
            Value = value;
            LeftChild = null;
            RightChild = null;
        }

        public BinaryNode(int value, BinaryNode leftChild, BinaryNode rightChild)
        {
            Value = value;
            LeftChild = leftChild;
            RightChild = rightChild;
        }

        /// <summary>
        /// This will recursively compare the nodes and their children.
        /// </summary>
        public override bool Equals(object obj)
        {
            BinaryNode otherNode = (BinaryNode)obj;

            if (otherNode == null || 
                this.Value != otherNode.Value || 
                this.LeftChild != otherNode.LeftChild || 
                this.RightChild != otherNode.RightChild)
                return false;

            return true;
        }

        public static bool operator ==(BinaryNode n1, BinaryNode n2)
        {
            // If n1 is null, then n2 should be null too
            if (ReferenceEquals(n1, null))
                return ReferenceEquals(n2, null);

            return n1.Equals(n2);
        }

        public static bool operator !=(BinaryNode n1, BinaryNode n2)
        {
            return !(n1 == n2);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}
