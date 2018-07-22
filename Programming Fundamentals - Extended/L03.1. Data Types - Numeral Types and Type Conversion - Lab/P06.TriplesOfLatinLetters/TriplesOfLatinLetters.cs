namespace P06.TriplesOfLatinLetters
{
    using System;

    public class TriplesOfLatinLetters
    {
        public static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (var firstLetter = 'a'; firstLetter < 'a' + number; firstLetter++)
            {
                for (var secondLetter = 'a'; secondLetter < 'a' + number; secondLetter++)
                {
                    for (var thirdLetter = 'a'; thirdLetter < 'a' + number; thirdLetter++)
                    {
                        Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");
                    }
                }
            }
        }
    }
}