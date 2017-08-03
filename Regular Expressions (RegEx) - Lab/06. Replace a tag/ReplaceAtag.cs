
namespace _06.Replace_a_tag
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class ReplaceAtag
    {
        public static void Main()
        {
            List<string> result = new List<string>();
            string inputLine = Console.ReadLine();


            while (inputLine != "end")
            {
                string pattern = "<a\\s*?href=\"(.+?)\">(\\w+)<\\/\\w>";
                string replace = "[URL href=\"$1\"]$2[/URL]";
                string resultMaches = Regex.Replace(inputLine, pattern, replace);

                result.Add(resultMaches);

                inputLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
