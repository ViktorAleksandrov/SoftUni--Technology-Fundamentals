namespace P09.LargestElementInArray
{
    using System;

    public class LargestElementInArray
    {
        public static void Main()
        {
            var numberCount = int.Parse(Console.ReadLine());

            var arr = new int[numberCount];

            var largestElement = int.MinValue;

            for (var index = 0; index < numberCount; index++)
            {
                arr[index] = int.Parse(Console.ReadLine());

                var currentElement = arr[index];

                if (currentElement > largestElement)
                {
                    largestElement = currentElement;
                }
            }

            Console.WriteLine(largestElement);
        }
    }
}