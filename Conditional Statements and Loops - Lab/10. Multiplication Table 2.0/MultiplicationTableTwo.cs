namespace _10.Multiplication_Table_2._0
{
    using System;

    public class MultiplicationTableTwo
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var multiplaier = int.Parse(Console.ReadLine());

            if (multiplaier > 10)
            {
                Console.WriteLine($"{number} X {multiplaier} = {number * multiplaier}");
            }

            for (int multip = multiplaier; multip <= 10 ; multip++)
            {
                Console.WriteLine($"{number} X {multip} = {number * multip}");

            }
        }
    }
}
