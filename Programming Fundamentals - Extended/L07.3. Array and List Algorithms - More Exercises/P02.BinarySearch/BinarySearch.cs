namespace P02.BinarySearch
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BinarySearch
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var numberToFind = int.Parse(Console.ReadLine());

            var linearSearchIterations = LinearSearchMethod(numbers, numberToFind);

            var binarySearchIterations = BinarySearchMethod(numbers, numberToFind);

            Console.WriteLine(numbers.Contains(numberToFind) ? "Yes" : "No");
            Console.WriteLine($"Linear search made {linearSearchIterations} iterations");
            Console.WriteLine($"Binary search made {binarySearchIterations} iterations");
        }

        private static int LinearSearchMethod(List<int> numbers, int numberToFind)
        {
            var iterations = 0;

            foreach (var num in numbers)
            {
                iterations++;

                if (num == numberToFind)
                {
                    break;
                }
            }

            return iterations;
        }

        private static int BinarySearchMethod(List<int> numbers, int numberToFind)
        {
            numbers.Sort();

            var iterations = 0;

            var startIndex = 0;
            var endIndex = numbers.Count - 1;

            while (startIndex <= endIndex)
            {
                iterations++;

                var midpoint = (startIndex + endIndex) / 2;

                if (numbers[midpoint] < numberToFind)
                {
                    startIndex = midpoint + 1;
                }

                if (numbers[midpoint] > numberToFind)
                {
                    endIndex = midpoint - 1;
                }

                if (numbers[midpoint] == numberToFind)
                {
                    break;
                }
            }

            return iterations;
        }
    }
}