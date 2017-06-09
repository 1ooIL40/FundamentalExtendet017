namespace _06.DNA_Sequences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DNASequences
    {
        public static void Main()
        {
            var sumMatch = int.Parse(Console.ReadLine());

            var letters = new List<string> { "A", "C", "G", "T" };
            var dnaOutput = string.Empty;
            var count = 0;
            var sum = 0;

            for (int first = 0; first < letters.Count; first++)
            {
                for (int second = 0; second < letters.Count; second++)
                {
                    for (int third = 0; third < letters.Count; third++)
                    {

                        dnaOutput = $"{letters[first]}{letters[second]}{letters[third]}";

                        sum = (first + 1) + (second + 1) + (third + 1);

                        if (sumMatch <= sum)
                        {
                            Console.Write($"O{dnaOutput}O ");
                        }
                        else
                        {
                            Console.Write($"X{dnaOutput}X ");
                        }
                        
                        count++;

                        if (count % 4 == 0)
                        {
                            count = 0;
                            Console.WriteLine();
                        }
                    }
                }
            }

        }
    }
}
