namespace _05.Boxes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Boxes
    {
        public static void Main()
        {
            List<Box> boxes = new List<Box>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokes = input
                .Split(" :|".ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries);

                Point upperLeft = new Point()
                {
                    X = int.Parse(tokes[0]),
                    Y = int.Parse(tokes[1])
                };

                Point upperRight = new Point()
                {
                    X = int.Parse(tokes[2]),
                    Y = int.Parse(tokes[3])
                };
                Point bottomLeft = new Point()
                {
                    X = int.Parse(tokes[4]),
                    Y = int.Parse(tokes[5])
                };
                Point bottomRight = new Point()
                {
                    X = int.Parse(tokes[6]),
                    Y = int.Parse(tokes[7])
                };

                Box newBox = new Box()
                {
                    UpperLeft = upperLeft,
                    UpperRight = upperRight,
                    BottomLeft = bottomLeft,
                    BottomRight = bottomRight
                };

                boxes.Add(newBox);

                input = Console.ReadLine();
            }

            foreach (var box in boxes)
            {
                int width = Point.CalculateDistance(box.UpperLeft, box.UpperRight);
                int height = Point.CalculateDistance(box.UpperLeft, box.BottomLeft);
                int perimeter = Box.CalculatePerimeter(width, height);
                int area = Box.CalculateArea(width, height);

                Console.WriteLine($"Box: {width}, {height}");
                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine($"Area: {area}");
            }
        }

        public class Box
        {
            public Point UpperLeft { get; set; }
            public Point UpperRight { get; set; }
            public Point BottomLeft { get; set; }
            public Point BottomRight { get; set; }

            public static int CalculatePerimeter(int width, int height)
            {
                return (2 * width + 2 * height);
            }

            public static int CalculateArea(int width, int height)
            {
                return (width * height);
            }
        }

        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public static int CalculateDistance(Point one, Point two)
            {
                int a = one.X - two.X;
                int b = one.Y - two.Y;

                int c = (int)Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

                return c;
            }
        }
    }
}
