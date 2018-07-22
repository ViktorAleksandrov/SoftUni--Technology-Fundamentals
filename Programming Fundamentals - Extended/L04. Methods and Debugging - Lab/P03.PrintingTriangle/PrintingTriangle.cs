namespace P03.PrintingTriangle
{
    using System;

    public class PrintingTriangle
    {
        public static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            PrintTriangle(number);
        }

        public static void PrintLine(int row)
        {
            for (var line = 1; line <= row; line++)
            {
                Console.Write($"{line} ");
            }

            Console.WriteLine();
        }

        public static void PrintTriangle(int n)
        {
            for (var row = 1; row <= n; row++)
            {
                PrintLine(row);
            }

            for (var row = n - 1; row >= 1; row--)
            {
                PrintLine(row);
            }
        }
    }
}