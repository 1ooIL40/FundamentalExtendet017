namespace _08.String_Encryption
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StringEncryption
    {
        public static void Main()
        {

            var n = int.Parse(Console.ReadLine());
            var otput = string.Empty;
            for (int i = 0; i < n; i++)
            {
                var characters = char.Parse(Console.ReadLine());
                var encryptChar = EncriptChar(characters, n);
                otput += encryptChar;
            }
            Console.WriteLine(otput);
        }

        static string EncriptChar(char characters, int n)
        {
            var result = string.Empty;
            var charInNumbers = (int)characters;
            var firstDigit = 0;
            var lastDigit = charInNumbers % 10;
            var firstEncryptedChar = (char)(characters + lastDigit);

            var count = 0;

            if (charInNumbers > 9 && charInNumbers < 100)
            {
                count = 2;
            }
            else
            {
                count = 3;
            }

            while (count > 1)
            {
                charInNumbers /= 10;
                firstDigit = charInNumbers;
                count--;
            }

            var lastEncryptedChar = (char)(characters - firstDigit);

            result = $"{firstEncryptedChar}{firstDigit}{lastDigit}{lastEncryptedChar}";

            return result;
        }
    }
}
