namespace P03.ExchangeVariableValues
{
    using System;

    public class ExchangeVariableValues
    {
        public static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());

            var tempFirstNumber = firstNumber;

            firstNumber = secondNumber;
            secondNumber = tempFirstNumber;

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
        }
    }
}