namespace _03.Sort_Array_of_Strings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortArrayOfStrings
    {
        public static void Main()
        {
            string[] randomWords = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            BubleSort(randomWords);

            Console.WriteLine(string.Join(" ", randomWords));
        }

        static void BubleSort(string[] randomWords)
        {
            bool swaped;
            do
            {
                swaped = false;
                for (int i = 1; i < randomWords.Length; i++)
                {
                    string first = randomWords[i - 1];
                    string second = randomWords[i];

                    int index = 0;

                    index = first.CompareTo(second);


                    if (index > 0)
                    {
                        Swap(i, randomWords);
                        swaped = true;
                    }
                    
                }
            }
            while (swaped);
        }

        static void Swap(int i, string[] randomWords)
        {
            string temp = randomWords[i - 1];
            randomWords[i - 1] = randomWords[i];
            randomWords[i] = temp;
        }
    }
}
