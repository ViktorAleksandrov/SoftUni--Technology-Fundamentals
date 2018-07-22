namespace P10.CountOfNegativeElementsInArray
{
    using System;

    public class CountOfNegativeElementsInArray
    {
        private static void Main()
        {
            var numbersCount = int.Parse(Console.ReadLine());

            var arr = new int[numbersCount];

            var negativesCount = 0;

            for (var index = 0; index < numbersCount; index++)
            {
                arr[index] = int.Parse(Console.ReadLine());

                var currentElement = arr[index];

                if (currentElement < 0)
                {
                    negativesCount++;
                }
            }

            Console.WriteLine(negativesCount);
        }
    }
}