namespace P01.OddOccurrences
{
    using System;
    using System.Collections.Generic;

    public class OddOccurrences
    {
        public static void Main()
        {
            var elements = Console.ReadLine().ToLower().Split();

            var elementsCounts = new Dictionary<string, int>();

            foreach (var element in elements)
            {
                if (!elementsCounts.ContainsKey(element))
                {
                    elementsCounts[element] = 0;
                }

                elementsCounts[element]++;
            }

            var resultElements = new List<string>();

            foreach (var pair in elementsCounts)
            {
                var counts = pair.Value;
                var element = pair.Key;

                if (counts % 2 == 1)
                {
                    resultElements.Add(element);
                }
            }

            Console.WriteLine(string.Join(", ", resultElements));
        }
    }
}