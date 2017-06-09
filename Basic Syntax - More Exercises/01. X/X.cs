namespace _01.X
{
    using System;

    public class X
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var space = ' ';
            var symbol = "x";

            var parts = (n - 1) / 2;

            for (int top = 0; top < parts; top++)
            {
                var midEmpty = 2 * top + 2;

                Console.Write(new string(space, top));
                Console.Write(symbol);
                Console.Write(new string(space,  (n - midEmpty) ));
                Console.Write(symbol);
                Console.WriteLine(new string(space, top));
            }

            Console.Write(new string(space, parts));
            Console.Write(symbol);
            Console.WriteLine(new string(space, parts));


            for (int bottom = parts; bottom > 0; bottom--)
            {
                var midEmpty = 2 * bottom;

                Console.Write(new string(space, bottom - 1));
                Console.Write(symbol);
                Console.Write(new string(space, (n - midEmpty)));
                Console.Write(symbol);
                Console.WriteLine(new string(space, bottom - 1));

            }
        }
    }
}
