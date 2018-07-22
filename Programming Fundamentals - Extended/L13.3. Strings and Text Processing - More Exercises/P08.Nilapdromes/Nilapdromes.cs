namespace P08.Nilapdromes
{
    using System;

    public class Nilapdromes
    {
        public static void Main()
        {
            var inputText = Console.ReadLine();

            while (inputText != "end")
            {
                var borderLength = inputText.Length / 2;

                if (inputText.Length % 2 == 0)
                {
                    borderLength--;
                }

                while (borderLength > 0)
                {
                    var leftBorder = inputText
                        .Substring(0, borderLength);

                    var rightBorder = inputText
                        .Substring(inputText.Length - borderLength);

                    if (leftBorder == rightBorder)
                    {
                        var core = inputText
                            .Substring(borderLength, inputText.Length - (borderLength * 2));

                        var nilapdrome = core + leftBorder + core;

                        Console.WriteLine(nilapdrome);

                        break;
                    }

                    borderLength--;
                }

                inputText = Console.ReadLine();
            }
        }
    }
}