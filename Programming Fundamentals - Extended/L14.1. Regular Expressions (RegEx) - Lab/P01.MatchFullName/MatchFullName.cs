namespace P01.MatchFullName
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchFullName
    {
        public static void Main()
        {
            var regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            var names = Console.ReadLine();

            var matchedNames = Regex.Matches(names, regex);

            foreach (var name in matchedNames)
            {
                Console.Write($"{name} ");
            }

            Console.WriteLine();
        }
    }
}