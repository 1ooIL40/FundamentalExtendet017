namespace _05.User_Logins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UserLogins
    {
        public static void Main()
        {
            Dictionary<string, string> userData = new Dictionary<string, string>();

            string[] userNameAndPassword = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            //Fill the dictionary with the user data
            while (userNameAndPassword[0] != "login")
            {
                string name = userNameAndPassword[0];
                string passowrd = userNameAndPassword[2];

                if (!userData.ContainsKey(name))
                {
                    userData[name] = string.Empty;
                }
                userData[name] = passowrd;


                userNameAndPassword = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            }

            userNameAndPassword = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            int failLoginAttempts = 0;

            //Chek if the user give us the correct data
            while (userNameAndPassword[0] != "end")
            {
                string name = userNameAndPassword[0];
                string password = userNameAndPassword[2];

                if(userData.ContainsKey(name) && userData.ContainsValue(password))
                {
                    Console.WriteLine($"{name}: logged in successfully");
                }
                else
                {
                    Console.WriteLine($"{name}: login failed");
                    failLoginAttempts++;
                }

                userNameAndPassword = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine($"unsuccessful login attempts: {failLoginAttempts}");
        }
    }
}
