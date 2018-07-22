namespace P06.OddNumbersAtOddPositions
{
    using System;
    using System.Linq;

    public class OddNumbersAtOddPositions
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (var index = 1; index < numbers.Length; index += 2)
            {
                var currentNumber = numbers[index];

                if (currentNumber % 2 != 0)
                {
                    Console.WriteLine(
                        $"Index {index} -> {currentNumber}");
                }
            }
        }
    }
}