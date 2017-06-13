namespace _20.Debugging_Exercise_Triangle_Formations
{
    using System;

    public class DebuggingExerciseTriangleFormations
    {
        public static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            var conditionOne = a + b > c;
            var conditionTwo = b + c > a;
            var conditionThree = a + c > b;


            var isValidTriangle = conditionOne &&
                conditionTwo &&
                conditionThree;

            if (isValidTriangle)
            {
                Console.WriteLine("Triangle is valid.");

                var rightConditionOne = a * a + b * b == c * c;
                var rightConditionTwo = b * b + c * c == a * a;
                var rightConditionThree = a * a + c * c == b * b;

                if (rightConditionOne)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and b.");
                }
                else if (rightConditionTwo)
                {
                    Console.WriteLine("Triangle has a right angle between sides b and c");
                }
                else if (rightConditionThree)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and c");
                }
                else
                {
                    Console.WriteLine("Triangle has no right angles.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
            }
        }
    }
}
