namespace P03.RecordUniqueNames
{
    using System;
    using System.Collections.Generic;

    public class RecordUniqueNames
    {
        public static void Main()
        {
            var linesCount = int.Parse(Console.ReadLine());

            var names = new HashSet<string>();

            for (var index = 0; index < linesCount; index++)
            {
                var name = Console.ReadLine();

                names.Add(name);
            }

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}