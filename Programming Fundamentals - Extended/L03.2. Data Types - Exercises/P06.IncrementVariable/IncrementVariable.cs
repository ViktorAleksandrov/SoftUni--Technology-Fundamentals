namespace P06.IncrementVariable
{
    using System;

    public class IncrementVariable
    {
        public static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());

            int overflowedNumber = inputNumber % 256;

            Console.WriteLine(overflowedNumber);

            int overflowCounter = inputNumber / 256;

            if (overflowCounter > 0)
            {
                Console.WriteLine($"Overflowed {overflowCounter} times");
            }
        }
    }
}