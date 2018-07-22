namespace P05.IntegerToBase
{
    using System;

    public class IntegerToBase
    {
        private static void Main()
        {
            var decimalNumber = long.Parse(Console.ReadLine());
            var toBase = int.Parse(Console.ReadLine());

            var convertedResult = DecimalToBase(decimalNumber, toBase);

            Console.WriteLine(convertedResult);
        }

        private static string DecimalToBase(long decimalNumber, int toBase)
        {
            var convertedResult = string.Empty;

            while (decimalNumber > 0)
            {
                var remainder = decimalNumber % toBase;

                convertedResult = remainder + convertedResult;

                decimalNumber /= toBase;
            }

            return convertedResult;
        }
    }
}