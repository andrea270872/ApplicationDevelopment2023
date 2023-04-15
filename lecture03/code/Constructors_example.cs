namespace Chpt6
{
    class AndroidSmartPhone : SmartPhone
    {
        public AndroidSmartPhone()
        {
            Console.WriteLine("I'm building your android phone... done!");
        }
    }

    abstract class SmartPhone
    {
        public SmartPhone()
        {
            Console.WriteLine("Getting all the parts to make a smartphone...");
        }
    }

    internal class Program
    { 
        static void Main(string[] args)
        {
            AndroidSmartPhone phone1 = new AndroidSmartPhone();
            // what will this write?!
        }
    }

}