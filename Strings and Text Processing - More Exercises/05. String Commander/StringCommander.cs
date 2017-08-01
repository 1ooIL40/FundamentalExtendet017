namespace _05.String_Commander
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StringCommander
    {
        public static StringBuilder stringToManipulate = new StringBuilder(Console.ReadLine());

        public static void Main()
        {
            
            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] tokens = inputLine
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                int times = 0;

                string command = tokens[0];

                switch (command)
                {
                    case "Left":
                        times = int.Parse(tokens[1]);
                        MoveToTheLeft(times);
                        break;
                    case "Right":
                        times = int.Parse(tokens[1]);
                        MoveToTheRight(times);
                        break;
                    case "Insert":
                        int index = int.Parse(tokens[1]);
                        string stringToInsert = tokens[2];
                        InsertString(index, stringToInsert);
                        break;
                    case "Delete":
                        int startIndex = int.Parse(tokens[1]);
                        int endIndex = int.Parse(tokens[2]);
                        DeleteFromTo(startIndex, endIndex);
                        break;
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine(stringToManipulate.ToString());
        }

        private static void DeleteFromTo(int start, int end)
        {
            stringToManipulate.Remove(start, end + 1);
        }

        private static void InsertString(int index, string stringToInsert)
        {
            stringToManipulate.Insert(index, stringToInsert);
        }

        static void MoveToTheRight(int times)
        {
            while (times > 0)
            {
                int indexToRemove = stringToManipulate.Length;
                char lastElement = stringToManipulate[stringToManipulate.Length - 1];
                stringToManipulate.Remove(indexToRemove - 1, 1);
                stringToManipulate.Insert(0, lastElement);
                times--;
            }
        }

        static void MoveToTheLeft(int times)
        {
            while (times > 0)
            {
                char lastElement = stringToManipulate[0];
                stringToManipulate.Remove(0, 1);
                stringToManipulate.Append(lastElement);
                times--;
            }
        }
    }
}
