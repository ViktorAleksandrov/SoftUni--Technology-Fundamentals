namespace P06.InsertionSortUsingList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class InsertionSortUsingList
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var list = new List<int>();

            foreach (var arrElement in arr)
            {
                var isElementInserted = false;

                for (var listIndex = 0; listIndex < list.Count; listIndex++)
                {
                    var currentListElement = list[listIndex];

                    if (arrElement < currentListElement)
                    {
                        list.Insert(listIndex, arrElement);

                        isElementInserted = true;
                        break;
                    }
                }

                if (!isElementInserted)
                {
                    list.Add(arrElement);
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}