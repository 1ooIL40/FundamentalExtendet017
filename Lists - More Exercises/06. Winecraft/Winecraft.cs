namespace _06.Winecraft
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Winecraft
    {
        public static void Main()
        {
            var grapes = Console.ReadLine()
                .Split(" ".ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var rounds = int.Parse(Console.ReadLine());

            var stopWinecraft = grapes;


            while (stopWinecraft.Count >= rounds)
            {

                for (int i = 0; i < rounds; i++)
                {
                    //Add one grape for each i
                    grapes = addGrapes(grapes);

                    //Feed the  Greater grape
                    grapes = GrapeStealers(grapes);
                }

                //Set the grapes who ar less then rounds to 0
                grapes = SetLowerGrapesToZero(grapes, rounds);


                stopWinecraft = grapes
                    .Where(g => g > rounds)
                    .ToList();
            }
            //For final print
            grapes = grapes
                .Where(g => g > rounds)
                .ToList();

            Console.WriteLine(string.Join(" ", grapes));
        }

        static List<int> GrapeStealers(List<int> grapes)
        {
            for (int i = 1; i < grapes.Count - 1; i++)
            {
                var neighborOne = grapes[i - 1];
                var greaterGrape = grapes[i];
                var neighborTwo = grapes[i + 1];

                if(greaterGrape > neighborOne && 
                    greaterGrape > neighborTwo)
                {
                    if (neighborOne > 0 && neighborTwo > 0) //Chek did we have Greater grape
                    {
                        grapes[i - 1] -= 2;
                        grapes[i + 1] -= 2;
                        grapes[i] += 2;
                    }else if (neighborOne > 0 && neighborTwo == 0) //Check if one of the neighbors are empty == 0
                    {
                        grapes[i - 1] -= 2;
                        grapes[i] += 1;
                    }
                    else
                    {
                        grapes[i + 1] -= 2;
                        grapes[i] += 1;
                    }
                }
            }
            
            return grapes;
        }

        static List<int> SetLowerGrapesToZero(List<int> grapes, int rounds)
        {

            for (int i = 0; i < grapes.Count; i++)
            {
                if(grapes[i] <= rounds)
                {
                    grapes[i] = 0;
                }
            }

            return grapes;
        }

        static List<int> addGrapes(List<int> grapes)
        {
            for (int i = 0; i < grapes.Count; i++)
            {
                if (grapes[i] > 0)
                {
                    grapes[i] += 1;
                }
            }
            return grapes;
        }
    }
}
