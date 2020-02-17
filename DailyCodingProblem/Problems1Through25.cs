using DailyCodingProblem.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem
{
    public class Problems1Through25
    {
        /// <summary>
        /// Given a list of numbers and a number k, return whether 
        /// any two numbers from the list add up to k. 
        /// 
        /// For example, given[10, 15, 3, 7] and k of 17, 
        /// return true since 10 + 7 is 17.
        /// </summary>
        public static bool Problem1(int[] numbers, int sum)
        {
            // Loop through the list trying every 2 element combination
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == sum)
                    {
                        Console.WriteLine($"Yes, {numbers[i]} + {numbers[j]} = {sum}");
                        return true;
                    }
                }
            }

            Console.WriteLine($"No two numbers in the listed added up to {sum}");
            return false;
        }

        /// <summary>
        /// Given an array of integers, return a new array such that each element 
        /// at index i of the new array is the product of all the numbers in the 
        /// original array except the one at i.
        /// 
        /// For example, if our input was [1, 2, 3, 4, 5], the expected output would 
        /// be [120, 60, 40, 30, 24]. If our input was [3, 2, 1], the expected output 
        /// would be [2, 3, 6].
        /// </summary>
        public static List<int> Problem2(int[] numbers)
        {
            var productList = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                productList.Add(1);

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (j == i)
                        continue;

                    productList[i] *= numbers[j];
                }
            }

            return productList;
        }

        public static string Problem3Serialize(BinaryNode node)
        {
            if (node == null)
                return "null,";

            string serializedNode = node.Value + ",";

            serializedNode += Problem3Serialize(node.LeftChild);

            serializedNode += Problem3Serialize(node.RightChild);

            return serializedNode;
        }

        public static BinaryNode Problem3Deserialize(string serializedBinaryTree)
        {
            string[] values = serializedBinaryTree.Split(',');

            DeserializeBinaryTree(out BinaryNode deserializedBinaryTree, values, 0);

            return deserializedBinaryTree;
        }

        private static int DeserializeBinaryTree(out BinaryNode currentNode, string[] values, int index)
        {
            int nodeValue;
            if (!int.TryParse(values[index], out nodeValue))
            {
                currentNode = null;
                return index;
            }

            index = DeserializeBinaryTree(out BinaryNode leftNode, values, index + 1);
            index = DeserializeBinaryTree(out BinaryNode rightNode, values, index + 1);

            currentNode = new BinaryNode(nodeValue, leftNode, rightNode);

            return index;
        }

        /// <summary>
        /// Given an array of integers, find the first missing positive integer in 
        /// linear time and constant space. In other words, find the lowest positive 
        /// integer that does not exist in the array. The array can contain duplicates 
        /// and negative numbers as well.
        /// 
        /// For example, the input[3, 4, -1, 1] should give 2. The input[1, 2, 0] should give 3.
        /// </summary>
        public static int Problem4(int[] numbers)
        {
            for (int positiveInteger = 1; positiveInteger <= int.MaxValue; positiveInteger++)
            {
                if (!numbers.Contains(positiveInteger))
                {
                    return positiveInteger;
                }
            }

            // If we reach this point then we tried every positive 32-bit integer
            return -1;
        }

        /// <summary>
        /// Returns the first element in a Pair.
        /// </summary>
        public static int Problem5GetFirst(Pair pair)
        {
            return pair.A;
        }

        /// <summary>
        /// Returns the last element in a Pair.
        /// </summary>
        public static int Problem5GetLast(Pair pair)
        {
            return pair.B;
        }

        /// <summary>
        /// Converts byte RGB values to their Hexadecimal equivalent. 
        /// Any RGB values that are outside of the byte range will be 
        /// rounded to the closest valid byte value.
        /// 
        /// For example, the input (-5, 148, 300) would return "0094FF".
        /// </summary>
        public static string Problem6(int r, int g, int b)
        {
            return $"{ToByteRange(r):X2}{ToByteRange(g):X2}{ToByteRange(b):X2}";
        }

        private static int ToByteRange(int x)
        {
            if (x < 0)
                return 0;

            if (x > 255)
                return 255;

            return x;
        }
    }
}
