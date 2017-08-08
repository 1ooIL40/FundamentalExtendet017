namespace _02.Word_Encounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class WordEncounter
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            char letter = char.Parse(inputLine.Substring(0, 1));
            int digit = int.Parse(inputLine.Substring(1, 1));

            string text = Console.ReadLine();
            List<string> result = new List<string>();

            Regex validSentence = new Regex(@"^[A-Z].+(?:[\.\?\!])$");
            Regex words = new Regex(@"\w+");


            while (text != "end")
            {

                if (validSentence.IsMatch(text))
                {
                    var wordsNeeded = words.Matches(text);

                    foreach (Match word in wordsNeeded)
                    {
                        var check = word.Value.ToCharArray();
                        var count = 0;

                        for (int i = 0; i < check.Length; i++)
                        {
                            if(check[i] == letter)
                            {
                                count++;
                            }
                        }

                        if(count >= digit)
                        {
                            result.Add(word.Value);
                        }
                    }

                }
                
                text = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
