namespace P06.SquareNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SquareNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var squareRoots = new List<int>();

            foreach (var currentNumber in numbers)
            {
                var squareRoot = Math.Sqrt(currentNumber);

                if (squareRoot == (int)squareRoot)
                {
                    squareRoots.Add(currentNumber);
                }
            }

            squareRoots.Sort();
            squareRoots.Reverse();

            Console.WriteLine(string.Join(" ", squareRoots));
        }
    }
}