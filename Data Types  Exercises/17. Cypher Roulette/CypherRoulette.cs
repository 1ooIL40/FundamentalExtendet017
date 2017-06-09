namespace _17.CypherRoulette
{
    using System;

    public class CypherRoulette
    {
        public static void Main()
        {
            var  number = int.Parse(Console.ReadLine());

            var resultString = string.Empty;
            var previousString = string.Empty;
            var  position = 0;

            for (int i = 0; i < number; i++)
            {
                var currentString = Console.ReadLine();
                if (currentString == previousString)
                {
                    resultString = string.Empty;
                    if (currentString == "spin")
                    {
                        i--;
                    }
                }
                else
                {
                    if (currentString == "spin")
                    {
                        position++;
                        i--;
                    }
                    else
                    {
                        if (position % 2 == 0)
                        {
                            resultString += currentString;
                        }
                        else if (position % 2 != 0)
                        {
                            resultString = currentString + resultString;
                        }
                    }
                }
                previousString = currentString;
            }
            Console.WriteLine(resultString);
        }
    }
}