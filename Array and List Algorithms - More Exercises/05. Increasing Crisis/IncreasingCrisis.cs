namespace _05.Increasing_Crisis
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IncreasingCrisis
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<int> crisis = Console.ReadLine()
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

            for (int i = 1; i < n; i++)
            {
                List<int> numbers = Console.ReadLine()
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();


                //int increasingSequenceChek = numbers[0];
                //int stopHere = 0;
                //for (int j = 0; j < numbers.Count - 1; j++)
                //{
                //    if(!(increasingSequenceChek < numbers[j + 1]))
                //    {
                //        stopHere = j;
                //    }
                //}


                //TODO
                int number = numbers[0];
                int indexToInsert = 0;
                bool isTrue = false;

                for (int j = 0; j < crisis.Count; j++)
                {
                    if(number < crisis[j])
                    {
                        isTrue = true;
                        indexToInsert = j;
                        break;
                    }
                }

                if (!isTrue)
                {
                    indexToInsert = crisis.Count();
                    isTrue = true;
                }


                if (isTrue)
                {
                    for (int insr = numbers.Count - 1; insr >= 0; insr--)
                    {
                        crisis.Insert(indexToInsert, numbers[insr]);
                    }
                }

                //TODO
                int lastCorrectIndexSequence = 0;
                for (int cnt = 0; cnt < crisis.Count - 1; cnt++)
                {
                    if(crisis[cnt] > crisis[cnt + 1])
                    {
                        lastCorrectIndexSequence = cnt;
                    }
                }

                if(lastCorrectIndexSequence > 0)
                {
                    crisis = crisis
                        .Take(lastCorrectIndexSequence + 1)
                        .ToList();
                }

            }

            Console.WriteLine(string.Join(" ", crisis));
        }
    }
}
