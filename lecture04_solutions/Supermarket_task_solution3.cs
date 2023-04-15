using System;
using System.Collections.Generic;

namespace Supermarket_task_solution3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> supermarketProducts = new List<Product>();
            supermarketProducts.Add(
                new PackagedFood("can of beans", "International food", 15.0, 500, DateTime.Today.AddDays(10)) );
            supermarketProducts.Add(
                new FruitAndVegetable("a tomato", "FresherStuff", 10, 100, DateTime.Today.AddDays(2)) );
            supermarketProducts.Add(
                new PackagedFood("apple juice", "International food", 7.5, 150,DateTime.Today.AddDays(1)));
            supermarketProducts.Add(
                new PackagedFood("a package of meat", "Meat_R_us", 250, 1500,DateTime.Today.AddDays(15)));
            supermarketProducts.Add(
                new NonFood("t-shirt", "CoolKids(R)", 90.50, 350));

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

    abstract public class Product
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

        public virtual string Describe()
        {
            // this.GetType().Name is the name of the ACTUAL RUNTIME class that the object will have
            return String.Format("| {0} by {1}, kr {2}, {3} gr. | {4}",this._name,this._brand,this._price,this._weight,this.GetType().Name);
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

    abstract public class FreshProduct : Product
    {
        private DateTime _expirationDate;

        // does the actual work - the constructors of the derived classes do nothing ;)
        public FreshProduct(string name, string brand, double price, int weight,DateTime expDate) : base(name, brand, price, weight)
        {
            this._expirationDate = expDate;
        }

        public bool IsCloseToExpiration()
        {
            return (this._expirationDate - DateTime.Today).TotalDays < 3;
        }

        override public string Describe()
        {
            string msg = base.Describe();
            if (IsCloseToExpiration())
            {
                msg = " ON SALE " + msg;
            }
            return msg;
        }
    }
    public class PackagedFood : FreshProduct
    {
        public PackagedFood(string name, string brand, double price, int weight, DateTime expDate) : 
                    base(name, brand, price, weight, expDate)
        {
        }
    }
    public class FruitAndVegetable : FreshProduct
    {
        public FruitAndVegetable(string name, string brand, double price, int weight, DateTime expDate) : 
                    base(name, brand, price, weight, expDate)
        {
        }
    }
    public class NonFood : Product
    {
        public NonFood(string name, string brand, double price, int weight) : base(name, brand, price, weight)
        {
        }
    }

}