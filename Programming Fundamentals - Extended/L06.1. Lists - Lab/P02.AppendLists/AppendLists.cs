namespace P02.AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AppendLists
    {
        public static void Main()
        {
            var stringList = Console.ReadLine()
                .Split('|')
                .Reverse()
                .ToList();

            var results = new List<int>();

            foreach (var token in stringList)
            {
                var temp = token.Split();

                foreach (var item in temp)
                {
                    if (item != string.Empty)
                    {
                        results.Add(int.Parse(item));
                    }
                }
            }

            Console.WriteLine(string.Join(" ", results));
        }
    }
}