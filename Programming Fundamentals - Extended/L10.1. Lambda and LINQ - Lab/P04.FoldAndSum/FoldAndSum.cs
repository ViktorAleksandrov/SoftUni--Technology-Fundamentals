namespace P04.FoldAndSum
{
    using System;
    using System.Linq;

    public class FoldAndSum
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var quarter = numbers.Length / 4;

            var rightPart = numbers
                .Reverse()
                .Take(quarter)
                .ToArray();

            var upperRow = numbers
                .Take(quarter)
                .Reverse()
                .Concat(rightPart)
                .ToArray();

            var lowerRow = numbers
                .Skip(quarter)
                .Take(quarter * 2)
                .ToArray();

            var sum = new int[quarter * 2];

            for (var index = 0; index < sum.Length; index++)
            {
                sum[index] = upperRow[index] + lowerRow[index];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}