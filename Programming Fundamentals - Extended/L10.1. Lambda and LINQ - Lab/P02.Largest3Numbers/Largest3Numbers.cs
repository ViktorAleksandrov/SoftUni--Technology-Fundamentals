namespace P02.Largest3Numbers
{
    using System;
    using System.Linq;

    public class Largest3Numbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .OrderByDescending(num => num)
                .Take(3)
                .ToList();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}