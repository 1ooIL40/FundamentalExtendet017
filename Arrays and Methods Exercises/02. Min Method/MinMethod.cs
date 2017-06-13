namespace _02.Min_Method
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MinMethod
    {
        public static void Main()
        {
            var numOne = int.Parse(Console.ReadLine());
            var numTwo = int.Parse(Console.ReadLine());
            var numThree = int.Parse(Console.ReadLine());

            var result = GetMin(numThree, GetMin(numOne, numTwo));
            Console.WriteLine(result);
        }

        static int GetMin(int numOne, int numTwo)
        {
            if(numOne > numTwo)
            {
                return numTwo;
            }
            return numOne;
        }
    }
}
