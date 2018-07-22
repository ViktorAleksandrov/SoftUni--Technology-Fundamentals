namespace P03.ShortWordsSorted
{
    using System;
    using System.Linq;

    public class ShortWordsSorted
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .ToLower()
                .Split(".,:;()[]\"'\\/!? ".ToCharArray())
                .Where(w => w.Length < 5)
                .Where(w => w != string.Empty)
                .OrderBy(w => w)
                .Distinct()
                .ToList();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}