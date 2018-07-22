namespace P01.SumArrayElements
{
    using System;

    public class SumArrayElements
    {
        private static void Main()
        {
            var elementsCount = int.Parse(Console.ReadLine());

            var arr = new int[elementsCount];

            var sum = 0;

            for (var index = 0; index < arr.Length; index++)
            {
                arr[index] = int.Parse(Console.ReadLine());

                var currentNumber = arr[index];

                sum += currentNumber;
            }

            Console.WriteLine(sum);
        }
    }
}