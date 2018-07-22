namespace P01.DayOfWeek
{
    using System;

    public class DayOfWeek
    {
        public static void Main()
        {
            var strDate = Console.ReadLine();

            var date = DateTime.ParseExact(strDate, "d-M-yyyy", null);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}