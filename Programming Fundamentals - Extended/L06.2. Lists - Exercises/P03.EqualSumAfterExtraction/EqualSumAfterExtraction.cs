namespace P03.EqualSumAfterExtraction
{
    using System;
    using System.Linq;

    public class EqualSumAfterExtraction
    {
        public static void Main()
        {
            var firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var sumSecondList = 0;

            foreach (var currentNumber in secondList)
            {
                if (!firstList.Contains(currentNumber))
                {
                    sumSecondList += currentNumber;
                }
            }

            var sumFirstList = firstList.Sum();

            if (sumFirstList == sumSecondList)
            {
                Console.WriteLine($"Yes. Sum: {sumFirstList}");
            }
            else
            {
                var diff = Math.Abs(sumFirstList - sumSecondList);

                Console.WriteLine($"No. Diff: {diff}");
            }
        }
    }
}