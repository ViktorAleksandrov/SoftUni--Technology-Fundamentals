namespace P04.Websites
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Websites
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var websites = new List<Website>();

            while (input != "end")
            {
                var inputParams = input
                    .Split(new[] { " | ", "," }, StringSplitOptions.None);

                var host = inputParams[0];
                var domain = inputParams[1];
                var queries = inputParams.Skip(2).ToList();

                websites.Add(new Website(host, domain, queries));

                input = Console.ReadLine();
            }

            foreach (var website in websites)
            {
                Console.Write($"https://www.{website.Host}.{website.Domain}");

                if (website.Queries.Count > 0)
                {
                    Console.Write($"/query?=[{string.Join("]&[", website.Queries)}]");
                }

                Console.WriteLine();
            }
        }

        public class Website
        {
            public Website(string host, string domain, List<string> queries)
            {
                this.Host = host;
                this.Domain = domain;
                this.Queries = queries;
            }

            public string Host { get; set; }

            public string Domain { get; set; }

            public List<string> Queries { get; set; }
        }
    }
}