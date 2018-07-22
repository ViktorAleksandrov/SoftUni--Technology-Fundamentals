namespace P02.Placeholders
{
    using System;

    public class Placeholders
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "end")
            {
                var inputParams = input
                    .Split(new[] { " -> " }, StringSplitOptions.None);

                var sentence = inputParams[0];

                var elements = inputParams[1]
                    .Split(new[] { ", " }, StringSplitOptions.None);

                for (var index = 0; index < elements.Length; index++)
                {
                    var placeholder = "{" + index + "}";
                    var currentElement = elements[index];

                    sentence = sentence.Replace(placeholder, currentElement);
                }

                Console.WriteLine(sentence);

                input = Console.ReadLine();
            }
        }
    }
}