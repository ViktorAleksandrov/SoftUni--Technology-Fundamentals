namespace P04.DrawAFilledSquare
{
    using System;

    public class DrawAFilledSquare
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            PrintFilledSquare(number);
        }

        public static void PrintHeaderOrFooterRows(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        public static void PrintMiddleRows(int n)
        {
            Console.Write('-');

            for (var i = 1; i < n; i++)
            {
                Console.Write(@"\/");
            }

            Console.WriteLine('-');
        }

        public static void PrintFilledSquare(int n)
        {
            PrintHeaderOrFooterRows(n);

            for (var i = 0; i < n - 2; i++)
            {
                PrintMiddleRows(n);
            }

            PrintHeaderOrFooterRows(n);
        }
    }
}