using System;

class BeverageLabels
{
    static void Main()
    {
        string nameOfProduct = Console.ReadLine();
        int volumeOfProduct = int.Parse(Console.ReadLine());
        int energyPerHundredMl = int.Parse(Console.ReadLine());
        int sugarPerHundredMl = int.Parse(Console.ReadLine());

        double totalEnergy = (volumeOfProduct / 100.0) * energyPerHundredMl;
        double totalSugar = (volumeOfProduct / 100.0) * sugarPerHundredMl;

        Console.WriteLine($"{volumeOfProduct}ml {nameOfProduct}:");
        Console.WriteLine($"{totalEnergy}kcal, {totalSugar}g sugars");
    }
}