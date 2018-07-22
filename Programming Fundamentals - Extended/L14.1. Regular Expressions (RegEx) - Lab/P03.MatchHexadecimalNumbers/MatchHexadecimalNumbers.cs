namespace P03.MatchHexadecimalNumbers
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class MatchHexadecimalNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var regex = @"\b(0x)?[0-9A-F]+\b";

            var matches = Regex.Matches(input, regex)
                .Cast<Match>();

            Console.WriteLine(string.Join(" ", matches));
        }
    }
}