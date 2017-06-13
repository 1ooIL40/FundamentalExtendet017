namespace _16.Array_Symmetry
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArraySymmetry
    {
        public static void Main()
        {
            var text = Console.ReadLine()
               .Split(new char[] { ' ' },
               StringSplitOptions.RemoveEmptyEntries)
               .ToArray();

            var len = text.Length / 2;
            var answer = "Yes";

            for (int i = 0; i < len; i++)
            {
                var first = text[i];
                var second = text[text.Length - 1 - i];

                if(first != second)
                {
                    answer = "No";
                    break;
                }
            }
            Console.WriteLine(answer);
        }
    }
}
