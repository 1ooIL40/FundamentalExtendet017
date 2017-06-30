namespace _06.Winecraft
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Winecraft
    {
        static void Main()
        {

            int[] grapes = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            int grapesCounter = 0;


            do
            {
                //Grouwing days
                for (int i = 0; i < n; i++)
                {
                    GrapesLvlChange(grapes);
                }

                KillGrapesLowerOrEqualTo(n, grapes);

                grapesCounter = grapes
                    .Where(g => g > n)
                    .ToArray()
                    .Length;

            }
            while (grapesCounter >= n);

            grapes = grapes
                .Where(g => g > n)
                .ToArray();

            Console.WriteLine(string.Join(" ", grapes));

        }


        //Add or remove a lvl from grapes deppend of the grape Type
        static void GrapesLvlChange(int[] grapes)
        {
            HashSet<int> lesserGrapesIndexes = new HashSet<int>();

            for (int i = 0; i < grapes.Length; i++)
            {

                //int first = grapes[i - 1];
                //int greatGrape = grapes[i];
                //int last = grapes[i + 1];

                bool isGreater = GreateGrape(i, grapes);


                if (isGreater)
                {
                    lesserGrapesIndexes.Add(i - 1);
                    lesserGrapesIndexes.Add(i + 1);
                }
            }
            StealGrapeFromLesserGrapes(grapes);

            LvlUpGrapesDifferendThenLessarGrape(grapes, lesserGrapesIndexes);

        }

        //Steal 1 lvl from lesser grapes
        private static void StealGrapeFromLesserGrapes(int[] grapes)
        {
            for (int i = 0; i < grapes.Length; i++)
            {
                //int first = grapes[i - 1];
                //int greater = grapes[i];
                //int last = grapes[i + 1];

                bool isGreater = GreateGrape(i, grapes);

                //int lvlUpGreaterGrape = 0;

                if (isGreater)
                {
                    int first = grapes[i - 1];
                    int greater = grapes[i];
                    int last = grapes[i + 1];
                    //if (first > 0 && last <= 0)
                    //{
                    //    grapes[i - 1]--;
                    //    lvlUpGreaterGrape++;
                    //}
                    //if (first <= 0 && last > 0)
                    //{
                    //    grapes[i + 1]--;
                    //    lvlUpGreaterGrape++;
                    //}
                    //if (first > 0 && last > 0)
                    //{
                    //    grapes[i - 1]--;
                    //    grapes[i + 1]--;
                    //    lvlUpGreaterGrape += 2;
                    //}

                    //grapes[i] += lvlUpGreaterGrape;
                    //

                    // ---тук намаля слабите и присвоява стоиностите им на големите
                    if (first > 0)
                    {
                        grapes[i - 1]--;
                        grapes[i]++;
                    }
                    if (last > 0)
                    {
                        grapes[i + 1]--;
                        grapes[i]++;
                    }
                }
            }
        }

        //Add 1 lvl to the grapes who are differend then lesser
        static void LvlUpGrapesDifferendThenLessarGrape(int[] grapes,
            HashSet<int> lesserGrapesIndexes)
        {
            for (int i = 0; i < grapes.Length; i++)
            {
                //foreach (var index in lesserGrapesIndexes)
                //{
                //    if (index == i)
                //    {
                //        i++;
                //    }
                //}

                // ---увеличаваш всички които не са слаби!---
                if (grapes[i] > 0 && !lesserGrapesIndexes.Contains(i))
                {
                    grapes[i]++;
                }
            }
        }

        //Check for Greater Grapes
        static bool GreateGrape(int index, int[] grapes)
        {
            // ---метода проверява дали грозда от индекса може да е по-голям---
            // ---и след това дали наистина е по-голям
            // ---така циклите могат да си обикалят по целия масив
            if (index > 0 && index < grapes.Length - 1)
            {
                return grapes[index - 1] < grapes[index] && grapes[index + 1] < grapes[index];
            }
            return false;

        }

        //Set lower then N grapes to 0
        static void KillGrapesLowerOrEqualTo(int n, int[] grapes)
        {

            for (int i = 0; i < grapes.Length; i++)
            {
                if (grapes[i] < n)
                {
                    grapes[i] = 0;
                }
            }
        }
    }
}
