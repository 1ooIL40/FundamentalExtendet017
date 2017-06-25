namespace _04.Ununion_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UnunionLists
    {
        public static void Main()
        {
            var primalList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Distinct()
                .ToList();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                primalList = RemoveAllOccurrenses(primalList);

            }
            primalList.Sort();

            Console.WriteLine(string.Join(" ", primalList));
        }

        static List<int> RemoveAllOccurrenses(List<int> primalList)
        {
            var sequenceList = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToList();


            for (int p = 0; p < sequenceList.Count; p++)
            {
                if (primalList.Contains(sequenceList[p]))
                {
                    primalList.Remove(sequenceList[p]);
                }
                else
                {
                    primalList.Add(sequenceList[p]);
                }
            }

            return primalList;
        }
    }
}
