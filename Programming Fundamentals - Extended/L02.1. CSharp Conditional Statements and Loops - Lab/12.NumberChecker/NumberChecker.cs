using System;

class NumberChecker
{
    static void Main()
    {
        try
        {
            double inputNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("It is a number.");
        }
        catch
        {
            Console.WriteLine("Invalid input!");
        }
    }
}