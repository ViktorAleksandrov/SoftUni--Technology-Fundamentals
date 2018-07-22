namespace P08.TravelingAtLightSpeed
{
    using System;

    public class TravelingAtLightSpeed
    {
        public static void Main()
        {
            var lightYears = double.Parse(Console.ReadLine());

            var kilometersPerLightYear = 9450000000000;

            var kilometersPerSecond = 300000;

            var totalSeconds = (lightYears * kilometersPerLightYear) / kilometersPerSecond;

            var timePeriod = TimeSpan.FromSeconds(totalSeconds);

            var weeks = timePeriod.Days / 7;

            var days = timePeriod.Days % 7;

            var hours = timePeriod.Hours;

            var minutes = timePeriod.Minutes;

            var seconds = timePeriod.Seconds;

            Console.WriteLine(
                $"{weeks} weeks\n"
                + $"{days} days\n"
                + $"{hours} hours\n"
                + $"{minutes} minutes\n"
                + $"{seconds} seconds");
        }
    }
}