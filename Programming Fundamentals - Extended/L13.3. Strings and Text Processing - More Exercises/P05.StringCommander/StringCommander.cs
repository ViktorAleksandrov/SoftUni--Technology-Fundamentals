namespace P05.StringCommander
{
    using System;

    public class StringCommander
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            var commandsLine = Console.ReadLine().Split();

            while (commandsLine[0] != "end")
            {
                var command = commandsLine[0];

                switch (command)
                {
                    case "Left":
                        var rotateLeftCnt = int.Parse(commandsLine[1]) % text.Length;
                        text = text.Substring(rotateLeftCnt)
                               + text.Substring(0, rotateLeftCnt);
                        break;
                    case "Right":
                        var rotateRightCnt = int.Parse(commandsLine[1]) % text.Length;
                        text = text.Substring(text.Length - rotateRightCnt)
                               + text.Substring(0, text.Length - rotateRightCnt);
                        break;
                    case "Insert":
                        var index = int.Parse(commandsLine[1]);
                        var textToInsert = commandsLine[2];
                        text = text.Insert(index, textToInsert);
                        break;
                    case "Delete":
                        var startIndex = int.Parse(commandsLine[1]);
                        var endIndex = int.Parse(commandsLine[2]);
                        text = text.Remove(startIndex, endIndex - startIndex + 1);
                        break;
                }

                commandsLine = Console.ReadLine().Split();
            }

            Console.WriteLine(text);
        }
    }
}