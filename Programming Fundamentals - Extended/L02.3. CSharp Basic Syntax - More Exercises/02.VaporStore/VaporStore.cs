using System;

class VaporStore
{
    static void Main()
    {
        double initialBudget = double.Parse(Console.ReadLine());
        string gameName = Console.ReadLine();

        double gamePrice = 0.00;

        double currentBalance = initialBudget;

        while (gameName != "Game Time")
        {
            switch (gameName)
            {
                case "OutFall 4":
                case "RoverWatch Origins Edition":
                    gamePrice = 39.99;
                    break;
                case "CS: OG":
                    gamePrice = 15.99;
                    break;
                case "Zplinter Zell":
                    gamePrice = 19.99;
                    break;
                case "Honored 2":
                    gamePrice = 59.99;
                    break;
                case "RoverWatch":
                    gamePrice = 29.99;
                    break;
                default:
                    gamePrice = 0.00;
                    Console.WriteLine("Not Found");
                    break;
            }

            if (gamePrice != 0.00)
            {
                if (currentBalance >= gamePrice)
                {
                    Console.WriteLine($"Bought {gameName}");

                    currentBalance -= gamePrice;
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
            }

            gameName = Console.ReadLine();

            if (currentBalance == 0.00)
            {
                Console.WriteLine("Out of money!");
                return;
            }
        }

        double spentMoney = initialBudget - currentBalance;

        Console.WriteLine(
            $"Total spent: ${spentMoney:f2}. Remaining: ${currentBalance:f2}");
    }
}