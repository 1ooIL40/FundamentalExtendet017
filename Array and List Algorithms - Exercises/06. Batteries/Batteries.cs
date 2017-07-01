namespace _06.Batteries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Batteries
    {
        public static void Main()
        {
            
            var capacity = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            var usagePerHour = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            var hours = int.Parse(Console.ReadLine());

            var batteryChargePerHours = BatteryChargePerHours(capacity, usagePerHour, hours);

            var chargeLeft = BatteryChargeLeft(capacity, usagePerHour, batteryChargePerHours);

            ResultOutput(capacity, hours, chargeLeft);

        }

        static List<double> BatteryChargePerHours(double[] capacity, double[] usagePerHour, int hours)
        {
            var batteryChargePerHours = new List<double>();

            for (int mAh = 0; mAh < capacity.Length; mAh++)
            {
                var usage = usagePerHour[mAh] * (double)hours;

                batteryChargePerHours.Insert(mAh, usage);
            }

            return batteryChargePerHours;
        }

        static void ResultOutput(double[] capacity, int hours, List<double> chargeLeft)
        {
            for (int i = 0; i < chargeLeft.Count; i++)
            {
                var battery = chargeLeft[i];

                if (battery > hours)
                {
                    var percentage = (battery * 100) / capacity[i];
                    Console.WriteLine($"Battery {i + 1}: {battery:f2} mAh ({percentage:f2})%");
                }
                else
                {
                    Console.WriteLine($"Battery {i + 1}: dead (lasted {battery} hours)");
                }
            }
        }

        static List<double> BatteryChargeLeft(double[] capacity, double[] usagePerHour, List<double> batteryCharge)
        {
            var chargeLeft = new List<double>();

            for (int i = 0; i < capacity.Length; i++)
            {
                if (capacity[i] >= batteryCharge[i])
                {
                    var resultCapacity = capacity[i] - batteryCharge[i];
                    chargeLeft.Insert(i, resultCapacity);
                }
                else if (capacity[i] < batteryCharge[i])
                {
                    var deadHours = Math.Ceiling(capacity[i] / usagePerHour[i]);
                    chargeLeft.Insert(i, deadHours);
                }
            }

            return chargeLeft;
        }
    }
}
