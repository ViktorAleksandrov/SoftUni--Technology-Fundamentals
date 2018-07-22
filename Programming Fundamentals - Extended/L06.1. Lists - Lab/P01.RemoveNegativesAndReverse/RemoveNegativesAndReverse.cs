namespace P01.RemoveNegativesAndReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveNegativesAndReverse
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var results = new List<int>();

            for (var index = numbers.Count - 1; index >= 0; index--)
            {
                var currentNumber = numbers[index];

                if (currentNumber >= 0)
                {
                    results.Add(currentNumber);
                }
            }

            Console.WriteLine(
                results.Any()
                ? string.Join(" ", results)
                : "empty");
        }
    }
}