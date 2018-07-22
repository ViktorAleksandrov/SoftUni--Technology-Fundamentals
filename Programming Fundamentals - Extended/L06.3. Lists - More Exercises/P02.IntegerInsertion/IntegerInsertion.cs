namespace P02.IntegerInsertion
{
    using System;
    using System.Linq;

    public class IntegerInsertion
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var currentNumber = int.Parse(input);
                var firstDigit = input[0] - '0';

                numbers.Insert(firstDigit, currentNumber);

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}