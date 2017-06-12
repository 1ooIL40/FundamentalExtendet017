namespace _02.Sign_of_Integer_Number
{
    using System;

    public class SignOfIntegerNumber
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            PrintSign(number);
        }

        static void PrintSign(int number)
        {
            if (number > 0)
            {
                Positive(number);
            }
            else if (number < 0)
            {
                Negative(number);
            }
            else
            {
                NumberIsZero();
            }
        }

        static void NumberIsZero()
        {
            Console.WriteLine($"The number 0 is zero.");
        }
        
        private static void Negative(int n)
        {
            Console.WriteLine($"The number {n} is negative.");
        }

        static void Positive(int n)
        {
            Console.WriteLine($"The number {n} is positive.");
        }
    }
}
