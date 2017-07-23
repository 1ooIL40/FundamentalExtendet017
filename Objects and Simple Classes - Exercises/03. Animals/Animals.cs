namespace _03.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Animals
    {
        public static List<Dog> dogs = new List<Dog>();
        public static List<Cat> cats = new List<Cat>();
        public static List<Snake> snakes = new List<Snake>();

        public static void Main()
        {
            string inputLine = Console.ReadLine();

            while (inputLine != "I'm your Huckleberry")
            {
                string[] tokens = inputLine
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                if(tokens.Length > 2)
                {
                    string clas = tokens[0];

                    switch (clas)
                    {
                        case "Dog":
                            AddDogs(tokens);
                            break;
                        case "Cat":
                            AddCats(tokens);
                            break;
                        case "Snake":
                            AddSnakes(tokens);
                            break;
                    }
                }
                else
                {
                    string name = tokens[1];

                    SoundProduce(name);
                }

                inputLine = Console.ReadLine();
            }

            PrintResults();
        }

#region Print the objects in evry list
        private static void PrintResults()
        {
            foreach (var dog in dogs)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
            }

            foreach (var cat in cats)
            {
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.InteligenceQuotient}");
            }

            foreach (var snake in snakes)
            {
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.CrueltyCoeficient}");
            }
        }
#endregion

#region Produce Sound
        private static void SoundProduce(string name)
        {
            foreach (var dog in dogs)
            {

                if (dog.Name == name)
                {
                    Dog.ProduceSound();
                    break;
                }
            }

            foreach (var cat in cats)
            {

                if (cat.Name == name)
                {
                    Cat.ProduceSound();
                    break;
                }
            }

            foreach (var snake in snakes)
            {

                if (snake.Name == name)
                {
                    Snake.ProduceSound();
                    break;
                }
            }
#endregion

        }

#region Add Dogs/Cats/Snakes to list
        private static void AddDogs(string[] tokens)
        {
            string name = tokens[1];
            int age = int.Parse(tokens[2]);
            int parameter = int.Parse(tokens[3]);

            Dog newDog = new Dog
            {
                Name = name,
                Age = age,
                NumberOfLegs = parameter
            };

            dogs.Add(newDog);

        }

        private static void AddCats(string[] tokens)
        {
            string name = tokens[1];
            int age = int.Parse(tokens[2]);
            int parameter = int.Parse(tokens[3]);

            
            Cat newCat = new Cat
            {
                Name = name,
                Age = age,
                InteligenceQuotient = parameter
            };

            cats.Add(newCat);
        }

        private static void AddSnakes(string[] tokens)
        {
            string name = tokens[1];
            int age = int.Parse(tokens[2]);
            int parameter = int.Parse(tokens[3]);

            Snake newSnake = new Snake
            {
                Name = name,
                Age = age,
                CrueltyCoeficient = parameter
            };

            snakes.Add(newSnake);
        }
#endregion

    }
#region Classes
    public class Dog
    {
        public string Name  { get; set; }
        public int Age { get; set; }
        public int NumberOfLegs { get; set; }

        public static void ProduceSound()
        {
            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
        }
    }

    public class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int InteligenceQuotient{ get; set; }

        public static void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }
    }

    public class Snake
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CrueltyCoeficient{ get; set; }

        public static void ProduceSound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }
    }
#endregion
}
