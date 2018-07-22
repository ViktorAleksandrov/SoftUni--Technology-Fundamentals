namespace P01.CharityMarathon
{
    using System;

    public class CharityMarathon
    {
        public static void Main()
        {
            var marathonDays = int.Parse(Console.ReadLine());
            var runnersCount = long.Parse(Console.ReadLine());
            var averageLapsCount = int.Parse(Console.ReadLine());
            var trackLength = int.Parse(Console.ReadLine());
            var trackCapacity = long.Parse(Console.ReadLine());
            var donatedMoneyPerKm = decimal.Parse(Console.ReadLine());

            var totalRunners = Math.Min(runnersCount, trackCapacity * marathonDays);

            var runnedKm = totalRunners * averageLapsCount * trackLength / 1000;

            var raisedMoney = runnedKm * donatedMoneyPerKm;

            Console.WriteLine($"Money raised: {raisedMoney:f2}");
        }
    }
}