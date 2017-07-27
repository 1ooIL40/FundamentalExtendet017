namespace _03.Text_Filter
{
    using System;

    public class TextFilter
    {
        public static void Main()
        {
            string[] bannedWOrds = Console.ReadLine()
                .Split(new char[] { ',', ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            string textInput = Console.ReadLine();

            foreach (var word in bannedWOrds)
            {
                textInput = textInput.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(textInput);
        }
    }
}
