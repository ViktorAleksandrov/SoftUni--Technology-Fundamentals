namespace P05.MatchNumbers
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class MatchNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            var numbers = Regex.Matches(input, regex)
                .Cast<Match>();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}