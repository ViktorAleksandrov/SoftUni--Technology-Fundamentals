namespace P04.MatchDates
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchDates
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var regex = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            var matchedDates = Regex.Matches(input, regex);

            foreach (Match date in matchedDates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}