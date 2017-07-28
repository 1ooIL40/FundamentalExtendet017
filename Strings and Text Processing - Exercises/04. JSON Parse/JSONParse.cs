namespace _04.JSON_Parse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class JSONParse
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();

            string[] inputLine = Console.ReadLine()
                .Split(new string[] { "name:", "age:", "grades:", "[{", "}]"},
                StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < inputLine.Length; i += 3)
            {
                string[] name = inputLine[i]
                    .Split("\", ".ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries);

                int age = int.Parse(inputLine[i + 1].Remove(inputLine[i + 1].Length - 1));

                List<int> grades = inputLine[i + 2]
                    .Split("{[,]} ".ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                Student newStudent = new Student
                {
                    Name = name[0],
                    Age = age,
                    Grades = grades
                };

                students.Add(newStudent);
            }

            foreach (var student in students)
            {
                string name = student.Name;
                int age = student.Age;
                List<int> grades = student.Grades;

                bool haveGrades = grades.Count > 0;

                if (haveGrades)
                {
                    Console.WriteLine($"{name} : {age} -> {string.Join(", ", grades)}");
                }
                else
                {
                    Console.WriteLine($"{name} : {age} -> {"None"}");
                }
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<int> Grades { get; set; }
    }
}
