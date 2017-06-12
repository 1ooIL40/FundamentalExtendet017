namespace _07.Greater_of_Two_Values
{
    using System;

    public class GreaterOfTwoValues
    {
        public static void Main()
        {
            var typeOfInput = Console.ReadLine();
            var first = Console.ReadLine();
            var second = Console.ReadLine();


            if(typeOfInput == "int")
            {
                var firstNum = int.Parse(first);
                var secondNum = int.Parse(second);
                GetMax(firstNum,secondNum);
            }
            else if (typeOfInput == "char")
            {
                var firstChar = char.Parse(first);
                var secondChar = char.Parse(second);
                GetMax(firstChar, secondChar);
            }
            else
            {
                GetMax(first, second);
            }
        }

        static void GetMax(int first, int second)
        {
            if (first > second)
            {
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine(second);
            }
        }

        static void GetMax(char first, char second)
        {
            if (first > second)
            {
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine(second);
            }
        }

        static void GetMax(string first, string second)
        {
            var comare = first.CompareTo(second);

            if (comare > 0)
            {
                Console.WriteLine(first);
            }
            else if (comare < 0)
            {
                Console.WriteLine(second);
            }
            else
            {
                Console.WriteLine(first);
            }
        }
    }
}
