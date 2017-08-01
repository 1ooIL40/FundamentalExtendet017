namespace _02.Diamond_Problem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class DiamondProblem
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine().Trim();

            char diamondStart = '<';
            char diamondEnd = '>';


            int start = inputLine.IndexOf(diamondStart);
            int end = inputLine.LastIndexOf(diamondEnd);

            if (inputLine.Contains(diamondStart) &&
                inputLine.Contains(diamondEnd) &&
                start < end)
            {

                List<string> diamonds = FindTheDimondsInTheString(inputLine, diamondStart, diamondEnd);
                List<int> foundDiamondsCarate = new List<int>();


                foreach (var diamond in diamonds)
                {
                    int diamondCarate = 0;
                    char[] diam = diamond.ToCharArray();

                    for (int i = 0; i < diam.Length; i++)
                    {
                        int number = 0;
                        int.TryParse(diam[i].ToString(), out number);

                        if (number < 10)
                        {
                            diamondCarate += number;
                        }
                    }
                    foundDiamondsCarate.Add(diamondCarate);
                }

                foreach (var diamond in foundDiamondsCarate)
                {
                    Console.WriteLine($"Found {diamond} carat diamond");
                }
            }
            else
            {
                Console.WriteLine($"Better luck next time");
            }

        }

        static List<string> FindTheDimondsInTheString(string inputLine, char startWith, char endWith)
        {
            List<string> result = new List<string>();

            int start = inputLine.IndexOf(startWith);
            int end = inputLine.LastIndexOf(endWith);
            inputLine = inputLine.Substring(start, (end - start + 1));

            string[] tokes = inputLine
                .Split(new char[] { startWith },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (var d in tokes)
            {
                if (d.Contains(endWith))
                {
                    string diamond = d.Replace(endWith, ' ');
                    result.Add(diamond.Trim());
                }
            }


            return result;
        }
    }
}