namespace P05.SortNumbers
{
    using System;
    using System.Linq;

    public class SortNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            numbers.Sort();

            Console.WriteLine(string.Join(" <= ", numbers));
        }
    }
}