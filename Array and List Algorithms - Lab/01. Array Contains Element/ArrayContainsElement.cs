namespace _01.Array_Contains_Element
{
    using System;
    using System.Linq;

    public class ArrayContainsElement
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            string asnwer = "no";

            foreach (var number in numbers)
            {
                if(number == n)
                {
                    asnwer = "yes";
                    break;
                }
            }
            Console.WriteLine(asnwer);
        }
    }
}
