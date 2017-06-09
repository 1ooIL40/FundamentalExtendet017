namespace _06.Increment_Variable
{
    using System;

    public class IncrementVariable
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var count = 0;

            if(num >= 256)
            {
                while (num >= 256)
                {
                    num -= 256;
                    count++;
                }
                Console.WriteLine($"{num}");
                Console.WriteLine($"Overflowed {count} times");
            }
            else
            {
                Console.WriteLine(num);
            }
        }
    }
}
