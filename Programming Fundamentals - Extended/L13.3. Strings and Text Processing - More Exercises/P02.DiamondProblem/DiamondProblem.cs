namespace P02.DiamondProblem
{
    using System;
    using System.Linq;

    public class DiamondProblem
    {
        public static void Main()
        {
            var inputText = Console.ReadLine();

            var startIndex = -1;

            var isDiamondFound = false;

            while (true)
            {
                startIndex = inputText.IndexOf('<', startIndex + 1);

                var endIndex = inputText.IndexOf('>', startIndex + 1);

                if (startIndex == -1 || endIndex == -1)
                {
                    break;
                }

                isDiamondFound = true;

                var diamondLength = endIndex - startIndex - 1;

                var diamond = inputText
                    .Substring(startIndex + 1, diamondLength);

                var carats = diamond
                    .Where(char.IsDigit)
                    .Sum(ch => int.Parse(ch.ToString()));

                Console.WriteLine($"Found {carats} carat diamond");
            }

            if (!isDiamondFound)
            {
                Console.WriteLine("Better luck next time");
            }
        }
    }
}