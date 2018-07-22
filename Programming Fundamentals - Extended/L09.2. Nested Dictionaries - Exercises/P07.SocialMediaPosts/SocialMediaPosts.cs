namespace P07.SocialMediaPosts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SocialMediaPosts
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var likes = new Dictionary<string, int>();
            var dislikes = new Dictionary<string, int>();
            var comments = new Dictionary<string, Dictionary<string, string>>();

            while (input != "drop the media")
            {
                var inputTokens = input.Split().ToList();

                var command = inputTokens[0];
                var post = inputTokens[1];

                switch (command)
                {
                    case "post":
                        likes[post] = 0;
                        dislikes[post] = 0;
                        comments[post] = new Dictionary<string, string>();
                        break;
                    case "like":
                        likes[post]++;
                        break;
                    case "dislike":
                        dislikes[post]++;
                        break;
                    case "comment":
                        var commentator = inputTokens[2];
                        inputTokens.RemoveRange(0, 3);
                        var comment = string.Join(" ", inputTokens);
                        comments[post].Add(commentator, comment);
                        break;
                }

                input = Console.ReadLine();
            }

            foreach (var post in likes.Keys)
            {
                var likesCnt = likes[post];
                var dislikesCnt = dislikes[post];

                Console.WriteLine(
                    $"Post: {post} | Likes: {likesCnt} | Dislikes: {dislikesCnt}");
                Console.WriteLine("Comments:");

                if (comments[post].Count == 0)
                {
                    Console.WriteLine("None");

                    continue;
                }

                foreach (var commentator in comments[post].Keys)
                {
                    var comment = comments[post][commentator];

                    Console.WriteLine($"*  {commentator}: {comment}");
                }
            }
        }
    }
}