using System;

class MagicLetter
{
    static void Main()
    {
        char startLetter = char.Parse(Console.ReadLine());
        char endLetter = char.Parse(Console.ReadLine());
        char forbiddenLetter = char.Parse(Console.ReadLine());

        for (char firstLetter = startLetter; firstLetter <= endLetter; firstLetter++)
        {
            for (char secondLetter = startLetter; secondLetter <= endLetter; secondLetter++)
            {
                for (char thirdLetter = startLetter; thirdLetter <= endLetter; thirdLetter++)
                {
                    if (firstLetter != forbiddenLetter &&
                        secondLetter != forbiddenLetter &&
                        thirdLetter != forbiddenLetter)
                    {
                        Console.Write($"{firstLetter}{secondLetter}{thirdLetter} ");
                    }
                }
            }
        }

        Console.WriteLine();
    }
}