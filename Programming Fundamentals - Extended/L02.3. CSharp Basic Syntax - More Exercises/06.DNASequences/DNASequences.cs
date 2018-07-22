using System;

class DNASequences
{
    static void Main()
    {
        int matchSum = int.Parse(Console.ReadLine());

        for (int firstDigit = 1; firstDigit <= 4; firstDigit++)
        {
            for (int secondDigit = 1; secondDigit <= 4; secondDigit++)
            {
                for (int thirdDigit = 1; thirdDigit <= 4; thirdDigit++)
                {
                    string startEndLetter = "X";

                    if (firstDigit + secondDigit + thirdDigit >= matchSum)
                    {
                        startEndLetter = "O";
                    }

                    Console.Write(
                        startEndLetter +
                        (string.Empty + firstDigit + secondDigit + thirdDigit)
                        .Replace('1', 'A')
                        .Replace('2', 'C')
                        .Replace('3', 'G')
                        .Replace('4', 'T') +
                        startEndLetter + " ");

                    if (thirdDigit % 4 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}