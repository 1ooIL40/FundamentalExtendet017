namespace _06.Messages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Messages
    {
        public static void Main()
        {
            var users = new Dictionary<string,User>();

            string inputLine = Console.ReadLine();
            string sender;
            string recipient;


            while (inputLine != "exit")
            {
                string[] tokens = inputLine
                    .Split(' ');

                if(tokens[0] == "register")
                {
                    string username = tokens[1];
                    User newUser = new User(username);

                    users.Add(username, newUser);
                }
                else
                {
                    sender = tokens[0];
                    recipient = tokens[2];
                    string content = tokens[3];

                    if(users.ContainsKey(sender) && 
                        users.ContainsKey(recipient))
                    {
                        User senderUser = users[sender];
                        users[recipient].Messegas.Add(new Message(content, senderUser));
                    }
                }

                inputLine = Console.ReadLine();
            }

            string[] chatTokens = Console.ReadLine().Split(' ');

            sender = chatTokens[0];
            recipient = chatTokens[1];

            Message[] senderMesseages = users[recipient].Messegas
                .Where(m => m.Sender.Username == sender)
                .ToArray();

            Message[] recipientMesseages = users[sender].Messegas
                .Where(m => m.Sender.Username == recipient)
                .ToArray();

            if (senderMesseages.Length == 0 &&
                recipientMesseages.Length == 0)
            {
                Console.WriteLine("No messages");
            }
            else
            {
                int index = Math.Max(senderMesseages.Length, recipientMesseages.Length);

                for (int i = 0; i < index; i++)
                {
                    if (i < senderMesseages.Length)
                    {
                        Console.WriteLine($"{sender}: {senderMesseages[i].Content}");
                    }
                    if (i < recipientMesseages.Length)
                    {
                        Console.WriteLine($"{recipientMesseages[i].Content} :{recipient}");
                    }
                }
            }
        }
    }

    public class User
    {
        public string Username { get; set; }
        public List<Message> Messegas { get; set; }

        public User(string username)
        {
            this.Username = username;
            this.Messegas = new List<Message>();
        }
    }

    public class Message
    {
        public string Content { get; set; }
        public User Sender { get; set; }

        public Message (string content, User sender)
        {
            this.Content = content;
            this.Sender = sender;
        }
    }
}
