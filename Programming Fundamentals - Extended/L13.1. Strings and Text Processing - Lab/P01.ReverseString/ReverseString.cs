namespace P01.ReverseString
{
    using System;
    using System.Linq;

    public class ReverseString
    {
        public static void Main()
        {
            var word = Console.ReadLine()
                .Reverse()
                .ToArray();

            Console.WriteLine(word);
        }
    }
}