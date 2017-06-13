namespace _19.Debugging_Exercise_Tricky_Strings
{
    using System;

    public class DebuggingExerciseTrickyStrings
    {
        public static void Main()
        {
            var delimiter = Console.ReadLine();
            var numberOfStrings = int.Parse(Console.ReadLine());
            var result = string.Empty;
            for (int i = 1; i <= numberOfStrings; i++)
            {
                var currentString = Console.ReadLine();

                if (numberOfStrings == i)
                {
                    result += currentString;
                }
                else
                {
                    result += currentString + delimiter;
                }
            }
            Console.WriteLine(result);
        }
    }
}
