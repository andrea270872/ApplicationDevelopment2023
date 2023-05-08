using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PluggableDataVisualizations_solution
{
    class SomeData
    {
        public List<int> myData { get; set; }

        public int max { get; set; }

        Strategy strategy;

        public SomeData()
        {
            this.myData = new List<int>();
            this.max = 0;

            this.strategy = new StandardStrategy();
        }

        internal void add(int p)
        {
            this.myData.Add(p);
        }

        public override string ToString()
        {
            // delegate all the word to the current strategy
            return this.strategy.generateString(this);
        }

        internal void setMax(int newMax)
        {
            this.max = newMax;
        }

        internal void setDigitalMode()
        {
            this.strategy = new DigitalStrategy();
        }

        internal void setStandardMode()
        {
            this.strategy = new StandardStrategy();
        }

        internal void setAdvancedMode()
        {
            this.strategy = new AdvancedStrategy();
        }
    }
}
