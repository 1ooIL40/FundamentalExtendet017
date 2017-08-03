namespace _02.Match_Phone_Number
{
    using System;
    using System.Text.RegularExpressions;
    using System.Linq;
    using System.Collections.Generic;

    public class MatchPhoneNumber
    {
        public static void Main()
        {
            Regex rightPhoneNumber = new Regex(@"\+359(-|\s)2\1\d{3}\1\d{4}\b");

            string phoneNumbers = Console.ReadLine();

            var numbers = rightPhoneNumber.Matches(phoneNumbers);

            List<string> result = new List<string>();

            foreach (Match number in numbers)
            {
                result.Add(number.Value.Trim());
            }

            Console.WriteLine(string.Join(", ",result));
        }
    }
}