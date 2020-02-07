using System;
using System.Collections.Generic;

namespace DailyCodingProblem
{
    public class Problems1Through25
    {
        public static void UI_Problem1()
        {
			List<int> numbers = new List<int>() { 1, 2, 4, 5, 8, 9 };

			while (true)
			{
				Console.WriteLine($"\nThe list is: {string.Join(", ", numbers)}");
				Console.Write("Please enter a sum: ");

				int sum;
				while (!int.TryParse(Console.ReadLine(), out sum))
				{
					Console.Write("Error... Please enter a valid integer: ");
				}

				Problem1(numbers, sum);
			}
		}

		/// <summary>
		/// Given a list of numbers and a number k, return whether 
		/// any two numbers from the list add up to k. 
		/// 
		/// For example, given[10, 15, 3, 7] and k of 17, 
		/// return true since 10 + 7 is 17.
		/// </summary>
		protected static bool Problem1(List<int> numbers, int sum)
		{
			// Loop through the list trying every 2 element combination
			for (int i = 0; i < numbers.Count - 1; i++)
			{
				for (int j = i + 1; j < numbers.Count; j++)
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

		public static void UI_Problem2()
		{
			var numbers1 = new List<int>() { 1, 2, 3, 4, 5 };
			var numbers2 = new List<int>() { 3, 2, 1 };

			var productList1 = Problem2(numbers1);
			var productList2 = Problem2(numbers2);

			Console.WriteLine($"[{string.Join(", ", numbers1)}] -> [{string.Join(", ", productList1)}]\n");
			Console.WriteLine($"[{string.Join(", ", numbers2)}] -> [{string.Join(", ", productList2)}]");
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
		protected static List<int> Problem2(List<int> numbers)
		{
			var productList = new List<int>();

			for (int i = 0; i < numbers.Count; i++)
			{
				productList.Add(1);

				for (int j = 0; j < numbers.Count; j++)
				{
					if (j == i)
						continue;

					productList[i] *= numbers[j];
				}
			}

			return productList;
		}
	}
}
