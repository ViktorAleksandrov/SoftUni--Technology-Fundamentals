namespace P03.SumAdjacentEqualNumbers
{
    using System;
    using System.Linq;

    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            for (var index = 1; index < numbers.Count; index++)
            {
                if (numbers[index - 1] == numbers[index])
                {
                    numbers[index - 1] += numbers[index];

                    numbers.RemoveAt(index);

                    index = 0;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}