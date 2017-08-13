namespace _04.Hornet_Armada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    

    public class HornetArmada
    {
        public static Dictionary<string, Dictionary<string, long>> typeAndCount = new Dictionary<string, Dictionary<string, long>>();
        public static Dictionary<string, int> nameAndActivity = new Dictionary<string, int>();
        
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Regex pattern = new Regex(@"^(?<activity>^[0-9]+)\s\=\s(?<legion>[^=>\-:\s]+)\s->\s(?<soldierT>[^=>\-:\s]+):(?<soldierC>[0-9]+)$");

            //{lastActivity} = {legionName} -> {soldierType}:{soldierCount}

            for (int i = 0; i < n; i++)
            {
                string inputLine = Console.ReadLine();
                var match = pattern.Match(inputLine);

                int activity = int.Parse(match.Groups["activity"].Value);
                var legion = match.Groups["legion"].Value;
                var soldierT = match.Groups["soldierT"].Value;
                long soldierC = long.Parse(match.Groups["soldierC"].Value);

                //put the data for activity and legion names in dictionary
                AddActivityAndLeginName(activity, legion);
                //put the data for legin and soldiers names, and soldier count in dictionary
                AddLegionAndSoldierInfo(legion, soldierT, soldierC);

            }

            string[] commands = Console.ReadLine()
                .Split(new char[] { '\\' },
                StringSplitOptions.RemoveEmptyEntries);

            if(commands.Length > 1)
            {
                int activity = int.Parse(commands[0]);
                string soldierType = commands[1];

                //take the lgeions who have les then the input activity
                nameAndActivity = nameAndActivity
                    .Where(v => v.Value < activity)
                    .ToDictionary(k => k.Key, v => v.Value);
                
                //take the legions who have the soldierType and order them by the type count
                foreach (var name in typeAndCount
                    .Where(legin => legin.Value.ContainsKey(soldierType))
                    .OrderByDescending(legion => legion.Value[soldierType]))
                {
                    
                    if (nameAndActivity.ContainsKey(name.Key))
                    {
                        Console.WriteLine($"{name.Key} -> {typeAndCount[name.Key][soldierType]}");
                    }
                }
            }
            else
            {
                string soldierType = commands[0];

                nameAndActivity = nameAndActivity
                    .OrderByDescending(v=> v.Value)
                    .ToDictionary(k => k.Key, v => v.Value);


                //-	{lastActivity} : {legionName}
                foreach (var legion in nameAndActivity)
                {
                    if (typeAndCount[legion.Key].ContainsKey(soldierType))
                    {
                        Console.WriteLine($"{legion.Value} : {legion.Key}");
                    }
                }


                string debug = string.Empty;
            }


        }

        static void AddLegionAndSoldierInfo(string legion, string soldierT, long soldierC)
        {
            if (!typeAndCount.ContainsKey(legion))
            {
                typeAndCount[legion] = new Dictionary<string, long>();
            }
            if (!typeAndCount[legion].ContainsKey(soldierT))
            {
                typeAndCount[legion][soldierT] = 0;
            }
            typeAndCount[legion][soldierT] += soldierC;

        }

        static void AddActivityAndLeginName(int activity, string legion)
        {
            if (!nameAndActivity.ContainsKey(legion))
            {
                nameAndActivity[legion] = 0;
            }
            if(nameAndActivity[legion] < activity)
            {
                nameAndActivity[legion] = activity;
            }
        }
    }
}
