namespace _03.Hornet_Assault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class HornetAssault
    {
        public static void Main()
        {
            List<long> amountOfBeehives = SplitThem();
            List<long> hornetsPower = SplitThem();


            for (int i = 0; i < amountOfBeehives.Count; i++)
            {
                if(hornetsPower.Count == 0 )
                {
                    break;
                }

                long totalHornetsPower = hornetsPower.Sum();
                long beehives = amountOfBeehives[i];

                long attackResult = beehives - totalHornetsPower;

                if(attackResult < 0)
                {
                    amountOfBeehives.RemoveAt(i);
                    i--;
                }
                else if(attackResult == 0)
                {
                    amountOfBeehives.RemoveAt(i);
                    hornetsPower.RemoveAt(0);
                    i--;
                }
                else if (attackResult > 0)
                {
                    hornetsPower.RemoveAt(0);
                    amountOfBeehives[i] = Math.Abs(attackResult);
                }

            }
            if(amountOfBeehives.Count > 0)
            {
                Console.WriteLine(string.Join(" ", amountOfBeehives));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornetsPower));
            }
        }

        static List<long> SplitThem()
        {
            List<long> result = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            return result;
        }
    }
}
