namespace _12.Variable_in_Hexadecimal_Format
{
    using System;

    public class VariableInHexadecimalFormat
    {
        public static void Main()
        {
            var number = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(number,16));
        }
    }
}
