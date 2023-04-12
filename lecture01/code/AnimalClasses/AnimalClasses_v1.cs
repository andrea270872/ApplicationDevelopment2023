using System;

namespace AnimalClasses
{
    class Animal
    {
        public string name = "anAnimal"; // default, initial value

        public virtual string Describe()
        {
            return "Animal " + name;
        }
    }

    class Mammal : Animal { }

    class Dog : Mammal
    {
        public override string Describe()
        {
            return "The dog " + name + " barks.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.name = "Mitzie";
            Console.WriteLine(d.Describe()); // The dog Mitzie barks.

            Console.WriteLine("Is Mitzie an animal? " + (d is Animal) ); // what is objec d instance of...
            Console.WriteLine("Is Mitzie a mammal? " + (d is Mammal) );
            Console.WriteLine("Is Mitzie a dog? " + (d is Dog) );
        }
    }
}
