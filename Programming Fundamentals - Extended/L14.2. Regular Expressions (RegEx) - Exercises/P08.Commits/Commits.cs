namespace P08.Commits
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Commits
    {
        public static void Main()
        {
            var url = Console.ReadLine();

            var regex = new Regex(
                @"^https:\/\/github.com\/(?<user>[a-zA-Z\d-]+)\/(?<repo>[a-zA-Z_-]+)\/commit\/(?<hash>[a-f\d]{40}),(?<message>[^\n]+),(?<additions>\d+),(?<deletions>\d+)$");

            var githubData = new SortedDictionary<string, SortedDictionary<string, List<Commit>>>();

            while (url != "git push")
            {
                var matchedUrl = regex.Match(url);

                if (matchedUrl.Success)
                {
                    var user = matchedUrl.Groups["user"].Value;
                    var repo = matchedUrl.Groups["repo"].Value;

                    if (!githubData.ContainsKey(user))
                    {
                        githubData[user] = new SortedDictionary<string, List<Commit>>();
                    }

                    if (!githubData[user].ContainsKey(repo))
                    {
                        githubData[user][repo] = new List<Commit>();
                    }

                    var hash = matchedUrl.Groups["hash"].Value;
                    var message = matchedUrl.Groups["message"].Value;
                    var additions = int.Parse(matchedUrl.Groups["additions"].Value);
                    var deletions = int.Parse(matchedUrl.Groups["deletions"].Value);

                    githubData[user][repo].Add(new Commit(hash, message, additions, deletions));
                }

                url = Console.ReadLine();
            }

            foreach (var data in githubData)
            {
                var user = data.Key;

                Console.WriteLine($"{user}:");

                var reposData = data.Value;

                foreach (var repoData in reposData)
                {
                    var repo = repoData.Key;

                    Console.WriteLine($"  {repo}:");

                    var commitsData = repoData.Value;

                    foreach (var commit in commitsData)
                    {
                        Console.WriteLine(
                            $"    commit {commit.Hash}: {commit.Message} ({commit.Additions} additions, {commit.Deletions} deletions)");
                    }

                    var totalAdditions = commitsData.Sum(c => c.Additions);
                    var totalDelitions = commitsData.Sum(c => c.Deletions);

                    Console.WriteLine($"    Total: {totalAdditions} additions, {totalDelitions} deletions");
                }
            }
        }

        public class Commit
        {
            public Commit(string commitHash, string message, int additions, int deletions)
            {
                this.Hash = commitHash;
                this.Message = message;
                this.Additions = additions;
                this.Deletions = deletions;
            }

            public string Hash { get; set; }

            public string Message { get; set; }

            public int Additions { get; set; }

            public int Deletions { get; set; }
        }
    }
}