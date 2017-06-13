namespace _06.Notifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Notifications
    {
        public static void Main()
        {
            var numberOfOperations = int.Parse(Console.ReadLine());


            while (numberOfOperations > 0)
            {
                var command = Console.ReadLine();

                if(command == "success")
                {
                    ShowSuccess(command);

                }
                else if (command == "error")
                {
                    ShowError(command);
                }



                numberOfOperations--;
            }
        }

         static void ShowError(string command)
        {
            var inputLineOne = Console.ReadLine();
            var inputLineTwo = int.Parse(Console.ReadLine());

            var reason = "Internal System Failure";
            if (inputLineTwo >= 0)
            {
                reason = "Invalid Client Data";
            }

            Console.WriteLine($"Error: Failed to execute {inputLineOne}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Error Code: {inputLineTwo}.");
            Console.WriteLine($"Reason: {reason}.");

        }

        static void ShowSuccess(string command)
        {
            var inputLineOne = Console.ReadLine();
            var inputLineTwo = Console.ReadLine();

            Console.WriteLine($"Successfully executed {inputLineOne}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Message: {inputLineTwo}.");
        }
    }
}
