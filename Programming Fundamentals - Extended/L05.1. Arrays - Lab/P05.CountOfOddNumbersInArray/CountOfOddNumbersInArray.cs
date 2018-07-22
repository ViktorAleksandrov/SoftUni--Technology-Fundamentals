namespace P05.CountOfOddNumbersInArray
{
    using System;
    using System.Linq;

    public class CountOfOddNumbersInArray
    {
        private static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var oddsCounter = numbers.Count(num => num % 2 != 0);

            Console.WriteLine(oddsCounter);
        }
    }
}