namespace P03.RageQuit
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class RageQuit
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToUpper();

            var strings = Regex.Split(input, @"\d+")
                .Where(s => s.Length > 0)
                .ToArray();

            var numbers = Regex.Split(input, @"\D+")
                .Where(s => s.Length > 0)
                .Select(int.Parse)
                .ToArray();

            var result = new StringBuilder();

            for (var index = 0; index < strings.Length; index++)
            {
                var repetitionCount = numbers[index];
                var currentElement = strings[index];

                for (var cnt = 0; cnt < repetitionCount; cnt++)
                {
                    result.Append(currentElement);
                }
            }

            var uniqueElementsCount = result
                .ToString()
                .Distinct()
                .Count();

            Console.WriteLine($"Unique symbols used: {uniqueElementsCount}");
            Console.WriteLine(result.ToString());
        }
    }
}