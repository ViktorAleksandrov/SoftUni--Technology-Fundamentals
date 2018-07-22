namespace P04.JsonParse
{
    using System;

    public class JsonParse
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Trim('[', ']')
                .Split(new[] { "}," }, StringSplitOptions.None);

            foreach (var studentData in input)
            {
                var studentParams = studentData
                    .Split(new[] { "\",", ",grades:[" }, StringSplitOptions.None);

                var name = studentParams[0].Substring(7);

                var age = studentParams[1].Substring(4);

                var gradesLength = studentParams[2].Length;

                var grades = studentParams[2].Substring(0, gradesLength - 1).Trim(']');

                if (grades == string.Empty)
                {
                    grades = "None";
                }

                Console.WriteLine($"{name} : {age} -> {grades}");
            }
        }
    }
}