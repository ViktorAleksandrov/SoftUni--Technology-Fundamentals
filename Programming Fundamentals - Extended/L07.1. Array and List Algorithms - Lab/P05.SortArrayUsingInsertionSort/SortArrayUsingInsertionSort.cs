namespace P05.SortArrayUsingInsertionSort
{
    using System;
    using System.Linq;

    public class SortArrayUsingInsertionSort
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (var index = 1; index < numbers.Length; index++)
            {
                for (var cnt = index; cnt > 0; cnt--)
                {
                    if (numbers[cnt - 1] <= numbers[cnt])
                    {
                        continue;
                    }

                    var temp = numbers[cnt];

                    numbers[cnt] = numbers[cnt - 1];
                    numbers[cnt - 1] = temp;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}