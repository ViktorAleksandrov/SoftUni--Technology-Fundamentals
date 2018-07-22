namespace P4.ReDirectory
{
    using System.IO;

    public class ReDirectory
    {
        public static void Main()
        {
            var files = Directory.GetFiles("input");

            Directory.CreateDirectory("output");

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);

                var extension = fileInfo.Extension.Substring(1);

                if (!Directory.Exists("output\\" + extension + "s"))
                {
                    Directory.CreateDirectory("output\\" + extension + "s");
                }

                var name = fileInfo.Name;

                Directory.Move("input\\" + name, "output\\" + extension + "s\\" + name);
            }
        }
    }
}