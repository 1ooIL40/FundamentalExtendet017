namespace _03.JSON_Stringify
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class JSONStringify
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (inputLine != "stringify")
            {
                string[] tokens = inputLine
                    .Split(" ,:->".ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries);

                string studentName = tokens[0];
                int studentAge = int.Parse(tokens[1]);
                List<int> studentGrades = tokens
                    .Skip(2)
                    .Select(int.Parse)
                    .ToList();

                Student newStudent = new Student
                {
                    Name = studentName,
                    Age = studentAge,
                    Grades = studentGrades
                };

                students.Add(newStudent);

                inputLine = Console.ReadLine();
            }
            string result = string.Empty;

            foreach (var student in students)
            {
                result += (string.Format("{{name:\"{0}\",age:{1},grades:[{2}]}},", 
                    student.Name, 
                    student.Age,
                    string.Join(", ",student.Grades)));
            }
            result = result
                .Remove(result.Length - 1);

            Console.WriteLine($"[{result}]");
        }
    }
     
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<int> Grades { get; set; }
    }
}
