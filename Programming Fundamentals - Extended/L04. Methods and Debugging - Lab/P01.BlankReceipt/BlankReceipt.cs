namespace P01.BlankReceipt
{
    using System;

    public class BlankReceipt
    {
        public static void Main()
        {
            PrintReceipt();
        }

        public static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        public static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        public static void PrintFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }

        public static void PrintReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
    }
}
