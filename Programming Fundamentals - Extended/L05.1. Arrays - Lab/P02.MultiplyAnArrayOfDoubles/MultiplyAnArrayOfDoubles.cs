namespace P02.MultiplyAnArrayOfDoubles
{
    using System;

    public class MultiplyAnArrayOfDoubles
    {
        private static void Main()
        {
            var input = Console.ReadLine().Split();

            var numbers = new double[input.Length];

            var multiplier = double.Parse(Console.ReadLine());

            for (var index = 0; index < numbers.Length; index++)
            {
                numbers[index] = double.Parse(input[index]);

                numbers[index] *= multiplier;
            }

            for (var cnt = 0; cnt < numbers.Length; cnt++)
            {
                Console.Write(numbers[cnt] + " ");
            }

            Console.WriteLine();
        }
    }
}