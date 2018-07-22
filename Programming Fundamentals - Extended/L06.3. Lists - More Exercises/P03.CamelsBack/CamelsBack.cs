namespace P03.CamelsBack
{
    using System;
    using System.Linq;

    public class CamelsBack
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var lengthLimit = int.Parse(Console.ReadLine());

            if (numbers.Count == lengthLimit)
            {
                Console.WriteLine(
                    $"already stable: {string.Join(" ", numbers)}");

                return;
            }

            var rounds = 0;

            while (numbers.Count > lengthLimit)
            {
                numbers.RemoveAt(0);
                numbers.RemoveAt(numbers.Count - 1);

                rounds++;
            }

            Console.WriteLine($"{rounds} rounds");

            Console.WriteLine($"remaining: {string.Join(" ", numbers)}");
        }
    }
}