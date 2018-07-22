namespace P03.ExactProductOfRealNumbers
{
    using System;

    public class ExactProductOfRealNumbers
    {
        public static void Main()
        {
            var numbersCount = int.Parse(Console.ReadLine());

            decimal product = 1;

            for (var index = 0; index < numbersCount; index++)
            {
                decimal currentNumber = decimal.Parse(Console.ReadLine());

                product *= currentNumber;
            }

            Console.WriteLine(product);
        }
    }
}