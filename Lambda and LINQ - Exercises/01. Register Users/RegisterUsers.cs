namespace _01.Register_Users
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class Users
    {
        //Dictionary<string, DateTime> Registration = new Dictionary<string, DateTime>();

        public string Name { get; set; }

        public DateTime DataRegistration { get; set; }
    }

    public class RegisterUsers
    {
        public static void Main()
        {
            List<Users> registration = new List<Users>();

            string[] inputLine = Console.ReadLine()
                .Split(new string[] { " -> " },
                StringSplitOptions.RemoveEmptyEntries);

            int outputNumberOfRegistertUsers = 5;

            while (inputLine[0] != "end")
            {
                string name = inputLine[0];
                DateTime dateOfRegistration = DateTime.ParseExact(inputLine[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                Users newUser = new Users
                {
                    Name = name,
                    DataRegistration = dateOfRegistration
                };

                registration.Add(newUser);

                inputLine = Console.ReadLine()
                .Split(new string[] { " -> " },
                StringSplitOptions.RemoveEmptyEntries);
            }

            registration.Reverse();

            registration = registration
                .OrderBy(r => r.DataRegistration)
                .Take(outputNumberOfRegistertUsers)
                .OrderByDescending(r => r.DataRegistration)
                .ToList();

            foreach (var user in registration)
            {
                Console.WriteLine(user.Name);
            }
        }
    }
}
