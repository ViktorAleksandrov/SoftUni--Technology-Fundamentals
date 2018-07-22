namespace P08.DebuggingMultiplyEvensByOdds
{
    using System;

    public class DebuggingMultiplyEvensByOdds
    {
        private static void Main()
        {
            var number = Math.Abs(int.Parse(Console.ReadLine()));

            var result = GetMultipleOfEvensAndOdds(number);

            Console.WriteLine(result);
        }

        private static int GetMultipleOfEvensAndOdds(int number)
        {
            var sumEvens = GetSumOfEvenDigits(number);
            var sumOdds = GetSumOfOddDigits(number);

            return sumEvens * sumOdds;
        }

        private static int GetSumOfEvenDigits(int number)
        {
            return SumOfDigits(number, 0);
        }

        private static int GetSumOfOddDigits(int number)
        {
            return SumOfDigits(number, 1);
        }

        private static int SumOfDigits(int number, int remainderOneOrZero)
        {
            var sum = 0;

            while (number > 0)
            {
                var lastDigit = number % 10;

                if (lastDigit % 2 == remainderOneOrZero)
                {
                    sum += lastDigit;
                }

                number /= 10;
            }

            return sum;
        }
    }
}