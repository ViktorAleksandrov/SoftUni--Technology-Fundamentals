namespace P07.CountNumbers
{
    using System;
    using System.Linq;

    public class CountNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            numbers.Sort();

            var counter = 1;

            for (var index = 0; index < numbers.Count; index++)
            {
                if ((index < numbers.Count - 1 && numbers[index] != numbers[index + 1])
                    || index == numbers.Count - 1)
                {
                    Console.WriteLine($"{numbers[index]} -> {counter}");

                    counter = 0;
                }

                counter++;
            }
        }
    }
}