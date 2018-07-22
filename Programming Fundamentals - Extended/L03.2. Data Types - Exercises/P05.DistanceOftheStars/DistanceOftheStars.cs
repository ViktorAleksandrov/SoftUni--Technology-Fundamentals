namespace P05.DistanceOftheStars
{
    using System;

    public class DistanceOftheStars
    {
        public static void Main()
        {
            decimal lightYearKilometers = 9450000000000m;

            decimal proximaCentauriDistance = lightYearKilometers * 4.22m;
            decimal milkyWayCenterDistance = lightYearKilometers * 26000;
            decimal diameterMilkyWay = lightYearKilometers * 100000;
            decimal universeEdgeDistance = lightYearKilometers * 46500000000;

            Console.WriteLine($"{proximaCentauriDistance:e2}\n"
                + $"{milkyWayCenterDistance:e2}\n"
                + $"{diameterMilkyWay:e2}\n"
                + $"{universeEdgeDistance:e2}");
        }
    }
}