namespace _04.Transport
{
    using System;

    public class Transport
    {
        public static void Main()
        {
            var peoples = int.Parse(Console.ReadLine());

            if (peoples % 24 == 0)
            {
                Console.WriteLine(peoples / 24);
            }
            else
            {
                Console.WriteLine((peoples / 24) + 1);
            }
        }
    }
}
