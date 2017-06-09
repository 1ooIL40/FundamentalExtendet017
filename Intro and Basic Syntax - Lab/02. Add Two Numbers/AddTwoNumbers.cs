namespace _02.Add_Two_Numbers
{
    using System;

    public class AddTwoNumbers
    {
        public static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var sum = a + b;

            Console.WriteLine($"{a} + {b} = {sum}");
        }
    }
}
