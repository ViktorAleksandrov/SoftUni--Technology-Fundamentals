namespace P04.Shellbound
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Shellbound
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();

            var shellsData = new Dictionary<string, HashSet<int>>();

            while (input[0] != "Aggregate")
            {
                var city = input[0];
                var shellSize = int.Parse(input[1]);

                if (!shellsData.ContainsKey(city))
                {
                    shellsData[city] = new HashSet<int>();
                }

                shellsData[city].Add(shellSize);

                input = Console.ReadLine().Split();
            }

            foreach (var city in shellsData.Keys)
            {
                var shellsSizes = shellsData[city];

                var shellsSum = shellsData[city].Sum();
                var shellsAverage = shellsData[city].Average();

                var giantShell = shellsSum - shellsAverage;

                Console.WriteLine(
                    $"{city} -> {string.Join(", ", shellsSizes)} ({giantShell:f0})");
            }
        }
    }
}