namespace _05.Closest_Two_Points
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ClosestTwoPoints
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var listOfPoints = GetPointCordinates(n);

            CheckDistance(listOfPoints);
        }

        static void CheckDistance(List<Point> listOfPoints)
        {
            var compare = double.MaxValue;
            var pointOne = new Point();
            var pointTwo = new Point();

            for (int i = 0; i < listOfPoints.Count; i++)
            {
                var first = listOfPoints[i];

                for (int j = i + 1; j < listOfPoints.Count; j++)
                {
                    var second = listOfPoints[j];
                    var distance = Math.Pow((first.X - second.X), 2) + Math.Pow((first.Y - second.Y), 2);

                    var answer = Math.Sqrt(distance);

                    if (answer < compare)
                    {
                        compare = answer;

                        pointOne = first;
                        pointTwo = second;
                    }
                }
            }

            Console.WriteLine($"{compare:f3}");
            Console.WriteLine($"({pointOne.X}, {pointOne.Y})");
            Console.WriteLine($"({pointTwo.X}, {pointTwo.Y})");
        }

        static List<Point> GetPointCordinates(int n)
        {
            var result = new List<Point>();
            for (int i = 0; i < n; i++)
            {
                var pointCoords = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                var point = new Point
                {
                    X = pointCoords[0],
                    Y = pointCoords[1]
                };
                result.Add(point);
            }
            return result;
        }
    }

    public class Point
    {
        public int X { get; set; }

        public int Y { get; set; }
    }
}
