namespace _08.Nilapdromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Nilapdromes
    {
        public static void Main()
        {
            string nilapdromes = Console.ReadLine();

            while (nilapdromes != "end")
            {
                string border = string.Empty;
                string core = string.Empty;

                char lastChar = nilapdromes.Last();
                int subStringIndex = nilapdromes.Length - 1;
                string substringToChek = nilapdromes.Substring(0,subStringIndex);

                bool contain = substringToChek.Contains(lastChar);


                //TODO logic for donomonodono input
                if (contain)
                {
                    int index = substringToChek.IndexOf(lastChar);

                    border = nilapdromes.Substring(0, index + 1);

                    nilapdromes = nilapdromes.Replace(border, "#");

                    if(nilapdromes.Last() == '#' && nilapdromes.Length > 1) 
                    {
                        core = nilapdromes.Replace("#", "").Trim();
                    }

                }


                if(border != string.Empty && core != string.Empty)
                {
                    Console.WriteLine($"{core}{border}{core}");
                }


                nilapdromes = Console.ReadLine();
            }
        }
    }
}
