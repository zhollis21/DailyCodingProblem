using System;
using System.Collections.Generic;

namespace DailyCodingProblem
{
    public class Problems1Through25
    {
        public static void Problem1()
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

				Console.WriteLine(FindSum(sum, numbers));
			}
		}

		protected static string FindSum(int sum, List<int> numbers)
		{
			// Loop through the list trying every 2 element combination
			for (int i = 0; i < numbers.Count - 1; i++)
			{
				for (int j = i + 1; j < numbers.Count; j++)
				{
					if (numbers[i] + numbers[j] == sum)
					{
						return $"Yes, {numbers[i]} + {numbers[j]} = {sum}";
					}
				}
			}

			return $"No two numbers in the listed added up to {sum}";
		}
	}
}
