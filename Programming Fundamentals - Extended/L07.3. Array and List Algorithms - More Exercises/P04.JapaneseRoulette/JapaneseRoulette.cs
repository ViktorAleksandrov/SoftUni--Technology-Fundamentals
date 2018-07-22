namespace P04.JapaneseRoulette
{
    using System;
    using System.Linq;

    public class JapaneseRoulette
    {
        public static void Main()
        {
            var cylinder = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var players = Console.ReadLine().Split();

            var bulletIndex = cylinder.IndexOf(1);

            for (var index = 0; index < players.Length; index++)
            {
                var currentPlayer = players[index].Split(',');

                var strength = int.Parse(currentPlayer[0]) % cylinder.Count;
                var direction = currentPlayer[1];

                switch (direction)
                {
                    case "Right":
                        bulletIndex = (bulletIndex + strength) % cylinder.Count;
                        break;
                    case "Left":
                        if (bulletIndex >= strength)
                        {
                            bulletIndex -= strength;
                        }
                        else
                        {
                            bulletIndex = cylinder.Count - (strength - bulletIndex);
                        }

                        break;
                }

                if (bulletIndex == 2)
                {
                    Console.WriteLine($"Game over! Player {index} is dead.");

                    return;
                }

                bulletIndex = (bulletIndex + 1) % cylinder.Count;
            }

            Console.WriteLine("Everybody got lucky!");
        }
    }
}