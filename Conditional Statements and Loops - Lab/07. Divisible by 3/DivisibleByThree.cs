namespace _07.Divisible_by_3
{
    using System;

    public class DivisibleByThree
    {
        public static void Main()
        {
            for (int num = 3; num <= 100; num +=3)
            {
                if (num % 3 == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}

