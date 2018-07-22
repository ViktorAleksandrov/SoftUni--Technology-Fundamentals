using System;

class OddNumber
{
    static void Main()
    {
        int inputNumber = Math.Abs(int.Parse(Console.ReadLine()));

        while (inputNumber % 2 != 1)
        {
            Console.WriteLine("Please write an odd number.");

            inputNumber = Math.Abs(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine($"The number is: {inputNumber}");
    }
}