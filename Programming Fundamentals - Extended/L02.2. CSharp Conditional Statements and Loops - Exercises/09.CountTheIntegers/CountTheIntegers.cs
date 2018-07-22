using System;

class CountTheIntegers
{
    static void Main()
    {
        int numberCounter = 0;

        while (true)
        {
            try
            {
                int input = int.Parse(Console.ReadLine());
                numberCounter++;
            }
            catch
            {
                Console.WriteLine(numberCounter);
                break;
            }
        }
    }
}