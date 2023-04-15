using System;

namespace Associations_example
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
}