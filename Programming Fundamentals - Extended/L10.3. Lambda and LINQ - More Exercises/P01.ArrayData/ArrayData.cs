namespace P01.ArrayData
{
    using System;
    using System.Linq;

    public class ArrayData
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            numbers = numbers
                .Where(n => n >= numbers.Average())
                .ToList();

            var command = Console.ReadLine();

            switch (command)
            {
                case "Min":
                    Console.WriteLine(numbers.Min());
                    break;
                case "Max":
                    Console.WriteLine(numbers.Max());
                    break;
                case "All":
                    Console.WriteLine(string.Join(" ", numbers.OrderBy(n => n)));
                    break;
            }
        }
    }
}