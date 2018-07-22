using System.Linq;

namespace P3.UserDatabase
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class UserDatabase
    {
        public static void Main()
        {
            if (!File.Exists("users.txt"))
            {
                File.Create("users.txt").Close();
            }

            var currentUsersDatabase = File.ReadAllLines("users.txt");

            var usersDatabase = new Dictionary<string, string>();

            foreach (var userData in currentUsersDatabase)
            {
                var userDataParams = userData.Split();

                var username = userDataParams[0];
                var password = userDataParams[1];

                usersDatabase[username] = password;
            }

            var inputLine = Console.ReadLine().Split();

            var command = inputLine[0];

            var isUserLoggedIn = false;

            while (command != "exit")
            {
                switch (command)
                {
                    case "register":
                        {
                            var username = inputLine[1];
                            var password = inputLine[2];
                            var confirmedPassword = inputLine[3];

                            if (usersDatabase.ContainsKey(username))
                            {
                                Console.WriteLine("The given username already exists.");
                            }
                            else if (password != confirmedPassword)
                            {
                                Console.WriteLine("The two passwords must match.");
                            }
                            else
                            {
                                usersDatabase[username] = password;

                                File.AppendAllText("users.txt", $"{username} {password}\r\n");
                            }
                        }

                        break;

                    case "login":
                        {
                            var username = inputLine[1];
                            var password = inputLine[2];

                            if (isUserLoggedIn)
                            {
                                Console.WriteLine("There is already a logged in user.");
                            }
                            else if (!usersDatabase.ContainsKey(username))
                            {
                                Console.WriteLine("There is no user with the given username.");
                            }
                            else if (password != usersDatabase[username])
                            {
                                Console.WriteLine("The password you entered is incorrect.");
                            }
                            else
                            {
                                isUserLoggedIn = true;
                            }
                        }

                        break;

                    case "logout":
                        if (!isUserLoggedIn)
                        {
                            Console.WriteLine("There is no currently logged in user.");
                        }

                        isUserLoggedIn = false;
                        break;
                }

                inputLine = Console.ReadLine().Split();

                command = inputLine[0];
            }
        }
    }
}