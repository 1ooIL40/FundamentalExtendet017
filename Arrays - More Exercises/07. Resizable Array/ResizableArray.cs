
namespace _07.Resizable_Array
{
    using System;
    using System.Linq;

    public class ResizableArray
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var result = string.Empty;
            var output = string.Empty;
            Answer(input, result, output);


        }

        static void Answer(string input, string result, string output)
        {
            while (true)
            {
                var number = string.Empty;
                var commands = input
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var len = commands.Length;

                if (len > 1)
                {
                    number = commands[1];
                }

                if (commands[0] == "push")
                {
                    result = PushMethod(output, number);
                    output = result;
                    //add element
                }
                else if (commands[0] == "pop")
                {
                    result = PopMethod(output, number);
                    output = result;
                    //remove last element
                }
                else if (commands[0] == "removeAt")
                {
                    result = RemoveAt(output, number);
                    output = result;
                    //remove element at that position
                }
                else if (commands[0] == "clear")
                {
                    result = Clear(output);
                    output = result;
                    //eres the array;
                }

                if (input == "end")
                {
                    var answer = output
                        .Split(new char[] { ' ' },
                        StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    if (answer.Length == 0)
                    {
                        Console.WriteLine("empty array");
                        break;
                    }
                    else
                    {
                        for (int i = 0; i < answer.Length; i++)
                        {
                            if (i != answer.Length - 1)
                            {
                                Console.Write(answer[i] + " ");
                            }
                            else
                            {
                                Console.Write(answer[i]);
                            }
                        }
                        Console.WriteLine();
                        break;
                    }
                }
                input = Console.ReadLine();
            }
        }

        static string Clear(string output)
        {
            var clear = string.Empty;

            return clear;
        }

        static string RemoveAt(string output, string number)
        {
            var result = string.Empty;
            var remove = output
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var len = remove.Length;
            var position = int.Parse(number);

            for (int i = 0; i < len; i++)
            {
                if (i != position)
                {
                    result += remove[i] + " ";
                }
            }
            return result;
        }

        static string PopMethod(string output, string number)
        {
            var result = string.Empty;
            var popOut = output
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var len = popOut.Length;

            for (int i = 0; i < len - 1; i++)
            {
                result += popOut[i] + " ";
            }

            return result;
        }

        static string PushMethod(string output, string number)
        {
            var result = output + number + " ";

            return result;
        }

    }
}
