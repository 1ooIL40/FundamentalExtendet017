namespace _06.Triples_of_Latin_Letters
{
    using System;

    public class TriplesOfLatinLetters
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());


            for (char first = 'a'; first < num + 'a'; first++)
            {
                for (char second = 'a'; second < num + 'a'; second++)
                {
                    for (char third = 'a'; third < num + 'a'; third++)
                    {
                        Console.WriteLine($"{first}{second}{third}");
                    }
                }
            }
        }
    }
}
