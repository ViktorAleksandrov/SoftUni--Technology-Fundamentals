namespace P04.RoliTheCoder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RoliTheCoder
    {
        public static void Main()
        {
            var idsEvents = new Dictionary<string, string>();

            var eventsParticipants = new SortedDictionary<string, SortedSet<string>>();

            while (true)
            {
                var request = Console.ReadLine();

                if (request == "Time for Code")
                {
                    break;
                }

                var requestParts = request
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var id = requestParts[0];
                var hashtagEvent = requestParts[1];

                if (!hashtagEvent.StartsWith("#"))
                {
                    continue;
                }

                var noHashtagEvent = hashtagEvent.Substring(1);

                if (!idsEvents.ContainsKey(id))
                {
                    idsEvents[id] = noHashtagEvent;
                    eventsParticipants[noHashtagEvent] = new SortedSet<string>();
                }
                else if (idsEvents[id] != noHashtagEvent)
                {
                    continue;
                }

                var participants = requestParts.Skip(2);

                foreach (var participant in participants)
                {
                    eventsParticipants[noHashtagEvent].Add(participant);
                }
            }

            foreach (var eventData in eventsParticipants.OrderByDescending(kvp => kvp.Value.Count))
            {
                var currentEvent = eventData.Key;

                var participants = eventsParticipants[currentEvent];

                Console.WriteLine($"{currentEvent} - {participants.Count}");

                foreach (var participant in participants)
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}