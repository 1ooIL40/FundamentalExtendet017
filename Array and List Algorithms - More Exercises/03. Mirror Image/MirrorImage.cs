namespace _03.Mirror_Image
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MirrorImage
    {
        public static void Main()
        {
            List<string> collection = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string userInput = Console.ReadLine();

            while (userInput != "Print")
            {
                int number = int.Parse(userInput);


                LeftSideReverse(collection, number);
                RightSideReverse(collection, number);

                userInput = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", collection));
        }

        static void RightSideReverse(List<string> collection, int number)
        {
            int len = collection.Count - 1;

            if (number < len)
            {
                for (int i = number + 1; i <= len; i++)
                {
                    string temp = collection[len];
                    collection.RemoveAt(len);
                    collection.Insert(i, temp);

                }
            }
        }

        static void LeftSideReverse(List<string> collection, int number)
        {

            for (int i = 0; i < number; i++)
            {
                string temp = collection[number - 1];
                collection.RemoveAt(number-1);
                collection.Insert(i, temp);
            }
        }
    }
}
