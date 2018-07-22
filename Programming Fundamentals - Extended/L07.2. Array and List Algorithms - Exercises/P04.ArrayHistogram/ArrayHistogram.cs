namespace P04.ArrayHistogram
{
    using System;
    using System.Collections.Generic;

    public class ArrayHistogram
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();

            var words = new List<string>();
            var occurencesCnt = new List<int>();

            foreach (var element in input)
            {
                if (!words.Contains(element))
                {
                    words.Add(element);
                    occurencesCnt.Add(1);
                }
                else
                {
                    var index = words.IndexOf(element);

                    occurencesCnt[index]++;
                }
            }

            var isElementSwapped = false;

            do
            {
                isElementSwapped = false;

                for (var index = 0; index < occurencesCnt.Count - 1; index++)
                {
                    if (occurencesCnt[index] < occurencesCnt[index + 1])
                    {
                        var temp = occurencesCnt[index];

                        occurencesCnt[index] = occurencesCnt[index + 1];
                        occurencesCnt[index + 1] = temp;

                        var tempWord = words[index];

                        words[index] = words[index + 1];
                        words[index + 1] = tempWord;

                        isElementSwapped = true;
                    }
                }
            }
            while (isElementSwapped);

            var percentage = 100.0 / input.Length;

            for (var i = 0; i < words.Count; i++)
            {
                Console.WriteLine(
                    $"{words[i]} -> {occurencesCnt[i]} times ({occurencesCnt[i] * percentage:f2}%)");
            }
        }
    }
}