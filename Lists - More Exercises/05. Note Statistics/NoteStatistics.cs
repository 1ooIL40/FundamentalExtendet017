namespace _05.Note_Statistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NoteStatistics
    {
        public static void Main()
        {
            //var inputNumbers = "293,66 311,13 293,66 311,13 349,23 349,23";

            var userInput = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            NoteAndSumOfTheFrequency(userInput);

        }

        static void NoteAndSumOfTheFrequency(List<double> userInput)
        {
            var noteList = new List<string> { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

            var frequencyList = new List<double> { 261.63, 277.18, 293.66, 311.13, 329.63, 349.23, 369.99, 392.00, 415.30, 440.00, 466.16, 493.88 };

            var notes = new List<string>();
            var naturalNotes = new List<string>();
            var sharpsNotes = new List<string>();


            

            // Find all Notes
            foreach (var number in userInput)
            {

                for (int i = 0; i < frequencyList.Count; i++)
                {
                    var currentNumber = frequencyList[i];

                    if (currentNumber == number)
                    {
                        notes.Add(noteList[i]);
                    }
                }
            }

            // Separate Notes on Natruals and Sharps

            for (int i = 0; i < notes.Count; i++)
            {
                var currentNote = notes[i].ToString();

                if (currentNote.Length < 2)
                {
                    naturalNotes.Add(notes[i]);
                }
                else
                {
                    sharpsNotes.Add(notes[i]);
                }
            }

            var naturalSum = SumOfNotes(noteList, frequencyList, naturalNotes);
            var sharpsSum = SumOfNotes(noteList, frequencyList, sharpsNotes);


            Console.WriteLine($"Notes: {string.Join(" ", notes)}");
            Console.WriteLine($"Naturals: {string.Join(", ", naturalNotes)}");
            Console.WriteLine($"Sharps: {string.Join(", ", sharpsNotes)}");
            Console.WriteLine($"Naturals sum: {naturalSum}");
            Console.WriteLine($"Sharps sum: {sharpsSum}");


        }


        static double SumOfNotes(List<string> noteList, List<double> frequencyList, List<string> notes)
        {
            double sum = 0;
            foreach (var note in notes)
            {

                for (int i = 0; i < noteList.Count; i++)
                {

                    var currentNote = noteList[i];

                    if (note == currentNote)
                    {
                        sum += frequencyList[i];
                    }

                }
            }
            return sum;
        }

    }
}
