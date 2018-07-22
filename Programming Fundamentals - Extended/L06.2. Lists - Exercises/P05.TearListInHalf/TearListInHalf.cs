namespace P05.TearListInHalf
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TearListInHalf
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var leftPart = new List<int>();
            var rightPart = new List<int>();

            for (var cnt = 0; cnt < numbers.Count; cnt++)
            {
                var currentNumber = numbers[cnt];

                if (cnt < numbers.Count / 2)
                {
                    leftPart.Add(currentNumber);
                }
                else
                {
                    rightPart.Add(currentNumber);
                }
            }

            var resultList = new List<int>();

            for (var index = 0; index < rightPart.Count; index++)
            {
                var currentLeftNumber = leftPart[index];

                var currentRightNumber = rightPart[index];

                var firstRightDigit = currentRightNumber / 10;
                var secondRightDigit = currentRightNumber % 10;

                resultList.Add(firstRightDigit);
                resultList.Add(currentLeftNumber);
                resultList.Add(secondRightDigit);
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}