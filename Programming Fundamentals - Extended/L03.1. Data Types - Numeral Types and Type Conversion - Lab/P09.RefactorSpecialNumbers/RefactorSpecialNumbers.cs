namespace P09.RefactorSpecialNumbers
{
    using System;

    public class RefactorSpecialNumbers
    {
        public static void Main()
        {
            var scopeNumber = int.Parse(Console.ReadLine());

            for (var currentNumber = 1; currentNumber <= scopeNumber; currentNumber++)
            {
                var sumOfDigits = 0;

                var digits = currentNumber;

                while (digits > 0)
                {
                    sumOfDigits += digits % 10;
                    digits = digits / 10;
                }

                var isEqual = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);

                Console.WriteLine($"{currentNumber} -> {isEqual}");
            }
        }
    }
}