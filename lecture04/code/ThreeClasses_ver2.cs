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