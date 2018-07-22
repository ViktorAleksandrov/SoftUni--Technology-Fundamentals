namespace P01.ArrayContainsElement
{
    using System;
    using System.Linq;

    public class ArrayContainsElement
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var targetNumber = int.Parse(Console.ReadLine());

            foreach (var num in numbers)
            {
                if (targetNumber == num)
                {
                    Console.WriteLine("yes");

                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}