namespace P01.Trainers
{
    using System;

    public class Trainers
    {
        public static void Main(string[] args)
        {
            var participantsCount = int.Parse(Console.ReadLine());

            var technicalEarnedMoney = 0.0;
            var theoreticalEarnedMoney = 0.0;
            var practicalEarnedMoney = 0.0;

            for (var index = 0; index < participantsCount; index++)
            {
                var distanceInMeters = int.Parse(Console.ReadLine()) * 1600;
                var cargoInKg = double.Parse(Console.ReadLine()) * 1000;
                var team = Console.ReadLine();

                var fuelExpenses = 0.7 * distanceInMeters * 2.5;
                var cargoIncome = 1.5 * cargoInKg;

                var earnedMoney = cargoIncome - fuelExpenses;

                switch (team)
                {
                    case "Technical":
                        technicalEarnedMoney += earnedMoney;
                        break;
                    case "Theoretical":
                        theoreticalEarnedMoney += earnedMoney;
                        break;
                    case "Practical":
                        practicalEarnedMoney += earnedMoney;
                        break;
                }
            }

            var mostEarnedMoney =
                Math.Max(technicalEarnedMoney, Math.Max(theoreticalEarnedMoney, practicalEarnedMoney));

            var richestTeam = string.Empty;

            if (mostEarnedMoney == technicalEarnedMoney)
            {
                richestTeam = "Technical";
            }
            else if (mostEarnedMoney == theoreticalEarnedMoney)
            {
                richestTeam = "Theoretical";
            }
            else
            {
                richestTeam = "Practical";
            }

            Console.WriteLine($"The {richestTeam} Trainers win with ${mostEarnedMoney:f3}.");
        }
    }
}