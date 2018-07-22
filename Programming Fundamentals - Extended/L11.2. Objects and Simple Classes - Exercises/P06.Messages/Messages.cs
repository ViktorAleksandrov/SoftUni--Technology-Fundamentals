namespace P06.Messages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Messages
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine().Split();

            var usernames = new List<string>();
            var messageUser = new Dictionary<Message, User>();

            while (inputLine[0] != "exit")
            {
                if (inputLine[0] == "register")
                {
                    var username = inputLine[1];

                    usernames.Add(username);
                }
                else
                {
                    var sender = inputLine[0];
                    var recipient = inputLine[2];
                    var content = inputLine[3];

                    if (usernames.Contains(sender) && usernames.Contains(recipient))
                    {
                        var user = new User(recipient, content);
                        var message = new Message(content, sender);

                        messageUser[message] = user;
                    }
                }

                inputLine = Console.ReadLine().Split();
            }

            inputLine = Console.ReadLine().Split();

            var firstUser = inputLine[0];
            var secondUser = inputLine[1];

            var firstUserList = messageUser
                .Where(kvp => kvp.Key.Sender == firstUser && kvp.Value.Username == secondUser);

            var secondUserList = messageUser
                .Where(kvp => kvp.Key.Sender == secondUser && kvp.Value.Username == firstUser);

            if (firstUserList.Count() == 0 && secondUserList.Count() == 0)
            {
                Console.WriteLine("No messages");

                return;
            }

            var firstUserListLeft = new List<string>();
            var firstUserListRight = new List<string>();

            foreach (var kvp in firstUserList)
            {
                firstUserListLeft.Add(kvp.Key.Sender);
                firstUserListRight.Add(kvp.Key.Content);
            }

            var secondUserListLeft = new List<string>();
            var secondUserListRight = new List<string>();

            foreach (var kvp in secondUserList)
            {
                secondUserListLeft.Add(kvp.Key.Content);
                secondUserListRight.Add(kvp.Key.Sender);
            }

            var maxLength = Math.Max(firstUserListLeft.Count, secondUserListLeft.Count);

            for (var index = 0; index < maxLength; index++)
            {
                if (index < firstUserListLeft.Count)
                {
                    Console.Write(firstUserListLeft[index] + ": ");
                    Console.WriteLine(firstUserListRight[index]);
                }

                if (index < secondUserListLeft.Count)
                {
                    Console.Write(secondUserListLeft[index] + " :");
                    Console.WriteLine(secondUserListRight[index]);
                }
            }
        }

        public class User
        {
            public User(string username, string message)
            {
                this.Username = username;
                this.Content = message;
            }

            public string Username { get; set; }

            public string Content { get; set; }
        }

        public class Message
        {
            public Message(string message, string sender)
            {
                this.Content = message;
                this.Sender = sender;
            }

            public string Content { get; set; }

            public string Sender { get; set; }
        }
    }
}