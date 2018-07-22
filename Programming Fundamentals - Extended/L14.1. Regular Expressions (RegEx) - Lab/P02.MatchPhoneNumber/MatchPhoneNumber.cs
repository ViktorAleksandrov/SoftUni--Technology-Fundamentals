namespace P02.MatchPhoneNumber
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class MatchPhoneNumber
    {
        public static void Main()
        {
            var regex = @"\+359([ -])2\1\d{3}\1\d{4}\b";

            var phoneNumbers = Console.ReadLine();

            var phoneNumbersMatches = Regex.Matches(phoneNumbers, regex)
                .Cast<Match>();

            Console.WriteLine(string.Join(", ", phoneNumbersMatches));
        }
    }
}