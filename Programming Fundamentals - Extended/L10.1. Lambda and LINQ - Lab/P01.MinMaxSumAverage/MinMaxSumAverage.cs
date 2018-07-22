namespace P01.MinMaxSumAverage
{
    using System;
    using System.Linq;

    public class MinMaxSumAverage
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            var numbers = new int[num];

            for (var index = 0; index < num; index++)
            {
                numbers[index] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Sum = {numbers.Sum()}\n" +
                              $"Min = {numbers.Min()}\n" +
                              $"Max = {numbers.Max()}\n" +
                              $"Average = {numbers.Average()}");
        }
    }
}