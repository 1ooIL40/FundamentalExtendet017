namespace _08.SMS_Typing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SMSTyping
    {
        public static void Main()
        {
            var numberOfCharacters = int.Parse(Console.ReadLine());

            var keyboardDictionery = new Dictionary<int, List<char>>();

            var smsMessage = string.Empty;

            keyboardDictionery[0] = new List<char> { ' ' };
            keyboardDictionery[1] = new List<char>();
            keyboardDictionery[2] = new List<char> { 'a', 'b', 'c' };
            keyboardDictionery[3] = new List<char> { 'd', 'e', 'f' };
            keyboardDictionery[4] = new List<char> { 'g', 'h', 'i' };
            keyboardDictionery[5] = new List<char> { 'j', 'k', 'l' };
            keyboardDictionery[6] = new List<char> { 'm', 'n', 'o' };
            keyboardDictionery[7] = new List<char> { 'p', 'q', 'r', 's' };
            keyboardDictionery[8] = new List<char> { 't', 'u', 'v' };
            keyboardDictionery[9] = new List<char> { 'w', 'x', 'y','z' };

            for (int i = 0; i < numberOfCharacters; i++)
            {
                var number = Console.ReadLine();
                var len = number.Length;
                var letterIndex = 0;
                int.TryParse(number[0].ToString(), out letterIndex);


                smsMessage += keyboardDictionery[letterIndex][len - 1];
            }

            Console.WriteLine(smsMessage);
        }
    }
}
