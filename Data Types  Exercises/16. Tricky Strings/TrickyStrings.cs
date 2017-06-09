namespace _16.Tricky_Strings
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class TrickyStrings
    {
        public static void Main()
        {
            var separator = Console.ReadLine();
            var number = int.Parse(Console.ReadLine());

            var stringList = new List<string>();

            for (int i = 0; i < number; i++)
            {
                var words = Console.ReadLine();
                stringList.Add(words);
            }

            Console.WriteLine(string.Join(separator,stringList));
        }
    }
}
