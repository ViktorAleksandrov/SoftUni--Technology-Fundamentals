using System;

class MultiplicationTable2
{
    static void Main()
    {
        int multiplicand = int.Parse(Console.ReadLine());
        int multiplier = int.Parse(Console.ReadLine());

        do
        {
            int product = multiplicand * multiplier;

            Console.WriteLine(
                $"{multiplicand} X {multiplier} = {product}");

            multiplier++;
        }
        while (multiplier <= 10);
    }
}