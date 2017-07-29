namespace _07.Pyramidic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Pyramidic
    {
        public static void Main()
        {
            List<string> result = new List<string>();
            List<string> inputStrings = new List<string>();

            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                inputStrings.Add(Console.ReadLine());
            }

            for (int i = 0; i < inputStrings.Count; i++)
            {
                string currendString = inputStrings[i];

                for (int j = 0; j < currendString.Length; j++)
                {
                    char currentChar = currendString[j];
                    int layer = 1;
                    string currentPyramid = string.Empty;

                    for (int k = i; k < inputStrings.Count; k++)
                    {
                        string currentLayer = new string(currentChar, layer);

                        if (inputStrings[k].Contains(currentLayer))
                        {
                            currentPyramid += currentLayer + "\r\n";
                        }
                        else
                        {
                            break;
                        }

                        layer += 2;
                    }

                    result.Add(currentPyramid.Trim());
                }
            }
            Console.WriteLine(result.OrderByDescending(x => x.Length).First());
        }
    }
}
