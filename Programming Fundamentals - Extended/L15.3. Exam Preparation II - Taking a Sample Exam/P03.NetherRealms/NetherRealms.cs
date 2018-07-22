namespace P03.NetherRealms
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class NetherRealms
    {
        public static void Main()
        {
            var demons = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(d => d);

            foreach (var demon in demons)
            {
                var healthRegex = new Regex(@"[^\d*/.+-]");

                var health = healthRegex
                    .Matches(demon)
                    .Cast<Match>()
                    .Sum(m => char.Parse(m.Value));

                var damageRegex = new Regex(@"-?\d+(\.\d+)?");

                var damage = damageRegex
                    .Matches(demon)
                    .Cast<Match>()
                    .Sum(number => double.Parse(number.Value));

                var asterisks = demon.Count(ch => ch == '*');
                var slashes = demon.Count(ch => ch == '/');

                damage *= Math.Pow(2, asterisks);
                damage /= Math.Pow(2, slashes);

                Console.WriteLine($"{demon} - {health} health, {damage:f2} damage");
            }
        }
    }
}