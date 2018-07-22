namespace P02.ArrayElementsEqualToTheirIndex
{
    using System;
    using System.Linq;

    public class ArrayElementsEqualToTheirIndex
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (var index = 0; index < numbers.Length; index++)
            {
                var currentNumber = numbers[index];

                if (currentNumber == index)
                {
                    Console.Write(currentNumber + " ");
                }
            }

            Console.WriteLine();
        }
    }
}