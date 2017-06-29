﻿namespace _06.Winecraft
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

            for (int i = 1; i < grapes.Length - 1; i++)
            {

                int first = grapes[i - 1];
                int greatGrape = grapes[i];
                int last = grapes[i + 1];

                bool isGreater = GreateGrape(first, greatGrape, last);


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
            for (int i = 1; i < grapes.Length - 1; i++)
            {
                int first = grapes[i - 1];
                int greater = grapes[i];
                int last = grapes[i + 1];

                bool isGreater = GreateGrape(first, greater, last);

                int lvlUpGreaterGrape = 0;

                if (isGreater)
                {
                    if (first > 0 && last <= 0)
                    {
                        grapes[i - 1]--;
                        lvlUpGreaterGrape++;
                    }
                    if (first <= 0 && last > 0)
                    {
                        grapes[i + 1]--;
                        lvlUpGreaterGrape++;
                    }
                    if (first > 0 && last > 0)
                    {
                        grapes[i - 1]--;
                        grapes[i + 1]--;
                        lvlUpGreaterGrape += 2;
                    }

                    grapes[i] += lvlUpGreaterGrape;

                }
            }
        }

        //Add 1 lvl to the grapes who are differend then lesser
        static void LvlUpGrapesDifferendThenLessarGrape(int[] grapes,
            HashSet<int> lesserGrapesIndexes)
        {
            for (int i = 0; i < grapes.Length - 1; i++)
            {
                foreach (var index in lesserGrapesIndexes)
                {
                    if (index == i)
                    {
                        i++;
                    }
                }

                if (grapes[i] > 0)
                {
                    grapes[i]++;
                }
            }
        }

        //Check for Greater Grapes
        static bool GreateGrape(int first, int great, int last)
        {

            return (first < great && great > last);
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