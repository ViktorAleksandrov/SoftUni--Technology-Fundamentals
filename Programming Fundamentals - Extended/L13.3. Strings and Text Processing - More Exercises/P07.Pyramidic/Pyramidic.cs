namespace P07.Pyramidic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Pyramidic
    {
        public static void Main()
        {
            var linesNumber = int.Parse(Console.ReadLine());

            var lines = new List<string>();
            var pyramids = new List<string>();

            for (var index = 0; index < linesNumber; index++)
            {
                lines.Add(Console.ReadLine());
            }

            for (var cnt = 0; cnt < lines.Count; cnt++)
            {
                var currentLine = lines[cnt];

                foreach (var symbol in currentLine)
                {
                    var lineCharsCount = 1;
                    var currentPyramid = string.Empty;

                    for (var pos = cnt; pos < lines.Count; pos++)
                    {
                        var currentPyramidLine = new string(symbol, lineCharsCount);

                        if (lines[pos].Contains(currentPyramidLine))
                        {
                            currentPyramid += currentPyramidLine + Environment.NewLine;
                        }
                        else
                        {
                            break;
                        }

                        lineCharsCount += 2;
                    }

                    pyramids.Add(currentPyramid.Trim());
                }
            }

            var biggestPyramid = pyramids.OrderByDescending(p => p.Length).First();

            Console.WriteLine(biggestPyramid);
        }
    }
}