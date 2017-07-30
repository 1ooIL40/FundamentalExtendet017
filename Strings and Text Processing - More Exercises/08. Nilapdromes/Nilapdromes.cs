namespace _08.Nilapdromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Nilapdromes
    {

        public static void Main()
        {
            string nilapdromes = Console.ReadLine();

            while (nilapdromes != "end")
            {
                string startBorder = string.Empty;
                string endBorder = string.Empty;
                string core = string.Empty;

                int len = nilapdromes.Length;
                bool compare = false;

                int endBorderLenght = (len) - (len / 2);
                startBorder = nilapdromes.Substring(0, len / 2);
                if (len % 2 == 0)
                {
                    endBorder = nilapdromes.Substring(startBorder.Length, endBorderLenght);
                }
                else
                {
                    endBorderLenght = startBorder.Length;
                    endBorder = nilapdromes.Substring(startBorder.Length + 1, endBorderLenght);
                }
                compare = startBorder.Equals(endBorder);

                while (startBorder.Length > 0 && !compare)
                {
                    startBorder = NewStartBorder(startBorder);
                    endBorder = NewEndBorder(endBorder);

                    if (startBorder != "")
                    {
                        compare = startBorder.Equals(endBorder);
                    }
                }

                if (compare)
                {
                    core = Core(nilapdromes, startBorder);

                    if (core != "")
                    {
                        Console.WriteLine($"{core}{startBorder}{core}");
                    }
                }

                nilapdromes = Console.ReadLine();
            }
        }

        static string Core(string nilapdromes, string startBorder)
        {
            string result = string.Empty;
            int len = startBorder.Length;

            for (int i = len; i < nilapdromes.Length - len; i++)
            {
                result += nilapdromes[i];
            }

            return result;
        }

        static string NewStartBorder(string startBorder)
        {
            string result = string.Empty;

            for (int i = 0; i < startBorder.Length - 1; i++)
            {
                result += startBorder[i];
            }
            return result;
        }

        static string NewEndBorder(string endBorder)
        {
            string result = string.Empty;

            for (int i = 1; i <= endBorder.Length - 1; i++)
            {
                result += endBorder[i];
            }
            return result;
        }
    }
}
