using System;

class CaloriesCounter
{
    static void Main()
    {
        int ingredientNumber = int.Parse(Console.ReadLine());

        int totalCalories = 0;

        for (int currentNumber = 0; currentNumber < ingredientNumber; currentNumber++)
        {
            string ingredient = Console.ReadLine().ToLower();

            switch (ingredient)
            {
                case "cheese":
                    totalCalories += 500;
                    break;
                case "tomato sauce":
                    totalCalories += 150;
                    break;
                case "salami":
                    totalCalories += 600;
                    break;
                case "pepper":
                    totalCalories += 50;
                    break;
            }
        }

        Console.WriteLine($"Total calories: {totalCalories}");
    }
}