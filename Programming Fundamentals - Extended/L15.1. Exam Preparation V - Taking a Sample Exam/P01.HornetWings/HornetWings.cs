namespace P01.HornetWings
{
    using System;

    public class HornetWings
    {
        public static void Main()
        {
            var wingFlaps = long.Parse(Console.ReadLine());
            var metersPerThousandFlaps = double.Parse(Console.ReadLine());
            var endurance = int.Parse(Console.ReadLine());

            var traveledMeters = (wingFlaps / 1000) * metersPerThousandFlaps;
            var elapsedSeconds = (wingFlaps / 100) + (wingFlaps / endurance * 5);

            Console.WriteLine($"{traveledMeters:f2} m.");
            Console.WriteLine($"{elapsedSeconds} s.");
        }
    }
}