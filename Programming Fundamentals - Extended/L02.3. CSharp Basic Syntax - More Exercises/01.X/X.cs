using System;

class X
{
    static void Main()
    {
        int oddInputNumber = int.Parse(Console.ReadLine());

        int leftRightSpaces = 0;
        int middleSpace = oddInputNumber - 2;

        for (int row = 0; row < oddInputNumber / 2; row++)
        {
            Console.WriteLine(
                "{0}x{1}x{0}",
                new string(' ', leftRightSpaces),
                new string(' ', middleSpace));

            leftRightSpaces++;
            middleSpace -= 2;
        }

        Console.WriteLine(new string(' ', leftRightSpaces) + 'x');

        for (int row = 0; row < oddInputNumber / 2; row++)
        {
            leftRightSpaces--;
            middleSpace += 2;

            Console.WriteLine(
                "{0}x{1}x{0}",
                new string(' ', leftRightSpaces),
                new string(' ', middleSpace));
        }
    }
}