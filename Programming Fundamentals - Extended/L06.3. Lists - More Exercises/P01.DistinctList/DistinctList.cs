namespace P01.DistinctList
{
    using System;
    using System.Linq;

    public class DistinctList
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Distinct()
                .ToList();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}