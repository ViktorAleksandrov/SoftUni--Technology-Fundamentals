using System;

class SumOfOddNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int currentOddNumber = 1;
        int sum = 0;

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine(currentOddNumber);

            sum += currentOddNumber;
            currentOddNumber += 2;
        }

        Console.WriteLine($"Sum: {sum}");
    }
}