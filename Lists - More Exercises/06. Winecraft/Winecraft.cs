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

            var n = int.Parse(Console.ReadLine());

            var isGrapesBiggerThenN = GrapesBiggerThenN(grapes, n);




            do
            {
                for (int i = 0; i < n; i++)
                {
                    grapes = Bloom(grapes);
                }

                grapes = KillGrapesLowerOrEqualThan(grapes, n);


                isGrapesBiggerThenN = GrapesBiggerThenN(grapes, n);

            }
            while (isGrapesBiggerThenN);

            grapes = grapes
                .Where(g => g > n)
                .ToList();

            Console.WriteLine(string.Join(" ", grapes));
        }

        static bool GrapesBiggerThenN(List<int> grapes, int n)
        {
            grapes = grapes
                .Where(g => g > n)
                .ToList();

            return grapes.Count() >= n;
        }

        static List<int> KillGrapesLowerOrEqualThan(List<int> grapes, int n)
        {
            for (int i = 0; i < grapes.Count; i++)
            {
                if(grapes[i] <= n)
                {
                    grapes[i] = 0;
                }
            }
            return grapes;
        }

        static List<int> Bloom(List<int> grapes)
        {

            //Increment the grapse
            for (int i = 0; i < grapes.Count; i++)
            {
                if (grapes[i] > 0)
                {
                    grapes[i]++;
                }
            }

            //If There have Greater grapse do logic
            for (int i = 0; i < grapes.Count; i++)
            {
                
                if (i > 0 && i < grapes.Count - 1)
                {
                    var first = grapes[i - 1];
                    var greater = grapes[i];
                    var second = grapes[i + 1];

                    var isThereGreaterGrapes = CheckForGreaterGrapes(first, greater, second);


                    if (isThereGreaterGrapes)
                    {
                        if (first == 0 && second > 0)
                        {
                            grapes[i]++;
                            grapes[i + 1] -= 2;
                        }
                        if (first > 0 && second == 0)
                        {
                            grapes[i]++;
                            grapes[i - 1] -= 2;
                        }
                        if (first > 0 && second > 0)
                        {
                            grapes[i - 1] -= 2;
                            grapes[i] += 2;
                            grapes[i + 1] -= 2;
                        }
                    }
                }
            }

            return grapes;

        }

        static bool CheckForGreaterGrapes(int firsr, int greater, int second)
        {
            return (firsr < greater && second < greater);
        }
    }
}
