namespace _02.Track_Downloader
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TrackDownloader
    {
        public static void Main()
        {
            var blackList = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var trackSongs = Console.ReadLine();

            var finalTrackList = new List<string>();

            //add to list
            while (trackSongs != "end")
            {

                finalTrackList.Add(trackSongs);

                for (int i = 0; i < blackList.Count; i++)
                {

                    if (trackSongs.Contains(blackList[i]))
                    {
                        finalTrackList.RemoveAt(finalTrackList.Count -1);
                        break;
                    }
                }


                trackSongs = Console.ReadLine();
            }

            finalTrackList.Sort();

            Console.WriteLine(string.Join(Environment.NewLine,finalTrackList));
        }
    }
}
