using System;
using System.Collections.Generic;

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

    class Human : Mammal
    {
        private List<Animal> owns = new List<Animal>(); // empty list
        public override string Describe()
        {
            string text = "";
            text += "The human " + name + " talks.";
            if (owns.Count > 0)
            {
                text += "\n And owns these animals: ";
                for (int i=0; i<owns.Count; i++)
                {
                    text += owns[i].name;
                    if (i<owns.Count-1)
                    {
                        text += ",";
                    }
                }
            }
            return text;
        }

        public void AddOwnedAnimal(Animal someAnimal){
            owns.Add(someAnimal);
        }

    }

    class Bat : Mammal {
        public override string Describe()
        {
            return "The bat " + name + " sleeps upside-down.";
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
            Console.WriteLine("Is Mitzie a human? " + (d is Human));

            Dog f = new Dog();
            f.name = "Fufi";

            Console.WriteLine("------------------------------");

            Human me = new Human();
            me.name = "Andrea";
            Console.WriteLine(me.Describe() + "\n");
            me.AddOwnedAnimal(d);
            me.AddOwnedAnimal(f);
            Console.WriteLine(me.Describe() + "\n");

            Bat b = new Bat();
            b.name = "Bruce Wayne";
            Console.WriteLine(b.Describe());

        }
    }
}
