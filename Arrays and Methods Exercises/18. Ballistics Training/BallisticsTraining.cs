namespace _18.Ballistics_Training
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BallisticsTraining
    {
        public static void Main()
        {
            var airplaneCoordinates = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var commands = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var x = 0;
            var y = 0;

            for (int i = 0; i < commands.Count; i += 2)
            {
                var command = commands[i];
                var coordinates = int.Parse(commands[i + 1]);

                switch (command)
                {
                    case "right":
                        x += coordinates;
                        break;
                    case "left":
                        x -= coordinates;
                        break;
                    case "down":
                        y -= coordinates;
                        break;
                    case "up":
                        y += coordinates;
                        break;
                }

            }

            var result = "better luck next time...";

            if (x == airplaneCoordinates[0] && y == airplaneCoordinates[1])
            {
                result = "got 'em!";
            }

            Console.WriteLine($"firing at [{x}, {y}] {Environment.NewLine}{result}");
        }
    }
}
