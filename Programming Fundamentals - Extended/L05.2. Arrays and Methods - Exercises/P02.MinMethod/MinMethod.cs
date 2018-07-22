namespace P02.MinMethod
{
    using System;

    public class MinMethod
    {
        public static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());

            var minNumber = GetMin(
                firstNumber, GetMin(secondNumber, thirdNumber));

            Console.WriteLine(minNumber);
        }

        public static int GetMin(int firstNumber, int secondNumber)
        {
            return Math.Min(firstNumber, secondNumber);
        }
    }
}