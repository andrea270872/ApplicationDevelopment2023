using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemsAndSubsystems_solution
{
    abstract class Machine
    {
        public float myPrice;
        public string name { get; set; }

        internal virtual float price()
        {
            return this.myPrice;
        }

        internal virtual void setPrice(float price)
        {
            this.myPrice = price;
        }

    }

    class SimpleMachine: Machine
    {
    }

    class Software : SimpleMachine
    {
    }

    class CompositeMachine : Machine
    {
        List<Machine> machines;

        public CompositeMachine()
        {
            this.machines = new List<Machine>();
        }

        internal override float price()
        {
            float price = this.myPrice;
            foreach (Machine m in this.machines) 
            {
                price += m.price();
            }
            return price;
        }

        internal void add(Machine m){
            this.machines.Add(m);
        }
    }

}
