namespace _06.Rectangle_Position
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RectanglePosition
    {
        public static void Main()
        {
            var firstRectangle = ReadRectangle();
            var secondRectangle = ReadRectangle();

            var isInside = firstRectangle.IsInsied(secondRectangle);

            Console.WriteLine(isInside ? "Inside" : "Not inside");

        }

        static Rectangle ReadRectangle()
        {
            var inputLIne = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var rectangle = new Rectangle
            {
                Left = inputLIne[0],
                Top = inputLIne[1],
                Width = inputLIne[2],
                Height = inputLIne[3]
            };

            return rectangle;
        }
    }
    public class Rectangle
    {
        public int Left { get; set; }

        public int Top { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int CalcArea()
        {
            return Width * Height;
        }

        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }



        public int Right
        {
            get
            {
                return Left + Width;
            }
        }

        public bool IsInsied(Rectangle rectangle)
        {
            var leftIsValide = rectangle.Left <= Left;
            var topIsValide = rectangle.Top <= Top;
            var rightIsValide = rectangle.Right >= Right;
            var bottomIsValide = rectangle.Bottom >= Bottom;

            return leftIsValide &&
                topIsValide &&
                rightIsValide &&
                bottomIsValide;

        }
    }
}
