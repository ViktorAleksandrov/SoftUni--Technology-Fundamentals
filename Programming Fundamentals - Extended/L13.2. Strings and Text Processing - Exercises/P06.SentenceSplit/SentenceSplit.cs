namespace P06.SentenceSplit
{
    using System;

    public class SentenceSplit
    {
        public static void Main()
        {
            var sentence = Console.ReadLine();
            var delimiter = Console.ReadLine();

            var words = sentence
                .Split(new[] { delimiter }, StringSplitOptions.None);

            Console.WriteLine($"[{string.Join(", ", words)}]");
        }
    }
}