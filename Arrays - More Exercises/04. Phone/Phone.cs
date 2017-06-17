namespace _04.Phone
{
    using System;
    using System.Linq;

    public class Phone
    {
        public static void Main()
        {
            var arrayOfNumbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var arrayOfNames = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var input = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (input[0] != "done")
            {
                if (input[0] == "call")
                {
                    Call(arrayOfNumbers, arrayOfNames, input[1]);
                }
                else if (input[0] == "message")
                {
                    Message(arrayOfNumbers, arrayOfNames, input[1]);
                }

                input = Console.ReadLine()
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }
        }

        static void Message(string[] arrayOfNumbers, string[] arrayOfNames, string element)
        {
            var len = arrayOfNumbers.Length;

            for (int i = 0; i < len; i++)
            {
                if (element == arrayOfNumbers[i])
                {
                    Console.WriteLine($"sending sms to {arrayOfNames[i]}...");
                    DifferenceOfDigit(arrayOfNumbers[i]);
                }
                else if (element == arrayOfNames[i])
                {
                    Console.WriteLine($"sending sms to {arrayOfNumbers[i]}...");
                    DifferenceOfDigit(arrayOfNumbers[i]);
                }
            }
        }

        static void DifferenceOfDigit(string digits)
        {
            var difference = 0;
            var number = digits.ToCharArray();

            foreach (var x in number)
            {
                if (x >= 48 && x <= 57)
                {
                    difference -= x - 48;
                }
            }

            if (Math.Abs(difference) % 2 == 0)
            {
                Console.WriteLine("meet me there");
            }
            else if (Math.Abs(difference) % 2 != 0)
            {
                Console.WriteLine("busy");
            }
        }

        static void Call(string[] arrayOfNumbers, string[] arrayOfNames, string element)
        {
            var len = arrayOfNumbers.Length;

            for (int i = 0; i < len; i++)
            {
                if (element == arrayOfNames[i])
                {
                    Console.WriteLine($"calling {arrayOfNumbers[i]}...");
                    SumOfDigit(arrayOfNumbers[i]);
                }
                else if (element == arrayOfNumbers[i])
                {
                    Console.WriteLine($"calling {arrayOfNames[i]}...");
                    SumOfDigit(arrayOfNumbers[i]);
                }
            }
        }

        static void SumOfDigit(string digits)
        {
            var number = digits.ToCharArray();
            var sum = 0;

            foreach (var x in number)
            {
                if (x >= 48 && x <= 57)
                {
                    sum += x - 48;
                }
            }

            if (sum % 2 == 0)
            {
                TimeSpan t = TimeSpan.FromSeconds(sum);
                var result = string.Format($"call ended. duration: {t.Minutes:D2}:{t.Seconds:D2}");
                Console.WriteLine(result);
            }
            else if (sum % 2 != 0)
            {
                Console.WriteLine("no answer");
            }
        }
    }
}
