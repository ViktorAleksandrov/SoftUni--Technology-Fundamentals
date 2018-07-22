namespace P04.SortArrayUsingBubbleSort
{
    using System;
    using System.Linq;

    public class SortArrayUsingBubbleSort
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var isSwapped = false;

            do
            {
                isSwapped = false;

                for (var index = 0; index < numbers.Length - 1; index++)
                {
                    if (numbers[index] > numbers[index + 1])
                    {
                        var temp = numbers[index];
                        numbers[index] = numbers[index + 1];
                        numbers[index + 1] = temp;

                        isSwapped = true;
                    }
                }
            }
            while (isSwapped);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}