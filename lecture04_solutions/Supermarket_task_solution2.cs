using System.Collections.Generic;
using System.Linq;

namespace Supermarket_task_solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> supermarketProducts = new List<Product>();
            supermarketProducts.Add( 
                new Product("can of beans", "International food", 15.0, 500));
            supermarketProducts.Add(
                new Product("a tomato", "FresherStuff", 10, 100));
            supermarketProducts.Add(
                new Product("apple juice", "International food", 7.5, 150));
            supermarketProducts.Add(
                new Product("a package of meat", "Meat_R_us", 250, 1500));
            supermarketProducts.Add(
                new Product("t-shirt", "CoolKids(R)", 90.50, 350));

            Console.WriteLine("----------------");
            foreach (Product product in supermarketProducts)
            {
                Console.WriteLine(product.Describe());
            }
            Console.WriteLine("----------------\n");

            int totalW = 0;
            for (int i = 0;i< supermarketProducts.Count;i++)
            {
                totalW += supermarketProducts[i].GetWeight();
            }
            Console.WriteLine("Total weight of the products: " + totalW + " gr.\n");

            Console.WriteLine("--- Prices ---");
            double totalPrice = 0.0;
            foreach (Product product in supermarketProducts)
            {
                Console.WriteLine(product.GetPrice() + " kr");
                totalPrice += product.GetPrice();
            }

            // OR
            // Console.WriteLine( string.Join(",", supermarketProducts.Select(p=>p.GetPrice() + " kr").ToArray()) );

            Console.WriteLine("Total price is " + totalPrice + " kr");
            Console.WriteLine("Average price is " + totalPrice/ supermarketProducts.Count + " kr");

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

        public int GetWeight()
        {
            return this._weight;
        }

        public double GetPrice()
        {
            return this._price;
        }
    }
}