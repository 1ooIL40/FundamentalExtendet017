namespace _08.Sum_of_Odd_Numbers
{
    using System;

    public class SumOfOddNumbers
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int odd = 1; odd <= 1001; odd += 2)
            {
                if(odd % 2 == 1)
                {
                    Console.WriteLine(odd);
                    sum += odd;
                }
                number--;
                if(number == 0)
                {
                    break;
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
