using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Xml.Linq;
#pragma warning disable SYSLIB0011 // IMPORTANT TO AVOID DEPRECATION

namespace SerializableExample
{
    [Serializable]
    public class Book
    {
        public string title = "";
        public string author = "";
        public string url = "";

        public Book(string title, string author, string url)
        {
            this.title = title;
            this.author = author;
            this.url = url;
        }

        public override string ToString()
        {
            return String.Format("Book: '{0}' by {1} [ULR {2}]", this.title,this.author,this.url);
        }
    }
        
    internal class Program
    {   
        static void Main(string[] args)
        {
            Book b1 = new Book("Postsingular","Rudy Rucker", 
                        "https://www.rudyrucker.com/postsingular/cc_downloads/"); // free book!
            Console.WriteLine(b1);

            // proceed to serialize into a file
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, b1); // <-------------- it is done here!
            stream.Close();
            Console.WriteLine("File saved");

            // read it all back
            IFormatter formatter2 = new BinaryFormatter();
            Stream stream2 = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            Book clonedBook = (Book)formatter2.Deserialize(stream2); // <---- here the magic happens!
            stream2.Close();
            Console.WriteLine(clonedBook);
        }
    }
}