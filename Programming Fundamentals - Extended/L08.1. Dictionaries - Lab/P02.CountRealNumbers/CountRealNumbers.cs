namespace P02.CountRealNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountRealNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            var numbersCounts = new SortedDictionary<double, int>();

            foreach (var num in numbers)
            {
                if (!numbersCounts.ContainsKey(num))
                {
                    numbersCounts[num] = 0;
                }

                numbersCounts[num]++;
            }

            foreach (var number in numbersCounts.Keys)
            {
                var count = numbersCounts[number];

                Console.WriteLine($"{number} -> {count}");
            }
        }
    }
}