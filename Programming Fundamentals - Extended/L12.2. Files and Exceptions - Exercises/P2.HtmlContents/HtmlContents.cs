namespace P2.HtmlContents
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class HtmlContents
    {
        public static void Main()
        {
            var path = "index.html";

            File.WriteAllText(path, "<!DOCTYPE html>\r\n");
            File.AppendAllText(path, "<html>\r\n");
            File.AppendAllText(path, "<head>\r\n");

            var inputLine = Console.ReadLine().Split();

            var title = string.Empty;

            var tags = new List<string>();

            while (inputLine[0] != "exit")
            {
                var tag = inputLine[0];
                var content = inputLine[1];

                var line = $"\t<{tag}>{content}</{tag}>";

                if (tag == "title")
                {
                    title = line;
                }
                else
                {
                    tags.Add(line);
                }

                inputLine = Console.ReadLine().Split();
            }

            File.AppendAllText(path, title + "\r\n");
            File.AppendAllText(path, "</head>\r\n");
            File.AppendAllText(path, "<body>\r\n");

            File.AppendAllLines(path, tags);

            File.AppendAllText(path, "</body>\r\n");
            File.AppendAllText(path, "</html>\r\n");

            var fileContent = File.ReadAllLines("index.html");

            Console.WriteLine(
                string.Join(Environment.NewLine, fileContent));

            File.WriteAllLines("index.html", fileContent);
        }
    }
}