namespace _06.Math_Power
{
    using System;

    public class MathPower
    {
        public static void Main()
        {
            var number = double.Parse(Console.ReadLine());
            var power = double.Parse(Console.ReadLine());

            var poweredNumber = PowerTheNumber(number, power);

            Console.WriteLine(poweredNumber);
        }

        static double PowerTheNumber(double number, double power)
        {
            var result = 1d;

            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
