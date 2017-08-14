namespace _02.Command_Interpreter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class CommandInterpreter
    {
        public static List<string> stringsToOperateWith = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

        public static void Main()
        {            

            string inpuLine = Console.ReadLine();

            while (inpuLine!= "end")
            {
                string[] tokens = inpuLine
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                string commands = tokens[0];
                bool canBeDone = false;
                int rollNumber = 0;

                switch (commands)
                {
                    case "reverse":
                        canBeDone = InvalidParams(tokens);
                        if (!canBeDone)
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        else
                        {
                            int start = int.Parse(tokens[2]);
                            int count = int.Parse(tokens[tokens.Length - 1]);
                            stringsToOperateWith.Reverse(start, count);
                        }

                        break;
                    case "sort":
                        canBeDone = InvalidParams(tokens);
                        if (!canBeDone)
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        else
                        {
                            int start = int.Parse(tokens[2]);
                            int count = int.Parse(tokens[tokens.Length - 1]);
                            stringsToOperateWith.Sort(start, count, StringComparer.InvariantCulture);
                        }
                        break;
                    case "rollLeft":
                        rollNumber = int.Parse(tokens[1]);
                        if (rollNumber >= 0)
                        {
                            int end = rollNumber % stringsToOperateWith.Count;
                            RollLeft(end);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;
                    case "rollRight":
                        rollNumber = int.Parse(tokens[1]);
                        if (rollNumber >= 0)
                        {
                            int end = rollNumber % stringsToOperateWith.Count;
                            RollRight(end);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                }

                inpuLine = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ",stringsToOperateWith)}]");
            //string debug = string.Empty;
        }

        //Roll to the right
        static void RollRight(int end)
        {
            for (int i = 0; i < end; i++)
            {
                string lastElement = stringsToOperateWith[stringsToOperateWith.Count - 1];
                stringsToOperateWith.RemoveAt(stringsToOperateWith.Count - 1);
                stringsToOperateWith.Insert(0, lastElement);
            }
        }

        //Roll to the left
        static void RollLeft(int end)
        {
            for (int i = 0; i < end; i++)
            {
                string firstElement = stringsToOperateWith[0];
                stringsToOperateWith.RemoveAt(0);
                stringsToOperateWith.Add(firstElement);
            }
        }

        //Check for valid input
        static bool InvalidParams(string[] tokens)
        {
            bool result = false;
            int start = int.Parse(tokens[2]);
            int count = int.Parse(tokens[tokens.Length - 1]);
            int len = stringsToOperateWith.Count;

            if (start >= 0 && start < len  && 
                count >= 0 && (start+count) <= len )
            {
                result = true;   
            }
            return result;
        }
    }
}
