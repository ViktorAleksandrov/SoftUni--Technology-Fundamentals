namespace P1.FilterExtensions
{
    using System;
    using System.IO;
    using System.Linq;

    public class FilterExtensions
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var files = Directory.GetFiles("input");

            var selectedFiles = files
                .Select(f => new FileInfo(f))
                .Where(f => f.Extension == $".{input}")
                .Select(f => f.Name);

            Console.WriteLine(
                string.Join(Environment.NewLine, selectedFiles));
        }
    }
}