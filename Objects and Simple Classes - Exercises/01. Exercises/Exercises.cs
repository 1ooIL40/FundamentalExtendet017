namespace _01.Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Exercises
    {
        public static void Main()
        {
            List<Exercisess> exercises = new List<Exercisess>();

            string inputLine = Console.ReadLine();

            while (inputLine != "go go go")
            {
                string[] tokens = inputLine
                    .Split(" ->,".ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries);

                string topic = tokens[0];
                string courseName = tokens[1];
                string judgeLink = tokens[2];
                List<string> problems = tokens.Skip(3).ToList();


                Exercisess newExercise = new Exercisess
                {
                    Topic = topic,
                    CourseName = courseName,
                    JudgeContestLink = judgeLink,
                    Problems = problems
                };
                exercises.Add(newExercise);

                inputLine = Console.ReadLine();
            }

            foreach (var exercise in exercises)
            {
                Console.WriteLine($"Exercises: {exercise.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{exercise.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {exercise.JudgeContestLink}");

                for (int i = 0; i < exercise.Problems.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {exercise.Problems[i]}");
                }
            }
        }
    }

    public class Exercisess
    {
        public string Topic { get; set; }
        public string CourseName { get; set; }
        public string JudgeContestLink { get; set; }
        public List<string> Problems { get; set; }
    }
}
