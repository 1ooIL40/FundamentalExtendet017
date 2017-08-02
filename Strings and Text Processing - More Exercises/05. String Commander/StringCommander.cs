
 //80/100 Грешка при изпълнението
 //100/100 rewrited and fixed

namespace _05.String_Commander
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StringCommander
    {
        public static string stringToManipulate = Console.ReadLine();

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

            Console.WriteLine(stringToManipulate);
        }

        static void DeleteFromTo(int start, int end)
        {
            stringToManipulate = stringToManipulate.Remove(start, end - start + 1);

        }

        static void InsertString(int index, string stringToInsert)
        {
            stringToManipulate = stringToManipulate.Insert(index, stringToInsert);
        }

        static void MoveToTheRight(int times)
        {
            times %= stringToManipulate.Length;
            stringToManipulate = stringToManipulate
                           .Substring(stringToManipulate.Length - times) + stringToManipulate.Substring(0, stringToManipulate.Length - times);
        }

        static void MoveToTheLeft(int times)
        {
            times %= stringToManipulate.Length;
            stringToManipulate = stringToManipulate
                .Substring(times) + stringToManipulate.Substring(0, times);
        }
    }
}