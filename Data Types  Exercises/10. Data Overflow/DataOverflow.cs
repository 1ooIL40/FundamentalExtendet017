namespace _10.Data_Overflow
{
    using System;
    using System.Linq;

    public class DataOverflow
    {
        public static void Main()
        {
            var firstNumber = ulong.Parse(Console.ReadLine());
            var secondNumber = ulong.Parse(Console.ReadLine());

            var lowestOne = Math.Min(firstNumber, secondNumber);
            var bigestOne = Math.Max(firstNumber, secondNumber);

            var greaterOverflows = 0d;

            var byMin = byte.MinValue;
            var byMax = byte.MaxValue;
            var usMin = ushort.MinValue;
            var usMax = ushort.MaxValue;
            var uiMin = uint.MinValue;
            var uiMax = uint.MaxValue;
            var ulMin = ulong.MinValue;
            var ulMax = ulong.MaxValue;

            var isTrue = false;
            var type = string.Empty;




            if (bigestOne >= byMin && bigestOne <= byMax)
            {
                Console.WriteLine("bigger type: byte");
            }
            else if (bigestOne >= usMin && bigestOne <= usMax)
            {
                Console.WriteLine("bigger type: ushort");
            }
            else if (bigestOne >= uiMin && bigestOne <= uiMax)
            {
                Console.WriteLine("bigger type: uint");
            }
            else if (bigestOne >= ulMin && bigestOne <= ulMax)
            {
                Console.WriteLine("bigger type: ulong");
            }


            if (lowestOne >= byMin && lowestOne <= byMax)
            {
                greaterOverflows = Math.Round((double)bigestOne / byMax);
                isTrue = true;
                type = "byte";
            }
            else if (lowestOne >= usMin && lowestOne <= usMax)
            {
                greaterOverflows = Math.Round((double)bigestOne / usMax);
                isTrue = true;
                type = "ushort";
            }
            else if (lowestOne >= uiMin && lowestOne <= uiMax)
            {
                greaterOverflows = Math.Round((double)bigestOne / uiMax);
                isTrue = true;
                type = "uint";
            }
            else if (lowestOne >= ulMin && lowestOne <= ulMax)
            {
                greaterOverflows = Math.Round((double)bigestOne / ulMax);
                isTrue = true;
                type = "ulong";
            }

            if (isTrue)
            {
                Console.WriteLine($"smaller type: {type}");
                Console.WriteLine($"{bigestOne} can overflow {type} {greaterOverflows} times");
            }
        }
    }
}
