namespace _01.Average_Student_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageStudentGrades
    {
        public static void Main()
        {
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                double grader = double.Parse(input[1]);

                //Add to the dictionary
                if (!studentGrades.ContainsKey(name))
                {
                    studentGrades[name] = new List<double>();
                }
                studentGrades[name].Add(grader);

            }

            //Iterate to the keys and valuse and print
            foreach (var student in studentGrades)
            {
                Console.Write($"{student.Key} -> ");

                foreach (var value in student.Value)
                {
                    Console.Write($"{value:f2} ");
                }
                Console.WriteLine($"(avg: { student.Value.Average():f2})");
            }

        }
    }
}
