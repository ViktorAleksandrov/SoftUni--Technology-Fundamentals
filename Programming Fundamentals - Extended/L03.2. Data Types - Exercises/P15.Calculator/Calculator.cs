namespace P15.Calculator
{
    using System;

    public class Calculator
    {
        public static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var operatorSymbol = Console.ReadLine();
            var secondNumber = int.Parse(Console.ReadLine());

            var result = 0;

            switch (operatorSymbol)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
            }

            Console.WriteLine(
                $"{firstNumber} {operatorSymbol} {secondNumber} = {result}");
        }
    }
}