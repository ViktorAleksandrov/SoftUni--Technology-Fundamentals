namespace P01.FindTheLetter
{
    using System;

    public class FindTheLetter
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var arr = Console.ReadLine().Split();

            var index = -1;

            var letterToSearch = arr[0];
            var occurenceNum = int.Parse(arr[1]);

            for (var cnt = 0; cnt < occurenceNum; cnt++)
            {
                index = text.IndexOf(letterToSearch, index + 1);

                if (index == -1)
                {
                    Console.WriteLine("Find the letter yourself!");

                    return;
                }
            }

            Console.WriteLine(index);
        }
    }
}