namespace P03.SerializeString
{
    using System;
    using System.Collections.Generic;

    public class SerializeString
    {
        public static void Main()
        {
            var word = Console.ReadLine();

            var chars = new List<char>();

            foreach (var symbol in word)
            {
                if (chars.Contains(symbol))
                {
                    continue;
                }

                chars.Add(symbol);

                var index = word.IndexOf(symbol);

                var isFirstOccurence = true;

                while (index != -1)
                {
                    Console.Write(isFirstOccurence
                        ? $"{symbol}:{index}"
                        : $"/{index}");

                    index = word.IndexOf(symbol, index + 1);

                    isFirstOccurence = false;
                }

                Console.WriteLine();
            }
        }
    }
}