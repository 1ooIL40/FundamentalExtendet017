namespace _09.Refactor_Special_Numbers
{
    using System;

    public class RefactorSpecialNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int num = 1; num <= n; num++)
            {
                bool result = false;
                var curentNumber = num;
                var sum = 0;
                while (num > 0)
                {
                    sum += num % 10;
                    num = num / 10;
                }
                result = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{curentNumber} -> {result}");
                sum = 0;
                num = curentNumber;
            }
        }
    }
}
