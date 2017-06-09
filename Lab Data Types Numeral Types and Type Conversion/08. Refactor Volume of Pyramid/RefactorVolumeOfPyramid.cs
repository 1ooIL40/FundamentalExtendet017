namespace _08.Refactor_Volume_of_Pyramid
{
    using System;

    public class RefactorVolumeOfPyramid
    {
        public static void Main()
        {
            Console.Write("Length: ");
            var lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            var width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            var height = double.Parse(Console.ReadLine());
            var volume = (lenght * width * height) / 3;
            Console.WriteLine($"Pyramid Volume: {volume:F2}");
        }
    }
}
