using System;

class CharacterStats
{
    static void Main()
    {
        string nameOfCharacter = Console.ReadLine();
        int currentHealth = int.Parse(Console.ReadLine());
        int maxHealth = int.Parse(Console.ReadLine());
        int currentEnergy = int.Parse(Console.ReadLine());
        int maxEnergy = int.Parse(Console.ReadLine());

        string currentHealthIndicator = new string('|', currentHealth);
        string missingHealthIndicator = new string('.', maxHealth - currentHealth);

        string currentEnergyIndicator = new string('|', currentEnergy);
        string missingEnergyIndicator = new string('.', maxEnergy - currentEnergy);

        Console.WriteLine($"Name: {nameOfCharacter}");
        Console.WriteLine(
            $"Health: |{currentHealthIndicator}{missingHealthIndicator}|");
        Console.WriteLine(
            $"Energy: |{currentEnergyIndicator}{missingEnergyIndicator}|");
    }
}