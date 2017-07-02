namespace _01.Rabbit_Hole
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RabbitHole
    {
        public static void Main()
        {

            Console.WriteLine(77 % 5);
            return;
            List<string> obstacles = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int currendEnergy = int.Parse(Console.ReadLine());
            int currentIndex = 0;
            int lenght = obstacles.Count;
            bool lastBobm = false;

            do
            {
                lastBobm = false;
                string[] commandParams = obstacles[currentIndex]
                    .Split('|');

                string command = commandParams[0].ToLower();

                if (command == "rabbithole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    break;
                }
                int energy = int.Parse(commandParams[1]);

                switch (command)
                {
                    case "left":
                        currentIndex = Math.Abs(currendEnergy - energy) % lenght;
                        currendEnergy -= energy;
                        break;
                    case "right":
                        currentIndex = Math.Abs(currendEnergy + energy) % lenght;
                        currendEnergy -= energy;
                        break;
                    case "bomb":
                        currentIndex = 0;
                        currendEnergy -= energy;
                        lastBobm = true;
                        break;
                }

                if (obstacles[obstacles.Count - 1] != "RabbitHole")
                {
                    obstacles.RemoveAt(obstacles.Count - 1);
                }
                obstacles.Add("Bomb |" + currendEnergy);

            }
            while (currendEnergy > 0);

            if(currendEnergy <= 0 && lastBobm)
            {
                Console.WriteLine("You are dead due to bomb explosion!");
            }
            if (currendEnergy <= 0 && !lastBobm)
            {
                Console.WriteLine("You are tired. You can't continue the mission.");
            }

        }
    }
}
