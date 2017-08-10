namespace _05.SoftUni_Messages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Text;

    public class Program
    {
        public static List<int> numbers = new List<int>();
        public static StringBuilder message = new StringBuilder();

        public static void Main()
        {
            string inputLine = Console.ReadLine();
            Regex pattern = new Regex(@"^(?<first>\d+)(?<message>[a-zA-Z]+)(?<last>[^a-zA-Z\s]*\d+$)");

            while (inputLine != "Decrypt!")
            {
                int searchLenght = int.Parse(Console.ReadLine());


                var matches = pattern.Matches(inputLine);

                foreach (Match match in matches)
                {
                    //Take the word and befor and after the word values
                    string word = match.Groups["message"].Value;
                    string first = match.Groups["first"].Value;
                    string second = match.Groups["last"].Value;

                    //Add the integers we have to List<int> and the messeg to StringBuilder
                    if (word.Length == searchLenght)
                    {
                        GetIntegersValue(first);
                        GetIntegersValue(second);
                        message.Append(word);
                    }
                }

                StringBuilder verificationCode = new StringBuilder();

                //Decript the messages
                foreach (var number in numbers)
                {
                    if(number < message.Length)
                    {
                        verificationCode.Append(message[number]);
                    }
                }
                
                //Print the result if we have machet values
                if(verificationCode.Length > 0)
                {
                    Console.WriteLine($"{message.ToString()} = {verificationCode.ToString()}");
                }

                message.Clear();
                numbers.Clear();
                inputLine = Console.ReadLine();
            }
        }

        static void GetIntegersValue(string numString)
        {
            char[] checkForNumbers = numString.ToCharArray();

            for (int i = 0; i < checkForNumbers.Length; i++)
            {
                int number = 0;
                if(int.TryParse(checkForNumbers[i].ToString(),out number))
                {
                    numbers.Add(number);
                }
            }
        }
    }
}
