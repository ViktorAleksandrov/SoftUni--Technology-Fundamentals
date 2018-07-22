namespace P06.FishStatistics
{
    using System;
    using System.Text.RegularExpressions;

    public class FishStatistics
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var regex = new Regex(@"(>*)<(\(+)([-'x])>");

            var matchedFish = regex.Matches(input);

            var fishCounter = 1;

            foreach (Match fish in matchedFish)
            {
                Console.WriteLine($"Fish {fishCounter}: {fish.Value}");

                var tailLength = fish.Groups[1].Length * 2;

                var tailType = string.Empty;

                if (tailLength > 10)
                {
                    tailType = "Long";
                }
                else if (tailLength > 2)
                {
                    tailType = "Medium";
                }
                else if (tailLength == 2)
                {
                    tailType = "Short";
                }
                else
                {
                    tailType = "None";
                }

                Console.WriteLine(tailType != "None"
                    ? $"  Tail type: {tailType} ({tailLength} cm)"
                    : "  Tail type: None");

                var bodyLength = fish.Groups[2].Length * 2;

                var bodyType = string.Empty;

                if (bodyLength > 20)
                {
                    bodyType = "Long";
                }
                else if (bodyLength > 10)
                {
                    bodyType = "Medium";
                }
                else
                {
                    bodyType = "Short";
                }

                Console.WriteLine($"  Body type: {bodyType} ({bodyLength} cm)");

                var fishStatusSymbol = fish.Groups[3].Value;

                var fishStatus = string.Empty;

                switch (fishStatusSymbol)
                {
                    case "'":
                        fishStatus = "Awake";
                        break;
                    case "-":
                        fishStatus = "Asleep";
                        break;
                    case "x":
                        fishStatus = "Dead";
                        break;
                }

                Console.WriteLine($"  Status: {fishStatus}");

                fishCounter++;
            }

            if (fishCounter == 1)
            {
                Console.WriteLine("No fish found.");
            }
        }
    }
}