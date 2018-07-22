namespace P04.FlipListSides
{
    using System;
    using System.Linq;

    public class FlipListSides
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().ToList();

            numbers.Reverse(1, numbers.Count - 2);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}