namespace _05.Foreign_Languages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ForeignLanguages
    {
        public static void Main()
        {
            var country = Console.ReadLine();

            if(country == "USA" || country == "England")
            {
                Console.WriteLine("English");
            }
            else if (country == "Spain" || country == "Mexico" || country == "Argentina")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
