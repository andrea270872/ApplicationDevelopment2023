using System;

namespace BadSmells
{
    internal class Program
    {
        public class Stuff : IComparable
        {
            public string name;
            public int rating;
            public string[] taste;


            // this is needed to make the objects from
            // the class "sortable" ;)
            public int CompareTo(object? obj)
            {
                Stuff? stuff = obj as Stuff;
                return rating.CompareTo(stuff.rating);
            }
        }



        static Stuff[] whatever = new Stuff[4];

        static void letsDoThis()
        {
            whatever[0] = new Stuff();
                whatever[0].name = "Cola";
                whatever[0].rating = 8;
                whatever[0].taste = new string[]{ "sweet", "sparkling", "stimulating" };
            whatever[1] = new Stuff();
                whatever[1].name = "Coffee";
                whatever[1].rating = 6;
                whatever[1].taste = new string[] { "bitter", "stimulating" };
            whatever[2] = new Stuff();
                whatever[2].name = "Herbal tea";
                whatever[2].rating = 3;
                whatever[2].taste = new string[] { "sweet", "relaxing" };
            whatever[3] = new Stuff();
                whatever[3].name = "Sparkling wine";
                whatever[3].rating = 7;
                whatever[3].taste = new string[] { "bitter", "sparkling" };

            // here I print the data about all drinks
            for (int i = 0; i < 4; i++)
            {
                string text = string.Format("{0},{1}/10", whatever[i].name , whatever[i].rating);
                Console.WriteLine(text);
            }
           Console.WriteLine(" ---------------- ");

            bool smallToLarge = true;
            void sortByRating()
            {
                if (smallToLarge)
                {
                    List<Stuff> temp = new List<Stuff>(whatever);
                    temp.Sort();
                    //temp.ForEach(w => { Console.Write(((Stuff)w).name + ">"); }); Console.WriteLine();
                    whatever = temp.ToArray<Stuff>();
                } else
                {
                    List<Stuff> temp = new List<Stuff>(whatever);
                    temp.Sort();
                    temp.Reverse();
                    //temp.ForEach(w => { Console.Write(((Stuff)w).name + ">"); }); Console.WriteLine();
                    whatever = temp.ToArray<Stuff>();
                }
            }

            smallToLarge = false;
            sortByRating();
            
            for (int i = 0; i < 4; i++)
            {
                string text = string.Format("{0} -->{1},{2}/10",
                                                i,whatever[i].name, whatever[i].rating);
                Console.WriteLine(text);
            }
            Console.WriteLine(" ---------------- ");

            /* this is a very clever trick to count the different tastes in the drinks.
               I start from an empty dictionary, that I will use as a table,
               then for each element of the list of drinks I iterate over the tastes that it has,
               adding 1 everytime I find one more "taste" with the same name.
               If the taste does not yet exist in the table, I first create it, then proceed to 
               add 1.
            */
            Dictionary<string,int> a = new Dictionary<string, int>();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < whatever[i].taste.Length; j++)
                {
                    if (a.ContainsKey(whatever[i].taste[j]) == false)
                    {
                        a[whatever[i].taste[j]] = 0;
                    }
                    a[whatever[i].taste[j]] = a[whatever[i].taste[j]] + 1;
                }
            }
            Console.WriteLine("How many whatever are X?");
            a.Keys.ToList().ForEach(key => Console.WriteLine("   There are " + a[key]+ " <<" + key +">>"));

            double abc;
            void printInPercentage(int param1, int param2, int param3, int param4, int param5)
            {
                Console.WriteLine(param1 + " is " + (param1 / abc * 100) + "%");
                Console.WriteLine(param2 + " is " + (param2 / abc * 100) + "%");
                Console.WriteLine(param3 + " is " + (param3 / abc * 100) + "%");
                Console.WriteLine(param4 + " is " + (param4 / abc * 100) + "%");
                Console.WriteLine(param5 + " is " + (param5 / abc * 100) + "%");
            }

            Console.WriteLine("Percentages:");
            abc = a["sweet"] + a["relaxing"] + a["bitter"] + a["stimulating"] + a["sparkling"];
            printInPercentage(a["sweet"] , a["relaxing"] , a["bitter"] , a["stimulating"] , a["sparkling"]);
        }
        static void Main(string[] args)
        {
            letsDoThis();

            Console.WriteLine(" *********************************** ");
            for (int i = 0; i < 4; i++)
            {
                string text = string.Format("{0}, {1}/10 ##{2}##" , 
                    whatever[i].name, whatever[i].rating, string.Join(",",whatever[i].taste));
	                Console.WriteLine(text);
            }
            Console.WriteLine(" *********************************** ");
        }
    }
}