namespace P05.IncreasingCrisis
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IncreasingCrisis
    {
        public static void Main()
        {
            var linesCount = int.Parse(Console.ReadLine());

            var resultList = new List<int>();

            for (var index = 0; index < linesCount; index++)
            {
                var sequence = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

                if (resultList.Count == 0 || resultList[resultList.Count - 1] <= sequence.First())
                {
                    for (var cnt = 0; cnt < sequence.Count; cnt++)
                    {
                        resultList.Add(sequence[cnt]);

                        if (cnt < sequence.Count - 1)
                        {
                            if (sequence[cnt] > sequence[cnt + 1])
                            {
                                break;
                            }
                        }
                    }
                }
                else
                {
                    var insertIndex = 0;

                    for (var i = 0; i < resultList.Count; i++)
                    {
                        if (resultList[i] > sequence.First())
                        {
                            insertIndex = i;

                            break;
                        }
                    }

                    foreach (var number in sequence)
                    {
                        resultList.Insert(insertIndex, number);

                        if (resultList[insertIndex] > resultList[insertIndex + 1])
                        {
                            break;
                        }

                        insertIndex++;
                    }

                    for (var j = 0; j < resultList.Count - 1; j++)
                    {
                        if (resultList[j] > resultList[j + 1])
                        {
                            for (var k = j + 1; k < resultList.Count; k++)
                            {
                                resultList.RemoveAt(k);

                                k--;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}