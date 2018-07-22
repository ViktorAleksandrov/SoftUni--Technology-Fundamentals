namespace P04.NthDigit
{
    using System;

    public class NthDigit
    {
        private static void Main()
        {
            var number = long.Parse(Console.ReadLine());
            var index = int.Parse(Console.ReadLine());

            var nthDigit = FindNthDigit(number, index);

            Console.WriteLine(nthDigit);
        }

        private static int FindNthDigit(long number, int index)
        {
            for (var cnt = 1; cnt < index; cnt++)
            {
                number /= 10;
            }

            return (int)(number % 10);
        }
    }
}