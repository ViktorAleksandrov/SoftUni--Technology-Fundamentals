namespace P04.Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Files
    {
        public static void Main()
        {
            var filesNumber = int.Parse(Console.ReadLine());

            var filesPaths = new Dictionary<string, SortedDictionary<string, long>>();

            for (var index = 0; index < filesNumber; index++)
            {
                var input = Console.ReadLine().Split('\\');

                var rootDirectory = input[0];

                var fileData = input.Last().Split(';');

                var fileName = fileData[0];
                var fileSize = long.Parse(fileData[1]);

                if (!filesPaths.ContainsKey(rootDirectory))
                {
                    filesPaths[rootDirectory] = new SortedDictionary<string, long>();
                }

                filesPaths[rootDirectory][fileName] = fileSize;
            }

            var query = Console.ReadLine().Split();

            var fileExtension = $".{query[0]}";
            var rootFolder = query[2];

            var isFound = false;

            if (filesPaths.ContainsKey(rootFolder))
            {
                foreach (var kvp in filesPaths[rootFolder].OrderByDescending(kvp => kvp.Value))
                {
                    var fileName = kvp.Key;
                    var fileSize = kvp.Value;

                    if (fileName.Contains(fileExtension))
                    {
                        Console.WriteLine($"{fileName} - {fileSize} KB ");

                        isFound = true;
                    }
                }
            }

            if (!isFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}