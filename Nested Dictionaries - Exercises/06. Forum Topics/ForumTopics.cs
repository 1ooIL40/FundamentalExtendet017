namespace _06.Forum_Topics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ForumTopics
    {
        public static void Main()
        {
            var forumTopics = new Dictionary<string, HashSet<string>>();

            string inputLine = Console.ReadLine();

            while (inputLine != "filter")
            {
                string[] inputTokes = inputLine
                    .Split(new string[] { " -> " },
                    StringSplitOptions.RemoveEmptyEntries);

                string topic = inputTokes[0];
                List<string> tags = inputTokes[1]
                    .Split(", ".ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (!forumTopics.ContainsKey(topic))
                {
                    forumTopics[topic] = new HashSet<string>();
                }
                foreach (var tag in tags)
                {
                    forumTopics[topic].Add(tag);
                }

                inputLine = Console.ReadLine();
            }

            inputLine = Console.ReadLine();

            string[] tagSequence = inputLine
                .Split((" ,").ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries);

            foreach (var topic in forumTopics)
            {
                bool contains = true;
                
                    for (int i = 0; i < tagSequence.Length; i++)
                    {
                        if (!topic.Value.Contains(tagSequence[i]))
                        {
                            contains = false;
                            break;
                        }
                    }

                if (contains)
                {
                    Console.WriteLine($"{topic.Key} | #{string.Join(", #",topic.Value)}");
                }
            }
        }
    }
}
