namespace P06.StuckZipper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StuckZipper
    {
        public static void Main()
        {
            var firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var concatLists = firstList.Concat(secondList).ToList();

            var minLength = GetMinLength(concatLists);

            var filteredFirstList = FilterNumbers(firstList, minLength);
            var filteredSecondList = FilterNumbers(secondList, minLength);

            var listsMaxLength = Math.Max(
                filteredFirstList.Count, filteredSecondList.Count);

            var zippedList = new List<int>();

            for (var index = 0; index < listsMaxLength; index++)
            {
                AddNumbersToList(filteredSecondList, zippedList, index);

                AddNumbersToList(filteredFirstList, zippedList, index);
            }

            Console.WriteLine(string.Join(" ", zippedList));
        }

        private static int GetMinLength(List<int> list)
        {
            var minLength = int.MaxValue;

            foreach (var number in list)
            {
                var numberLength = GetNumberLength(number);

                if (numberLength < minLength)
                {
                    minLength = numberLength;
                }
            }

            return minLength;
        }

        private static void AddNumbersToList(List<int> list, List<int> zippedList, int index)
        {
            if (index < list.Count)
            {
                var currentElement = list[index];

                zippedList.Add(currentElement);
            }
        }

        private static List<int> FilterNumbers(List<int> list, int minLength)
        {
            var filteredList = new List<int>();

            foreach (var number in list)
            {
                var numberLength = GetNumberLength(number);

                if (numberLength <= minLength)
                {
                    filteredList.Add(number);
                }
            }

            return filteredList;
        }

        private static int GetNumberLength(int number)
        {
            number = Math.Abs(number);

            var numberLength = 0;

            while (number > 0)
            {
                numberLength++;

                number /= 10;
            }

            return numberLength;
        }
    }
}