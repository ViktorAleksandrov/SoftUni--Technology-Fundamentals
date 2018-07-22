namespace P02.TrackDownloader
{
    using System;
    using System.Collections.Generic;

    public class TrackDownloader
    {
        public static void Main()
        {
            var blacklistedWords = Console.ReadLine().Split();

            var fileName = Console.ReadLine();

            var songs = new List<string>();

            while (fileName != "end")
            {
                var isWordFound = false;

                foreach (var word in blacklistedWords)
                {
                    if (fileName.Contains(word))
                    {
                        isWordFound = true;

                        break;
                    }
                }

                if (!isWordFound)
                {
                    songs.Add(fileName);
                }

                fileName = Console.ReadLine();
            }

            songs.Sort();

            var output = string.Join(Environment.NewLine, songs);

            Console.WriteLine(output);
        }
    }
}