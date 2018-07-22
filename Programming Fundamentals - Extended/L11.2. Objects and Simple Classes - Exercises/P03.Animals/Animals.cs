namespace P03.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Animals
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var dogs = new List<Dog>();
            var cats = new List<Cat>();
            var snakes = new List<Snake>();

            while (input != "I'm your Huckleberry")
            {
                var inputParams = input.Split();

                var name = inputParams[1];

                if (inputParams[0] != "talk")
                {
                    var currentClass = inputParams[0];
                    var age = int.Parse(inputParams[2]);
                    var parameter = int.Parse(inputParams[3]);

                    switch (currentClass)
                    {
                        case "Dog":
                            dogs.Add(new Dog(name, age, parameter));
                            break;
                        case "Cat":
                            cats.Add(new Cat(name, age, parameter));
                            break;
                        case "Snake":
                            snakes.Add(new Snake(name, age, parameter));
                            break;
                    }
                }
                else if (dogs.Any(d => d.Name == name))
                {
                    Dog.ProduceSound();
                }
                else if (cats.Any(c => c.Name == name))
                {
                    Cat.ProduceSound();
                }
                else
                {
                    Snake.ProduceSound();
                }

                input = Console.ReadLine();
            }

            foreach (var dog in dogs)
            {
                Console.WriteLine(
                    $"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
            }

            foreach (var cat in cats)
            {
                Console.WriteLine(
                    $"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.IntelligenceQuotient}");
            }

            foreach (var snake in snakes)
            {
                Console.WriteLine(
                    $"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.CrueltyCoefficient}");
            }
        }

        public class Dog
        {
            public Dog(string name, int age, int parameter)
            {
                this.Name = name;
                this.Age = age;
                this.NumberOfLegs = parameter;
            }

            public string Name { get; set; }

            public int Age { get; set; }

            public int NumberOfLegs { get; set; }

            public static void ProduceSound()
            {
                Console.WriteLine(
                    "I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
            }
        }

        public class Cat
        {
            public Cat(string name, int age, int parameter)
            {
                this.Name = name;
                this.Age = age;
                this.IntelligenceQuotient = parameter;
            }

            public string Name { get; set; }

            public int Age { get; set; }

            public int IntelligenceQuotient { get; set; }

            public static void ProduceSound()
            {
                Console.WriteLine(
                    "I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
            }
        }

        public class Snake
        {
            public Snake(string name, int age, int parameter)
            {
                this.Name = name;
                this.Age = age;
                this.CrueltyCoefficient = parameter;
            }

            public string Name { get; set; }

            public int Age { get; set; }

            public int CrueltyCoefficient { get; set; }

            public static void ProduceSound()
            {
                Console.WriteLine(
                    "I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
            }
        }
    }
}