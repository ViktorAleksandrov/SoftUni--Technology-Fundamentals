namespace P04.DeserializeString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DeserializeString
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var wordContent = new SortedDictionary<int, char>();

            while (input != "end")
            {
                var inputParams = input.Split(':');

                var currentChar = inputParams[0][0];

                var indices = inputParams[1]
                    .Split('/')
                    .Select(int.Parse);

                foreach (var index in indices)
                {
                    wordContent[index] = currentChar;
                }

                input = Console.ReadLine();
            }

            var word = wordContent.Values.ToArray();

            Console.WriteLine(word);
        }
    }
}