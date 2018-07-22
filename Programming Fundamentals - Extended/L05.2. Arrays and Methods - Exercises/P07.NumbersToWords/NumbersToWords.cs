namespace P07.NumbersToWords
{
    using System;

    public class NumbersToWords
    {
        private static void Main()
        {
            var numberCount = int.Parse(Console.ReadLine());

            for (var index = 0; index < numberCount; index++)
            {
                var currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber > 999)
                {
                    Console.WriteLine("too large");
                }
                else if (currentNumber < -999)
                {
                    Console.WriteLine("too small");
                }
                else if (currentNumber >= 100 || currentNumber <= -100)
                {
                    if (currentNumber <= -100)
                    {
                        Console.Write("minus ");
                    }

                    Letterize(currentNumber);
                }
            }
        }

        private static void Letterize(int currentNumber)
        {
            var lessThanTen = new[]
            {
                "one",
                "two",
                "three",
                "four",
                "five",
                "six",
                "seven",
                "eight",
                "nine"
            };

            var teens = new[]
            {
                "eleven",
                "twelve",
                "thirteen",
                "fourteen",
                "fifteen",
                "sixteen",
                "seventeen",
                "eighteen",
                "nineteen"
            };

            var tens = new[]
            {
                "ten",
                "twenty",
                "thirty",
                "forty",
                "fifty",
                "sixty",
                "seventy",
                "eighty",
                "ninety"
            };

            var digits = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            var firstDigit = Math.Abs(currentNumber / 100);
            var secondDigit = Math.Abs((currentNumber / 10) % 10);
            var thirdDigit = Math.Abs(currentNumber % 10);

            for (var index = 0; index < 3; index++)
            {
                for (var cnt = 0; cnt < 10; cnt++)
                {
                    if (index == 0 && firstDigit == digits[cnt])
                    {
                        Console.Write($"{lessThanTen[cnt]}-hundred");

                        if (secondDigit != 0 || thirdDigit != 0)
                        {
                            Console.Write(" and ");
                        }
                    }
                    else if (index == 1 && secondDigit == digits[cnt])
                    {
                        if (secondDigit >= 2)
                        {
                            Console.Write($"{tens[cnt]} ");
                        }
                        else if (secondDigit == 1)
                        {
                            if (thirdDigit == 0)
                            {
                                Console.WriteLine(tens[cnt]);
                            }
                        }
                    }
                    else if (index == 2 && thirdDigit == digits[cnt] && thirdDigit != 0)
                    {
                        Console.Write(
                            secondDigit == 1 ? teens[cnt] : lessThanTen[cnt]);
                    }
                }
            }

            Console.WriteLine();
        }
    }
}