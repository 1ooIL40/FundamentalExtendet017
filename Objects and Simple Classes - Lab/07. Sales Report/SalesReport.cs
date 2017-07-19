namespace _07.Sales_Report
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SalesReport
    {
        public static void Main()
        {
            var answer = SelesReport();

            //Logic with class
            //var doneWithClass = new SortedDictionary<string, decimal>();

            //foreach (var town in sales)
            //{
            //    if (!doneWithClass.ContainsKey(town.TownName))
            //    {
            //        doneWithClass[town.TownName] = 0m;
            //    }
            //    doneWithClass[town.TownName] += town.Sales;
            //}
            //foreach (var town in doneWithClass)
            //{
            //    Console.WriteLine($"{town.Key} -> {town.Value:f2}");
            //}
            foreach (var town in answer)
            {
                Console.WriteLine($"{town.Key} -> {town.Value:f2}");
            }
        }
        #region Logic with Class
        //static List<TownSales> SelesReport()
        //{
        //    var numberOfTowns = int.Parse(Console.ReadLine());

        //    var result = new List<TownSales>();

        //    for (int i = 0; i < numberOfTowns; i++)
        //    {
        //        var inputLine = Console.ReadLine()
        //        .Split(' ')
        //        .ToArray();


        //        var town = new TownSales
        //        {
        //            TownName = inputLine[0],
        //            Price = decimal.Parse(inputLine[2]),
        //            Quantity = decimal.Parse(inputLine[3])
        //        };
        //        result.Add(town);
        //    }

        //    return result;
        //}
        #endregion

        #region Logic with Methods
        static SortedDictionary<string, decimal> SelesReport()
        {
            var numberOfTowns = int.Parse(Console.ReadLine());

            var result = new SortedDictionary<string, decimal>();

            //Done only with method

            for (int i = 0; i < numberOfTowns; i++)
            {
                var inputLine = Console.ReadLine()
                .Split(' ')
                .ToArray();


                var towName = inputLine[0];
                decimal selses = decimal.Parse(inputLine[2]) * decimal.Parse(inputLine[3]);


                if (!result.ContainsKey(towName))
                {
                    result[towName] = 0m;
                }
                result[towName] += selses;

            }

            return result;
        }
        #endregion
    }

    public class TownSales
    {
        public string TownName { get; set; }

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }

        public decimal Sales
        {
            get
            {
                return Price * Quantity;
            }
        }
    }
}

