namespace P07.LargestNElements
{
    using System;
    using System.Linq;

    public class LargestNElements
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var largestElementsNumber = int.Parse(Console.ReadLine());

            for (var index = 1; index < numbers.Count; index++)
            {
                for (var cnt = index; cnt > 0; cnt--)
                {
                    if (numbers[cnt - 1] < numbers[cnt])
                    {
                        var temp = numbers[cnt];

                        numbers[cnt] = numbers[cnt - 1];
                        numbers[cnt - 1] = temp;
                    }
                }
            }

            for (var i = 0; i < largestElementsNumber; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
        }
    }
}