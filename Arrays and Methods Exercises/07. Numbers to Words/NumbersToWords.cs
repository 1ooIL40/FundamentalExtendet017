namespace _07.Numbers_to_Words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NumbersToWords
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            EndResult(n);
        }

        static void EndResult(int n)
        {
            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number > 999)
                {
                    Console.WriteLine("too large");
                }
                else if (number < -999)
                {
                    Console.WriteLine("too small");
                }
                else
                {
                    var numberInLetterz = string.Empty;

                    if (number < 0)
                    {
                        numberInLetterz = Letterize(Math.Abs(number));
                        Console.WriteLine($"minus {numberInLetterz}");
                    }
                    else
                    {
                        numberInLetterz = Letterize(number);
                        Console.WriteLine(numberInLetterz);
                    }
                }
            }
        }

        static string Letterize(int number)
        {
            string[] ones = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] teens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            var result = string.Empty;
            var hundreds = 0;
            if (number > 99 && number < 1000)
            {
                if (number % 100 == 0)
                {
                    hundreds = number / 100;
                    result = $"{ones[hundreds]}-hundred";
                }
                else
                {
                    hundreds = number / 100;
                    var ten = number % 100;
                    var lastTwoDigits = 0;
                    if (ten > 0 && ten < 10)
                    {
                        lastTwoDigits = ten % 10;
                        result = $"{ones[hundreds]}-hundred and {ones[lastTwoDigits]}";
                    }
                    else if (ten > 9 && ten < 20)
                    {
                        lastTwoDigits = ten % 10;
                        result = $"{ones[hundreds]}-hundred and {teens[lastTwoDigits]}";
                    }
                    else if (ten >= 20 && ten < 100)
                    {
                        if (ten % 10 == 0)
                        {
                            lastTwoDigits = ten / 10;
                            result = $"{ones[hundreds]}-hundred and {tens[lastTwoDigits]}";
                        }
                        else
                        {
                            lastTwoDigits = ten / 10;
                            result = $"{ones[hundreds]}-hundred and {tens[lastTwoDigits]} {ones[hundreds]}";
                        }
                    }

                }
            }
            return result;
        }
    }
}
