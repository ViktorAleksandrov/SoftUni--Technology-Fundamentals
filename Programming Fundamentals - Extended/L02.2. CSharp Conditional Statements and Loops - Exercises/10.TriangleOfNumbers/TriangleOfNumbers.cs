using System;

class TriangleOfNumbers
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        for (int row = 1; row <= inputNumber; row++)
        {
            for (int column = 1; column <= row; column++)
            {
                Console.Write($"{row} ");
            }

            Console.WriteLine();
        }
    }
}