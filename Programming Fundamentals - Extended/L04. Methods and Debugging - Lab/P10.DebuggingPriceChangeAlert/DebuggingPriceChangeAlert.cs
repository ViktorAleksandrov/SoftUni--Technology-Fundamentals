namespace P10.DebuggingPriceChangeAlert
{
    using System;

    public class DebuggingPriceChangeAlert
    {
        private static void Main()
        {
            var numberOfPrices = int.Parse(Console.ReadLine());
            var treshold = double.Parse(Console.ReadLine());

            var previousPrice = double.Parse(Console.ReadLine());

            for (var index = 0; index < numberOfPrices - 1; index++)
            {
                var currentPrice = double.Parse(Console.ReadLine());

                var percentageDifference = GetPercentageDifference(previousPrice, currentPrice);

                var isOverTreshold = IsOverTreshold(percentageDifference, treshold);

                var message = GetMessage(
                    currentPrice, previousPrice, percentageDifference, isOverTreshold);

                Console.WriteLine(message);

                previousPrice = currentPrice;
            }
        }

        private static string GetMessage(
                double currentPrice, double lastPrice, double percentageDifference, bool isOverTreshold)
        {
            var message = string.Empty;

            if (percentageDifference == 0)
            {
                message = $"NO CHANGE: {currentPrice}";

                return message;
            }
            else if (!isOverTreshold)
            {
                message =
                    $"MINOR CHANGE: {lastPrice} to {currentPrice} ({percentageDifference * 100:F2}%)";

                return message;
            }
            else if (isOverTreshold && (percentageDifference > 0))
            {
                message =
                    $"PRICE UP: {lastPrice} to {currentPrice} ({percentageDifference * 100:F2}%)";

                return message;
            }
            else if (isOverTreshold && (percentageDifference < 0))
            {
                message =
                    $"PRICE DOWN: {lastPrice} to {currentPrice} ({percentageDifference * 100:F2}%)";

                return message;
            }
            else
            {
                return message;
            }
        }

        private static bool IsOverTreshold(double percentageDifference, double treshold)
        {
            return Math.Abs(percentageDifference) >= treshold;
        }

        private static double GetPercentageDifference(double previousPrice, double currentPrice)
        {
            return (currentPrice - previousPrice) / previousPrice;
        }
    }
}