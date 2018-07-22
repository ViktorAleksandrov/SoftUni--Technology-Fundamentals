namespace P03.ReverseArrayInPlace
{
    using System;
    using System.Linq;

    public class ReverseArrayInPlace
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var left = 0;
            var right = numbers.Length - 1;

            while (left < right)
            {
                var temp = numbers[left];
                numbers[left] = numbers[right];
                numbers[right] = temp;

                left++;
                right--;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}