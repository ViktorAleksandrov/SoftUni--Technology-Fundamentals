namespace P12.CountOccurrencesOfLargerNumbersInArray
{
    using System;
    using System.Linq;

    public class CountOccurrencesOfLargerNumbersInArray
    {
        private static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            var givenElement = double.Parse(Console.ReadLine());

            var counter = 0;

            foreach (var num in numbers)
            {
                if (num > givenElement)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}