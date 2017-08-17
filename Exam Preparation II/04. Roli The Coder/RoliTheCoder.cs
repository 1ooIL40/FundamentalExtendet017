namespace _04.Roli_The_Coder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class  Event
    {
        public int Id { get; set; }

        public string EventName { get; set; }

        public List<string> Participants { get; set; }
    }

    public class RoliTheCoder
    {
        public static void Main()
        {
            List<Event> result = new List<Event>();
            Dictionary<int, Event> eventById = new Dictionary<int, Event>();

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "Time for Code")
                {
                    break;
                }

                string[] tokens = inputLine
                    .Split(new[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                int id = 0;
                if(!int.TryParse(tokens[0], out id))
                {
                    continue;
                }

                string eventName = null;

                if (tokens.Length > 1 && tokens[1].StartsWith("#"))
                {
                    eventName = tokens[1].Substring(1);
                }
                else
                {
                    continue;
                }

                List<string> participants = new List<string>();

                if(tokens.Length > 2)
                {
                    participants = tokens.Skip(2).ToList();
                    if (!participants.All(p => p.StartsWith("@")))
                    {
                        continue;
                    }
                }


                if(eventById.ContainsKey(id))
                {
                    if (eventById[id].EventName == eventName)
                    {
                        Event existingEvent = eventById[id];

                        foreach (var participant in participants)
                        {
                            if (!existingEvent.Participants.Contains(participant))
                            {
                                existingEvent.Participants.Add(participant);
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    Event newEvent = new Event
                    {
                        Id = id,
                        EventName = eventName,
                        Participants = participants
                    };

                    result.Add(newEvent);
                    eventById.Add(id, newEvent);
                }
            }

            List<Event> sortedEvents = result
                .OrderByDescending(p => p.Participants.Count)
                .ThenBy(e => e.EventName)
                .ToList();

            foreach (var ev in sortedEvents)
            {
                List<string> distinctParticipants = ev.Participants.Distinct().ToList();
                Console.WriteLine($"{ev.EventName} - {distinctParticipants.Count}");

                foreach (var participant in distinctParticipants.OrderBy(p=>p))
                {
                    Console.WriteLine(participant);
                }
            }

        }
    }
}
