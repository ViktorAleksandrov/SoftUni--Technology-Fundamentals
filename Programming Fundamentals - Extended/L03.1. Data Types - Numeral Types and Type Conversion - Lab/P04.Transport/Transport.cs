namespace P04.Transport
{
    using System;

    public class Transport
    {
        public static void Main()
        {
            var peopleNumber = int.Parse(Console.ReadLine());

            var capacity = 4 + 8 + 12;

            var courses = Math.Ceiling((double)peopleNumber / capacity);

            Console.WriteLine(courses);
        }
    }
}