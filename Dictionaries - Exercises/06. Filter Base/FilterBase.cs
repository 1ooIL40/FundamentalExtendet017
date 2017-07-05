namespace _06.Filter_Base
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FilterBase
    {
        public static void Main()
        {
            Dictionary<string, string> position = new Dictionary<string, string>();
            Dictionary<string, int> age = new Dictionary<string, int>();
            Dictionary<string, decimal> salary = new Dictionary<string, decimal>();


            string[] inputData = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            while (inputData[0] != "filter")
            {
                string name = inputData[0];
                string param = inputData[2];
                int personAge = 0;
                decimal personSalary = 0m;
                bool isPosition = true;

                if (int.TryParse(param, out personAge))
                {
                    if (!age.ContainsKey(name))
                    {
                        age[name] = 0;
                    }
                    age[name] = personAge;
                }
                else if (decimal.TryParse(param, out personSalary))
                {
                    if (!salary.ContainsKey(name))
                    {
                        salary[name] = 0m;
                    }
                    salary[name] = personSalary;
                }
                else
                {
                    if (!position.ContainsKey(name))
                    {
                        position[name] = string.Empty;
                    }
                    position[name] = param;
                }

                inputData = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            }

            inputData = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            switch (inputData[0])
            {
                case "Position":
                    Print(position);
                    break;
                case "Age":
                    Print(age);
                    break;
                case "Salary":
                    Print(salary);
                    break;
            }
        }

        static void Print(Dictionary<string,string> personData)
        {
            foreach (var person in personData)
            {
                Console.WriteLine($"Name: {person.Key}");
                Console.WriteLine($"Position: {person.Value}");
                Console.WriteLine(new string('=', 20));
            }
        }
        static void Print(Dictionary<string, int> personData)
        {
            foreach (var person in personData)
            {
                Console.WriteLine($"Name: {person.Key}");
                Console.WriteLine($"Age: {person.Value}");
                Console.WriteLine(new string('=', 20));
            }
        }
        static void Print(Dictionary<string, decimal> personData)
        {
            foreach (var person in personData)
            {
                Console.WriteLine($"Name: {person.Key}");
                Console.WriteLine($"Salary: {person.Value:f2}");
                Console.WriteLine(new string('=', 20));
            }
        }
    }
}
