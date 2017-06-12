namespace _01.Blank_Receipt
{
    using System;
    using System.Text;
    
    public class BlankReceipt
    {
        public static void Main()
        {
            PrintRecipe();
        }

        static void PrintRecipe()
        {
            Header();
            Console.WriteLine("------------------------------");
            Body();
            Console.WriteLine("------------------------------");
            Footer();
        }

        static void Footer()
        {
            //Console.WriteLine("© SoftUni"); // not working
            Console.WriteLine("\u00A9 SoftUni"); // also not working
        }

        static void Body()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void Header()
        {
            Console.WriteLine("CASH RECEIPT");
        }
    }
}
