namespace _22.Debugging_Exercise_Mining_Coins
{
    using System;

    public class DebuggingExerciseMiningCoins
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var decrypted = string.Empty;
            var totalValue = 0f;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                int digitOne = number / 100;
                int digitTwo = (number / 10) % 10;
                int digitThree = number % 10;

                totalValue += (digitOne + digitTwo + digitThree) / (float)n;

                int charCode = 0;

                if (i % 2 != 0)
                {
                    charCode = ((digitOne * 10) + digitThree) - digitTwo;
                }
                else
                {
                    charCode = ((digitOne * 10) + digitThree ) + digitTwo;
                }

                if ((charCode >= 65 && charCode <= 90)
                    || (charCode >= 97 && charCode <= 122))
                {
                    decrypted += (char)charCode;
                }
            }


            Console.WriteLine("Message: {0}", decrypted);
            Console.WriteLine("Value: {0:F7}", totalValue);
        }
    }
}
