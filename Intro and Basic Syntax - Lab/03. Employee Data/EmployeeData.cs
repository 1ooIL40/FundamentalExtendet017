namespace _03.Employee_Data
{
    using System;

    public class EmployeeData
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var id = Console.ReadLine();
            var salary = decimal.Parse(Console.ReadLine());

            var len = id.Length;
            var outputID = string.Empty;

            for (int i = len; i < 8; i++)
            {
                outputID += "0";
            }
            outputID += id;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {outputID}");
            Console.WriteLine($"Salary: {salary:f2}");
        }
    }
}
