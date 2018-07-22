namespace P02.SignOfIntegerNumber
{
    using System;

    public class SignOfIntegerNumber
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            PrintSign(num);
        }

        public static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine("The number 0 is zero.");
            }
        }
    }
}