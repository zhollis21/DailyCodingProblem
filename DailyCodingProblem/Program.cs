using DailyCodingProblem.Models;
using System;

namespace DailyCodingProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Run the unit tests...");

            var nodeTree =
                new BinaryNode(
                    0,
                    new BinaryNode(
                        1,
                        new BinaryNode(11),
                        null),
                    new BinaryNode(2));

            var ser = Problems1Through25.Problem3Serialize(nodeTree);
            Console.WriteLine(ser);

            var deser = Problems1Through25.Problem3Deserialize(ser);
            Console.WriteLine(nodeTree == deser);
        }
    }
}
