namespace P03.SmallestElementInArray
{
    using System;

    public class SmallestElementInArray
    {
        private static void Main()
        {
            var input = Console.ReadLine().Split();

            var numbers = new int[input.Length];

            var smallestElement = int.Parse(input[0]);

            for (var index = 1; index < numbers.Length; index++)
            {
                numbers[index] = int.Parse(input[index]);

                var currentNumber = numbers[index];

                if (currentNumber < smallestElement)
                {
                    smallestElement = currentNumber;
                }
            }

            Console.WriteLine(smallestElement);
        }
    }
}