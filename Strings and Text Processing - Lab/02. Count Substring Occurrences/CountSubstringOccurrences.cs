namespace _02.Count_Substring_Occurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            string textInput = Console.ReadLine().ToLower();
            string subString = Console.ReadLine().ToLower();

            int index = -1;
            int count = 0;

            while (true)
            {
                index = textInput.IndexOf(subString, index + 1);

                if (index < 0)
                {
                    break;
                }

                count++;
            }
            Console.WriteLine(count);
        }
    }
}
