using System;

class MultiplicationTable
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        int multiplier = 1;

        while (multiplier <= 10)
        {
            int product = inputNumber * multiplier;

            Console.WriteLine(
                $"{inputNumber} X {multiplier} = {product}");

            multiplier++;
        }
    }
}