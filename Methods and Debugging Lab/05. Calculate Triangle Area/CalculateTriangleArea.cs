namespace _05.Calculate_Triangle_Area
{
    using System;

    public class CalculateTriangleArea
    {
        public static void Main()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());


            var area = AreaOfTriangle(width, height);

            Console.WriteLine(area);
        }

        static double AreaOfTriangle(double width, double height)
        {
            var result = (width * height) / 2;

            return result;
        }
    }
}
