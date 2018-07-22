namespace P06.ReplaceATag
{
    using System;
    using System.Text.RegularExpressions;

    public class ReplaceATag
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            while (text != "end")
            {
                var pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                var replacement = @"[URL href=$1]$2[/URL]";

                var replacedText = Regex.Replace(text, pattern, replacement);

                Console.WriteLine(replacedText);

                text = Console.ReadLine();
            }
        }
    }
}