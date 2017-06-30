namespace _01.Shoot_List_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShootListElements
    {
        public static void Main()
        {
            string userInput = Console.ReadLine();
            List<int> shootingListElements = new List<int>();
            int lastShotedElement = 0;

            while (userInput != "stop")
            {
                int number;
                bool isInteger = int.TryParse(userInput, out number);

                if (isInteger)
                {
                    shootingListElements.Insert(0, number);
                }

                if (userInput == "bang")
                {
                    if(shootingListElements.Count <= 0)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {lastShotedElement}");
                        return;
                    }

                    if (shootingListElements.Count > 0)
                    {
                        double average = shootingListElements.Average();

                        for (int i = 0; i <= shootingListElements.Count - 1; i++)
                        {
                            if (shootingListElements[i] <= average)
                            {
                                lastShotedElement = shootingListElements[i];
                                Console.WriteLine($"shot {lastShotedElement}");
                                shootingListElements.RemoveAt(i);
                                break;
                            }
                        }

                        for (int i = 0; i < shootingListElements.Count; i++)
                        {
                            shootingListElements[i]--;
                        }
                    }
                    
                }
                userInput = Console.ReadLine();
            }

            if (shootingListElements.Count > 0)
            {
                Console.WriteLine($"survivors: {string.Join(" ", shootingListElements)}");
            }
            else
            {
                Console.WriteLine($"you shot them all. last one was {lastShotedElement}");
            }
        }
    }
}
