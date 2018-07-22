namespace P11.CountOfGivenElementInArray
{
    using System;
    using System.Linq;

    public class CountOfGivenElementInArray
    {
        private static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var givenElement = int.Parse(Console.ReadLine());

            var countGivenElement = 0;

            foreach (var num in numbers)
            {
                if (num == givenElement)
                {
                    countGivenElement++;
                }
            }

            Console.WriteLine(countGivenElement);
        }
    }
}