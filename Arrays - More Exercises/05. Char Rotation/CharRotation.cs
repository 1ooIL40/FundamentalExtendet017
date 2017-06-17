namespace _05.Char_Rotation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CharRotation
    {
        public static void Main()
        {
            var chars = Console.ReadLine()
                .ToCharArray();

            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var result = string.Empty;

            for (int i = 0; i < numbers.Length; i++)
            {

                if(numbers[i] % 2 != 0)
                {
                    result += (char)(numbers[i] + chars[i]);
                }
                else
                {
                    result += (char)(chars[i] - numbers[i]);
                }
            }

            Console.WriteLine(result);
        }
    }
}
