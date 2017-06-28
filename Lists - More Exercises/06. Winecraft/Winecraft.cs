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
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var n = int.Parse(Console.ReadLine());

            var stopWinecraft = grapes;
            
            
            do
            {

                for (int i = 0; i < n; i++)
                {
                    //Add one grape for each i
                    addGrapes(grapes);

                    //Feed the  Greater grape
                    GrapeStealers(grapes);
                }

                //Set the grapes who ar less then rounds to 0
                SetLowerGrapesToZero(grapes, n);


                stopWinecraft = grapes
                    .Where(g => g > n)
                    .ToList();
            }
            while (stopWinecraft.Count >= n);

            //For final print
            grapes = grapes
                .Where(g => g > n)
                .ToList();

            Console.WriteLine(string.Join(" ", grapes));
        }

        //Decrement the neighbors of the greater grape
        static void GrapeStealers(List<int> grapes)
        {
            for (int i = 1; i < grapes.Count - 1; i++)
            {
                var neighborOne = grapes[i - 1];
                var greaterGrape = grapes[i];
                var neighborTwo = grapes[i + 1];

                bool isGreater = FindGreaterGrapse(neighborOne, greaterGrape, neighborTwo);

                if (isGreater)
                {
                    if (neighborOne > 0 && neighborTwo > 0)
                    {
                        grapes[i - 1] -= 1;
                        grapes[i + 1] -= 1;
                        grapes[i] += 2;
                    }
                    //Check if one of the neighbors are empty == 0
                    if (neighborOne > 0 && neighborTwo == 0) 
                    {
                        grapes[i - 1] -= 1;
                        grapes[i] += 1;
                    }
                    if (neighborOne == 0 && neighborTwo > 0)
                    {
                        grapes[i + 1] -= 1;
                        grapes[i] += 1;
                    }
                }
            }
        }

        //Make grapes lower or equal then rounds == 0
        static void SetLowerGrapesToZero(List<int> grapes, int rounds)
        {

            for (int i = 0; i < grapes.Count; i++)
            {
                if (grapes[i] <= rounds)
                {
                    grapes[i] = 0;
                }
            }
        }

        //LvlUp Grapes
        static void addGrapes(List<int> grapes)
        {
            List<int> lesserGrapeIndex = new List<int>();

            for (int i = 0; i < grapes.Count; i++)
            {

                if(i > 0 && i < grapes.Count - 1)
                {
                    int first = grapes[i - 1];
                    int greateGrapse = grapes[i];
                    int last = grapes[i + 1];

                    bool isGreater = FindGreaterGrapse(first, greateGrapse, last);

                    if (isGreater)
                    {
                        lesserGrapeIndex.Add(i - 1);
                        lesserGrapeIndex.Add(i + 1);
                    }
                }
            }

            //lesserGrapeIndex = lesserGrapeIndex
            //    .Distinct()
            //    .ToList();

            //Lvl Up grapes who are not lesser
            for (int i = 0; i < grapes.Count; i++)
            {
                for (int cnt = 0; cnt < lesserGrapeIndex.Count; cnt++)
                {
                    if(i == lesserGrapeIndex[cnt])
                    {
                        grapes[i]--;
                        break;
                    }
                }
                grapes[i]++;
            }
        }

        static bool FindGreaterGrapse(int first, int greateGrapse, int last)
        {
            return (first < greateGrapse && greateGrapse > last);
        }
    }
}
