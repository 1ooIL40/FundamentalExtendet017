namespace _04.Roli_The_Coder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class RoliTheCoder
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();
            Regex patterForMatches = new Regex(@"(?<id>\d+)\s(?<eventName>\#\w+).*$"); //pathern to chek if we have mathces

            while (inputLine != "Time for Code")
            {

                inputLine = Console.ReadLine();
            }
        }
    }
}
