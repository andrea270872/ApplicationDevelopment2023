namespace WpfApp1
{
    class Product
    {
        private string _name;
        private string _brand;
        private double _price;

        public Product(string name, string brand, double price)
        {
            this._name = name;
            this._brand = brand;
            this._price = price;
        }

        public override string ToString()
        {
            return "PRD:" + _name + " by " + _brand + "[" + _price + " kr]";
        }
    }
}