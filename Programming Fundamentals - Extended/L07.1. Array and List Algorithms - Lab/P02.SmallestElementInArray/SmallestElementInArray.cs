namespace P03.SmallestElementInArray
{
    using System;
    using System.Linq;

    public class SmallestElementInArray
    {
        private static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var smallestElement = numbers[0];

            foreach (var num in numbers)
            {
                if (num < smallestElement)
                {
                    smallestElement = num;
                }
            }

            Console.WriteLine(smallestElement);
        }
    }
}