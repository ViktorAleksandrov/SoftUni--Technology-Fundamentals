namespace P05.UserLogins
{
    using System;
    using System.Collections.Generic;

    public class UserLogins
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();

            var namesPasswords = new Dictionary<string, string>();

            while (input[0] != "login")
            {
                var user = input[0];
                var pass = input[2];

                namesPasswords[user] = pass;

                input = Console.ReadLine().Split();
            }

            input = Console.ReadLine().Split();

            var countFailedLogins = 0;

            while (input[0] != "end")
            {
                var name = input[0];
                var password = input[2];

                if (namesPasswords.ContainsKey(name) && namesPasswords[name] == password)
                {
                    Console.WriteLine($"{name}: logged in successfully");
                }
                else
                {
                    Console.WriteLine($"{name}: login failed");

                    countFailedLogins++;
                }

                input = Console.ReadLine().Split();
            }

            Console.WriteLine($"unsuccessful login attempts: {countFailedLogins}");
        }
    }
}