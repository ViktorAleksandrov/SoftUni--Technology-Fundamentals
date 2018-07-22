namespace P01.SweetDessert
{
    using System;

    public class SweetDessert
    {
        public static void Main()
        {
            var money = decimal.Parse(Console.ReadLine());

            var guestsCount = int.Parse(Console.ReadLine());

            var singleBananaPrice = decimal.Parse(Console.ReadLine());
            var singleEggPrice = decimal.Parse(Console.ReadLine());
            var berriesPricePerKg = decimal.Parse(Console.ReadLine());

            var neededPortionSets = (int)Math.Ceiling(guestsCount / 6.0);

            var singleSetPrice =
                (singleBananaPrice * 2) + (singleEggPrice * 4) + (berriesPricePerKg * 0.2M);

            var allSetsPrice = neededPortionSets * singleSetPrice;

            Console.WriteLine(money >= allSetsPrice
                ? $"Ivancho has enough money - it would cost {allSetsPrice:f2}lv."
                : $"Ivancho will have to withdraw money - he will need {allSetsPrice - money:f2}lv more.");
        }
    }
}