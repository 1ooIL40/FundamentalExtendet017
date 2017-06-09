namespace _05.Special_Numbers
{
    using System;

    public class SpecialNumbers
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());


            for (int i = 1; i <= num; i++)
            {
                var sum = 0;
                var currentNumber = i;
                while (currentNumber > 0)
                {
                    sum += currentNumber % 10;
                    currentNumber /= 10;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
