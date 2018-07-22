namespace P14.EqualSequenceOfElementsInArray
{
    using System;
    using System.Linq;

    public class EqualSequenceOfElementsInArray
    {
        private static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (var index = 0; index < numbers.Length - 1; index++)
            {
                var currentNumber = numbers[index];
                var nextNumber = numbers[index + 1];

                if (currentNumber != nextNumber)
                {
                    Console.WriteLine("No");

                    return;
                }
            }

            Console.WriteLine("Yes");
        }
    }
}