using System;

class FiveDifferentNumbers
{
    static void Main()
    {
        int startNumber = int.Parse(Console.ReadLine());
        int endNumber = int.Parse(Console.ReadLine());

        if (endNumber - startNumber < 4)
        {
            Console.WriteLine("No");
            return;
        }

        for (int digit1 = startNumber; digit1 < endNumber - 3; digit1++)
        {
            for (int digit2 = digit1 + 1; digit2 < endNumber - 2; digit2++)
            {
                for (int digit3 = digit2 + 1; digit3 < endNumber - 1; digit3++)
                {
                    for (int digit4 = digit3 + 1; digit4 < endNumber; digit4++)
                    {
                        for (int digit5 = digit4 + 1; digit5 <= endNumber; digit5++)
                        {
                            Console.WriteLine($"{digit1} {digit2} {digit3} {digit4} {digit5}");
                        }
                    }
                }
            }
        }
    }
}