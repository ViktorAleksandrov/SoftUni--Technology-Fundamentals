namespace P03.SortArrayOfStrings
{
    using System;

    public class SortArrayOfStrings
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();

            var isSwapped = false;

            do
            {
                isSwapped = false;

                for (var index = 0; index < input.Length - 1; index++)
                {
                    var currentElement = input[index];
                    var nextElement = input[index + 1];

                    if (currentElement.CompareTo(nextElement) > 0)
                    {
                        var temp = currentElement;
                        input[index] = nextElement;
                        input[index + 1] = temp;

                        isSwapped = true;
                    }
                }
            }
            while (isSwapped);

            Console.WriteLine(string.Join(" ", input));
        }
    }
}