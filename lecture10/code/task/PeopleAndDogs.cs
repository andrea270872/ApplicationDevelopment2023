using System;

namespace PeopleAndDogsApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             - Create a dog and give it the name ”fido” via its constructor
             - Create 3 persons: ”Andrea”, ”Marco”, and ”Bob”. Use the constructor to set the names.
             - Give Andrea 2 friends: Marco and Bob
             - Then give Fido the dog to Marco
             - Use ToString to print a description of Marco: it should also mention that Marco has a dog, named Fido
             - Call ToString on Andrea: it should list also his friends.
            */

            Dog d = new Dog("fido");
            Person p1 = new Person("Andrea");
            Person p2 = new Person("Marco");
            Person p3 = new Person("Bob");

            p1.AddFriend(p2);
            p1.AddFriend(p3);

            p2.Gets(d);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            /* output is:
             
                Andrea
                   Friends are: Marco Bob
                Marco; owns Dog:fido
                Bob
            */
        }
    }


    class Person
    {
        private string _myName;
        private Dog? _dog; // nullable, so I can have 0 dogs!
        private List<Person> _friendsList;

        public Person(string name)
        {
            this._myName = name;
            this._dog = null;  // no dog initially
            this._friendsList = new List<Person>(); // no friends initially
        }

        public void Gets(Dog d)
        {
            this._dog = d;
        }

        public override string ToString()
        {
            string msg = this._myName;
            if (this._dog != null)
            {
                msg += "; owns " + this._dog;
            }
            if (this._friendsList.Count > 0) {
                msg += "\n   Friends are: ";
                foreach (Person friend in this._friendsList) { 
                    msg += friend._myName + " "; // it is OK, because same class! ;)
                }
            }
            return msg;
        }

        public void AddFriend(Person other)
        {
            this._friendsList.Add(other);
        }
    }

    abstract class Animal
    {
        // something in common to all animals ...
    }

    class Dog : Animal
    {
        private string _name;

        public Dog(string name)
        {
            this._name = name;
        }
        public override string ToString()
        {
            return "Dog:"+this._name;
        }
    }

}