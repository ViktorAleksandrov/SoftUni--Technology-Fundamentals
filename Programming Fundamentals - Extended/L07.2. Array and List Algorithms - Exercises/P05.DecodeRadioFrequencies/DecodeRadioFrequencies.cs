namespace P05.DecodeRadioFrequencies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DecodeRadioFrequencies
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ', '.');

            var leftPart = new List<char>();

            for (var index = 0; index < input.Length; index += 2)
            {
                if (input[index] != "0")
                {
                    leftPart.Add((char)int.Parse(input[index]));
                }
            }

            var rightPart = new List<char>();

            for (var cnt = 1; cnt < input.Length; cnt += 2)
            {
                if (input[cnt] != "0")
                {
                    rightPart.Add((char)int.Parse(input[cnt]));
                }
            }

            rightPart.Reverse();

            var resultList = leftPart.Concat(rightPart);

            Console.WriteLine(string.Join(string.Empty, resultList));
        }
    }
}