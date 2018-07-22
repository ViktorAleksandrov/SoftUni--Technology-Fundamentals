namespace P01.Cards
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Cards
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var regex = "(?<=^|[SHDC])([2-9JQKA]|10)[SHDC]";

            var cards = Regex.Matches(input, regex).Cast<Match>();

            Console.WriteLine(string.Join(", ", cards));
        }
    }
}