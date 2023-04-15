namespace Supermarket_task_solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product("can of beans", "International food", 15.0, 500);
            Console.WriteLine(p.Describe());
            Console.WriteLine("Price per kilo is " + p.PricePerKilo() + " kr");
        }
    }

    public class Product
    {
        private string _name;
        private string _brand;
        private double _price; // in DKK
        private int _weight;   // in grams

        public Product(string name, string brand, double price, int weight)
        {
            this._name = name;
            this._brand = brand;
            this._price = price;
            this._weight = weight;
        }

        public string Describe()
        {
            return String.Format("{0} by {1}, kr {2}, {3} gr.",this._name,this._brand,this._price,this._weight);
        }

        public double PricePerKilo()
        {
            return this._price/this._weight * 1000;
        }
    }
}