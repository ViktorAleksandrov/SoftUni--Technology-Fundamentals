namespace P06.ForumTopics
{
    using System;
    using System.Collections.Generic;

    public class ForumTopics
    {
        public static void Main()
        {
            var inputTopic = Console.ReadLine()
                .Split(new[] { " -> ", ", " }, StringSplitOptions.None);

            var forumTopics = new Dictionary<string, HashSet<string>>();

            while (inputTopic[0] != "filter")
            {
                var topic = inputTopic[0];

                if (!forumTopics.ContainsKey(topic))
                {
                    forumTopics[topic] = new HashSet<string>();
                }

                for (var index = 1; index < inputTopic.Length; index++)
                {
                    var tag = inputTopic[index];

                    forumTopics[topic].Add(tag);
                }

                inputTopic = Console.ReadLine()
                    .Split(new[] { " -> ", ", " }, StringSplitOptions.None);
            }

            var tagsSequence = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.None);

            foreach (var pair in forumTopics)
            {
                var tags = pair.Value;

                var isTagContained = true;

                foreach (var tagToFind in tagsSequence)
                {
                    if (!tags.Contains(tagToFind))
                    {
                        isTagContained = false;

                        break;
                    }
                }

                if (isTagContained)
                {
                    var topic = pair.Key;

                    Console.WriteLine($"{topic} | #{string.Join(", #", tags)}");
                }
            }
        }
    }
}