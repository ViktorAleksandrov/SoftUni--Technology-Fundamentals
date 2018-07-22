namespace P03.JsonStringify
{
    using System;

    public class JsonStringify
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            Console.Write('[');

            var isFirstIteration = true;

            while (input != "stringify")
            {
                var inputParams = input
                    .Split(new[] { " : ", " ->" }, StringSplitOptions.None);

                var name = inputParams[0];
                var age = inputParams[1];
                var grades = inputParams[2].Trim();

                if (!isFirstIteration)
                {
                    Console.Write(',');
                }

                Console.Write(
                    $"{{name:\"{name}\",age:{age},grades:[{grades}]}}");

                isFirstIteration = false;

                input = Console.ReadLine();
            }

            Console.WriteLine(']');
        }
    }
}