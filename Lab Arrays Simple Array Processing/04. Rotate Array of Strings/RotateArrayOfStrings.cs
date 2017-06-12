namespace _04.Rotate_Array_of_Strings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RotateArrayOfStrings
    {
        public static void Main()
        {
            var rotateString = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();


            Console.Write(rotateString[rotateString.Length - 1]);
            for (int i = 0; i <= rotateString.Length - 2; i++)
            {
                Console.Write($" {rotateString[i]}");
            }
            Console.WriteLine();
        }
    }
}