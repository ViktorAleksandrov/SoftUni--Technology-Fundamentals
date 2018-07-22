using System;

class CakeIngredients
{
    static void Main()
    {
        string ingredient = Console.ReadLine();

        int ingredientCounter = 0;

        while (ingredient != "Bake!")
        {
            Console.WriteLine($"Adding ingredient {ingredient}.");

            ingredientCounter++;

            ingredient = Console.ReadLine();
        }

        Console.WriteLine($"Preparing cake with {ingredientCounter} ingredients.");
    }
}