using System;

class IntervalOfNumbers
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        int smallerNumber = Math.Min(firstNumber, secondNumber);
        int biggerNumber = Math.Max(firstNumber, secondNumber);

        for (int currentNumber = smallerNumber; currentNumber <= biggerNumber; currentNumber++)
        {
            Console.WriteLine(currentNumber);
        }
    }
}