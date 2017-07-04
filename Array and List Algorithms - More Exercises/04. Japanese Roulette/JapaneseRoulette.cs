namespace _04.Japanese_Roulette
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class JapaneseRoulette
    {

        public static void Main()
        {

            int[] cylinder = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[] players = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int playerStartPosition = 0;

            for (int i = 0; i < cylinder.Length; i++)
            {
                if (cylinder[i] == 1)
                {
                    playerStartPosition = i;
                }
            }

            int revolverButlletSpots = 6;
            bool isDead = false;
            int deadPlayer = 0;

            for (int i = 0; i < players.Length; i++)
            {
                string[] player = players[i]
                    .Split(new char[] { ',' })
                    .ToArray();

                string direction = player[1];
                int strenght = int.Parse(player[0]);
                int endPosition = 0;

                switch (direction)
                {
                    case "Right":
                        endPosition = (playerStartPosition + strenght) % revolverButlletSpots;
                        playerStartPosition = endPosition;
                        break;
                    case "Left":
                        endPosition = (playerStartPosition - strenght) % revolverButlletSpots;
                        if (endPosition < 0)
                        {
                            endPosition += revolverButlletSpots;
                        }
                        playerStartPosition = endPosition;
                        break;
                }

                if (endPosition == 2)
                {
                    deadPlayer = i;
                    isDead = true;
                    break;
                }

                playerStartPosition++;
            }

            if (isDead)
            {
                Console.WriteLine($"Game over! Player {deadPlayer} is dead.");
            }
            else
            {
                Console.WriteLine($"Everybody got lucky!");
            }

        }
    }
}
