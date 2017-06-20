namespace _06.Stuck_Zipper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StuckZipper
    {
        public static void Main()
        {
            

            var inputListOne = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var inputListTwo = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var smallestDigit = LenghtToCompare(inputListOne, inputListTwo);

            var result = ListCompareAndZip(inputListOne, inputListTwo, smallestDigit);

            Console.WriteLine(string.Join(" ", result));
        }

        static List<int> ListCompareAndZip(List<int> inputListOne, List<int> inputListTwo, int smallestDigit)
        {
            var firstList = new List<int>();
            var secondList = new List<int>();
            var resultList = new List<int>();

            //add the numbers with smallest lenght to new list
            foreach (var number in inputListOne)
            {
                var stringNumber = Math.Abs(number).ToString();

                if (stringNumber.Length == smallestDigit)
                {
                    firstList.Add(number);
                }
            }

            //add the numbers with smallest lenght to new list
            foreach (var number in inputListTwo)
            {
                var stringNumber = Math.Abs(number).ToString();

                if (stringNumber.Length == smallestDigit)
                {
                    secondList.Add(number);
                }
            }

            var len = firstList.Count + secondList.Count;

            //create the result output list
            for (int i = 0; i < len; i++)
            {
                var firstListNumber = 0;
                var secondListNumber = 0;

                if (secondList.Count > i)
                {
                    secondListNumber = secondList[i];
                    resultList.Add(secondListNumber);
                }
                if (firstList.Count > i)
                {
                    firstListNumber = firstList[i];
                    resultList.Add(firstListNumber);
                }
            }


            return resultList;
        }

        static int LenghtToCompare(List<int> inputListOne, List<int> inputListTwo)
        {
            var digit = int.MaxValue;

            //Get the smallest lenght on a digits from the two lists
            foreach (var number in inputListOne)
            {
                var stringNumber = Math.Abs(number).ToString();

                if (stringNumber.Length < digit)
                {
                    digit = stringNumber.Length;
                }
            }
            foreach (var number in inputListTwo)
            {
                var stringNumber = Math.Abs(number).ToString();

                if (stringNumber.Length < digit)
                {
                    digit = stringNumber.Length;
                }
            }

            return digit;
        }
    }
}
