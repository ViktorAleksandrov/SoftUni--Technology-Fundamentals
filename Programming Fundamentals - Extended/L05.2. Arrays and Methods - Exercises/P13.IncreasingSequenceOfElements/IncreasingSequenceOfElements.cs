namespace P13.IncreasingSequenceOfElements
{
    using System;
    using System.Linq;

    public class IncreasingSequenceOfElements
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (var index = 0; index < numbers.Length - 1; index++)
            {
                var currentNumber = numbers[index];
                var nextNumber = numbers[index + 1];

                if (nextNumber <= currentNumber)
                {
                    Console.WriteLine("No");

                    return;
                }
            }

            Console.WriteLine("Yes");
        }
    }
}