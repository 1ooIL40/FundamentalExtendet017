namespace _02.Ladybugs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Ladybugs
    {
        public static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());
            List<int> ladies = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string commnads = Console.ReadLine();

            int[] ladiesOnFields = new int[fieldSize];

            foreach (var lady in ladies)
            {
                if (lady >= 0 && lady < ladiesOnFields.Length)
                {
                    ladiesOnFields[lady] = 1;
                }
            }

            while (commnads != "end")
            {
                string[] tokens = commnads
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                int ladyBugIndex = int.Parse(tokens[0]);
                string direction = tokens[1];
                int flyLenght = int.Parse(tokens[2]);

                if (ladyBugIndex >= 0 && ladyBugIndex < ladiesOnFields.Length)
                {
                    if (flyLenght < 0 && direction == "left")
                    {
                        direction = "right";
                        flyLenght = Math.Abs(flyLenght);
                    }
                    if (flyLenght < 0 && direction == "right")
                    {
                        direction = "left";
                        flyLenght = Math.Abs(flyLenght);
                    }



                    switch (direction)
                    {
                        case "right":
                            if (ladyBugIndex + flyLenght > ladiesOnFields.Length - 1)
                            {
                                ladiesOnFields[ladyBugIndex] = 0;
                            }
                            else
                            {
                                if (ladiesOnFields[ladyBugIndex] == 1)
                                {
                                    for (int i = ladyBugIndex; i < ladiesOnFields.Length; i += flyLenght)
                                    {
                                        if (ladiesOnFields[i] == 0)
                                        {
                                            ladiesOnFields[i] = 1;
                                            break;
                                        }
                                        else
                                        {
                                            ladiesOnFields[ladyBugIndex] = 0;
                                            continue;
                                        }
                                    }
                                }
                            }
                            break;
                        case "left":
                            if (ladyBugIndex - flyLenght < 0)
                            {
                                ladiesOnFields[ladyBugIndex] = 0;
                            }
                            else
                            {
                                if (ladiesOnFields[ladyBugIndex] == 1)
                                {
                                    for (int i = ladyBugIndex; i >= 0; i -= flyLenght)
                                    {
                                        if (ladiesOnFields[i] == 0)
                                        {
                                            ladiesOnFields[i] = 1;
                                            break;
                                        }
                                        else
                                        {
                                            ladiesOnFields[ladyBugIndex] = 0;
                                            continue;
                                        }
                                    }
                                }
                            }
                            break;
                    }
                }
                commnads = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ",ladiesOnFields));
        }
    }
}
