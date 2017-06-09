namespace _05.BPM_Counter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    public class BPMCounter
    {
        public static void Main()
        {
            var bpm = int.Parse(Console.ReadLine());
            var numberOfBeats = int.Parse(Console.ReadLine());

            var bars = Math.Round((numberOfBeats / 4.0), 1);
            var seconds = ((numberOfBeats * 60) / bpm);

            var time = TimeSpan.FromSeconds(seconds);

            Console.WriteLine($"{bars} bars - {time.Minutes}m {time.Seconds}s");
        }
    }
}
