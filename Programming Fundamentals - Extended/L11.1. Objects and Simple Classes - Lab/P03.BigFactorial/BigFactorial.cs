namespace P03.BigFactorial
{
    using System;
    using System.Numerics;

    public class BigFactorial
    {
        public static void Main()
        {
            var inputNumber = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (var index = 2; index <= inputNumber; index++)
            {
                factorial *= index;
            }

            Console.WriteLine(factorial);
        }
    }
}