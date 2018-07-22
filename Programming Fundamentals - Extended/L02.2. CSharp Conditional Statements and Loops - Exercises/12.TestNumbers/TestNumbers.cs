using System;

class TestNumbers
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int maxSumLimit = int.Parse(Console.ReadLine());

        int sum = 0;
        int counter = 0;

        for (int decreasingNum = firstNumber; decreasingNum >= 1; decreasingNum--)
        {
            for (int increasingNum = 1; increasingNum <= secondNumber; increasingNum++)
            {
                sum += (decreasingNum * increasingNum) * 3;

                counter++;

                if (sum >= maxSumLimit)
                {
                    Console.WriteLine($"{counter} combinations");
                    Console.WriteLine($"Sum: {sum} >= {maxSumLimit}");
                    return;
                }
            }
        }

        Console.WriteLine($"{counter} combinations");
        Console.WriteLine($"Sum: {sum}");
    }
}