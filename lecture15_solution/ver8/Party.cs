using System.Linq;

namespace RPGGame
{
    public class Party : Character
    {
        List<Character> members;
        public Party(string name, int xp=-1, int hp=-1) : base(name, xp, hp)
        {
            // I don't need xp and hp ... 

            members = new List<Character>();
        }

        public override string DoSomething()
        {
            return "jsut waiting...";
        }

        public override string? ToString()
        {
            String subs = "";
            foreach (Character c in members)
            {
                subs += "  " + c.ToString() + "\n";
            }
            return $"Party {name}\n" + subs;
        }

        public void add(Character c)
        {
            members.Add(c);
        }

        public int HeadCount()
        {
            int count = 0;
            foreach (Character c in members)
            {
                if (c.GetType() != typeof(Party)) // single character
                {
                    count++;
                } else
                {  // c is a Party object
                    count = count + ((Party)c).HeadCount();
                }
            }
            return count;
        }

        public static Party MakePartyOfType(String typeName)
        {
            Party result = null;
            if (typeName == "type 1")
            {
                // TO DO randomize names and attributes
                result = new Party("Party of type 1");
                result.add(new Human("Jack", 5, 80));
                result.add(new Dwarf("OakArm", 10, 100));
                result.add(new Dwarf("StoutNose", 50, 200));            
            }            

            // TO DO ... make more types/IFs

            return result;
        }

        /*
        When a party P1 attacks another party P2 you should:
            - For each character of P1
            - Find a random character in P2
            - The P1 character attacks the P2 character
       
        REMEMBER a party might contain other sub-parties, 
        so the character could come from any of the sub-parties too…

        */
        public void Attack(Party otherParty)
        {
            List<SingleCharacter> allSingleChars = GetAllSingleCharacterMembers();
            List<SingleCharacter> allSingleCharsOtherParty = otherParty.GetAllSingleCharacterMembers();

            /*
            // DEBUG - start 
            Console.Write("<AllSingleChars = ");
            foreach (SingleCharacter c in allSingleChars)
            {
                Console.Write(c.name + " ");
            }
            Console.WriteLine(">");

            Console.Write("<AllSingleCharsOtherParty = ");
            foreach (SingleCharacter c in allSingleCharsOtherParty)
            {
                Console.Write(c.name + " ");
            }
            Console.WriteLine(">");
            // DEBUG - end
            */


            foreach (SingleCharacter sc in allSingleChars)
            {
                int randomOne = random.Next(0, allSingleCharsOtherParty.Count);
                SingleCharacter randomOpponent = allSingleCharsOtherParty[randomOne];
                sc.Attack(randomOpponent);

                Console.WriteLine($"     -> {sc.name} attacks {randomOpponent.name}");
            }
        }

        protected List<SingleCharacter> GetAllSingleCharacterMembers()
        {
            List<SingleCharacter> theList = new List<SingleCharacter>();
            foreach (Character c in members)
            {
                if (c.GetType() != typeof(Party))
                {
                    theList.Add( (SingleCharacter)c );
                }
                else
                {   // c is a Party object 
                    // append all elements of the sub party to the current list 
                    List<SingleCharacter> subPartyList = ((Party)c).GetAllSingleCharacterMembers();
                    foreach(SingleCharacter sub in subPartyList)
                    {
                        theList.Add(sub);
                    }
                }
            }
            return theList;
        }
    }
}