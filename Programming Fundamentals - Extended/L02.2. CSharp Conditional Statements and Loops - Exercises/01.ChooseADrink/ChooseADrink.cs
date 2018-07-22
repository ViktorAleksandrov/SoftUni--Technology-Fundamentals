using System;

class ChooseADrink
{
    static void Main()
    {
        string profession = Console.ReadLine();

        string perfectDrink = string.Empty;

        switch (profession)
        {
            case "Athlete":
                perfectDrink = "Water";
                break;
            case "Businessman":
            case "Businesswoman":
                perfectDrink = "Coffee";
                break;
            case "SoftUni Student":
                perfectDrink = "Beer";
                break;
            default:
                perfectDrink = "Tea";
                break;
        }

        Console.WriteLine(perfectDrink);
    }
}