namespace _17.Altitude
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Altitude
    {
        public static void Main()
        {
            var startPoint = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var altitude = double.Parse(startPoint[0]);
            var isCrashed = false;
            var result = string.Empty;

            for (int i = 1; i < startPoint.Count; i += 2)
            {
                var command = startPoint[i];
                var number = double.Parse(startPoint[i + 1]);

                switch (command)
                {
                    case "up":
                        altitude += number;
                        break;
                    case "down":
                        altitude -= number;
                        break;
                }

                if (altitude <= 0)
                {
                    result = "crashed";
                    isCrashed = true;
                    break;
                }
            }
            if (!isCrashed)
            {
                result = $"got through safely. current altitude: {altitude}m";
            }

            Console.WriteLine(result);
        }
    }
}
