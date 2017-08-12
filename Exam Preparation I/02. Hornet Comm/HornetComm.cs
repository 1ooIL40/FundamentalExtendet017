namespace _02.Hornet_Comm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Broadcast
    {
        public string Message { get; set; }
        public string Frequency { get; set; }

        public Broadcast(string message, string frequency)
        {
            this.Message = message;
            this.Frequency = frequency;
        }
    }
    public class Messages
    {
        public string Message { get; set; }
        public string Recipient { get; set; }

        public Messages(string message, string recipient)
        {
            this.Message = message;
            this.Recipient = recipient;
        }
    }

    public class HornetComm
    {
        public static List<Broadcast> broadcasts = new List<Broadcast>();
        public static List<Messages> messages = new List<Messages>();

        public static void Main()
        {
            string inputLine = Console.ReadLine();
            Regex isMessage = new Regex(@"(^[0-9]+)\s<->\s([0-9a-zA-Z]+)$");
            Regex isBroadcast = new Regex(@"(^[^0-9]+)\s<->\s([0-9a-zA-Z]+)$");

            while (inputLine != "Hornet is Green")
            {
                if (isMessage.IsMatch(inputLine))
                {
                    AddToListOfMesseges(inputLine);
                }
                if (isBroadcast.IsMatch(inputLine))
                {
                    AddToListOfBroadcasts(inputLine);
                }

                inputLine = Console.ReadLine();
            }

            printBroadcastsResult();
            prindMessegesResult();
        }

        static void prindMessegesResult()
        {
            Console.WriteLine("Messages:");

            if (messages.Count > 0)
            {
                foreach (var message in messages)
                {
                    Console.WriteLine($"{message.Recipient} -> {message.Message}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }

        static void printBroadcastsResult()
        {
            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count > 0)
            {
                foreach (var broadcast in broadcasts)
                {
                    Console.WriteLine($"{broadcast.Frequency} -> {broadcast.Message}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }

        static void AddToListOfBroadcasts(string inputLine)
        {
            string[] tokens = inputLine
                .Split(new string[] { " <-> " },
                StringSplitOptions.RemoveEmptyEntries);

            string messege = tokens[0];
            char[] frequency = tokens[1].ToCharArray();
            string result = string.Empty;

            foreach (var @char in frequency)
            {
                if (@char > 47 && @char < 58)
                {
                    result += @char;
                }
                else if (@char > 64 && @char < 91)
                {
                    result += @char.ToString().ToLower();
                }
                else if (@char > 96 && @char < 123)
                {
                    result += @char.ToString().ToUpper();
                }
            }

            Broadcast newBroadcast = new Broadcast(messege, result);

            broadcasts.Add(newBroadcast);
        }

        static void AddToListOfMesseges(string inputLine)
        {
            string[] tokens = inputLine
                .Split(new string[] { " <-> " },
                StringSplitOptions.RemoveEmptyEntries);

            char[] reverse = tokens[0].ToCharArray();
            string message = tokens[1];
            string recipient = string.Empty;

            for (int i = reverse.Length -1; i >= 0; i--)
            {
                recipient += reverse[i];
            }

            Messages newMessage = new Messages(message, recipient);

            messages.Add(newMessage);
        }
    }
}
