namespace P05.SpecialNumbers
{
    using System;

    public class SpecialNumbers
    {
        public static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (var currentNumber = 1; currentNumber <= number; currentNumber++)
            {
                var sumOfDigits = 0;

                var digits = currentNumber;

                while (digits > 0)
                {
                    sumOfDigits += digits % 10;
                    digits = digits / 10;
                }

                var specialNumber = sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11;

                Console.WriteLine($"{currentNumber} -> {specialNumber}");
            }
        }
    }
}