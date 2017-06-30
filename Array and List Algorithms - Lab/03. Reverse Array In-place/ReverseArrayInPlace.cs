namespace _03.Reverse_Array_In_place
{
    using System;
    using System.Linq;

    public class ReverseArrayInPlace
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
