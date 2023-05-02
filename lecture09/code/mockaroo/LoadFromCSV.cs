using System.Reflection.PortableExecutable;

namespace LoadFromCSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // !!!! change this path !!!!
            StreamReader reader = new StreamReader(@"c:\dev\MOCK_DATA.csv");
            List<PersonData> allData = new List<PersonData>();

            if (!reader.EndOfStream)
            {
                // read the headers of the columns
                string line = reader.ReadLine(); // could be null, so ?
                string[] values = line.Split(',');
                Console.WriteLine(values[0] + " / " + values[1] + " / " + values[2] + " / ... ");
            }

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine(); // could be null, so ?
                string[] values = line.Split(',');
                // -------> Console.WriteLine(string.Join(" | ", values));
                Console.WriteLine(values[0] + " / " + values[1] + " / " + values[2] + " / ... ");

                // create an object for each row in the CSV table
                PersonData p = new PersonData(int.Parse(values[0]),values[1],values[2]);
                allData.Add(p);
            }


            Console.WriteLine("***********************************");
            foreach (PersonData person in allData)
            {
                Console.WriteLine(person);
            }

        }

        private class PersonData
        {
            private int personId;
            private string firstName;
            private string familyName;

            public PersonData(int personId, string firstName, string familyName)
            {
                this.personId = personId;
                this.firstName = firstName;
                this.familyName = familyName;
            }

            public override string ToString()
            {
                return string.Format("ID:{0}-Full name: {1} {2} , ...",personId,firstName,familyName);
            }
        }
    }
}