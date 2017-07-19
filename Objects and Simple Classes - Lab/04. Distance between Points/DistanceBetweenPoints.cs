namespace _04.Distance_between_Points
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Point
    {
        public int X { get; set; }

        public int Y { get; set; }


        public static double CalculateDistance(Point one, Point two)
        {
            int a = Math.Abs(one.X - two.X);
            int b = Math.Abs(one.Y - two.Y);

            double c = Math.Sqrt(a * a + b * b);

            return c;
        }
    }

    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            int[] firstCoords = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] secondCoords = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            Point firstPoint = new Point()
            {
                X = firstCoords[0],
                Y = firstCoords[1],
            };

            Point secondPoint = new Point()
            {
                X = secondCoords[0],
                Y = secondCoords[1]
            };


            double result = Point.CalculateDistance(firstPoint, secondPoint);

            Console.WriteLine($"{result:f3}");
        }
    }
}
