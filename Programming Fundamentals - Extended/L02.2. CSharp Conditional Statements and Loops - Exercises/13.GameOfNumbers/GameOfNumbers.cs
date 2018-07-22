using System;

class GameOfNumbers
{
    static void Main()
    {
        int startNumber = int.Parse(Console.ReadLine());
        int endNumber = int.Parse(Console.ReadLine());
        int magicalNumber = int.Parse(Console.ReadLine());

        int combinationsCounter = 0;

        int comboFirstNumber = 0;
        int comboSecondNumber = 0;

        bool isMagicNumberFound = false;

        for (int firstNumber = startNumber; firstNumber <= endNumber; firstNumber++)
        {
            for (int secondNumber = startNumber; secondNumber <= endNumber; secondNumber++)
            {
                combinationsCounter++;

                if (firstNumber + secondNumber == magicalNumber)
                {
                    comboFirstNumber = firstNumber;
                    comboSecondNumber = secondNumber;

                    isMagicNumberFound = true;
                }
            }
        }

        if (isMagicNumberFound)
        {
            Console.WriteLine(
                $"Number found! {comboFirstNumber} + {comboSecondNumber} = {magicalNumber}");
        }
        else
        {
            Console.WriteLine(
                $"{combinationsCounter} combinations - neither equals {magicalNumber}");
        }
    }
}