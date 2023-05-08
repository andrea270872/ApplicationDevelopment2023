using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PluggableDataVisualizations_solution
{
    abstract class Strategy
    {
        internal abstract string generateString(SomeData data);
    }

    class StandardStrategy : Strategy
    {
        internal override string generateString(SomeData data)
        {
            string s = "(";
            foreach (int value in data.myData)
            {
                s += value + " ";
            }
            s += ") over " + data.max;
            return s;
        }
    }

    class DigitalStrategy : Strategy
    {
        internal override string generateString(SomeData data)
        {
            string s = "";
            foreach (int value in data.myData)
            {
                for (int i = 0; i < data.max; i++)
                {
                    if (i<=value)
                        s += "x";
                    else
                        s += "-";
                }
                s += "\n"; // new line
            }
            s += "";
            return s;
        }
    }

    class AdvancedStrategy : Strategy
    {
        internal override string generateString(SomeData data)
        {
            int tot = 0;
            string s = "";
            foreach (int value in data.myData)
            {
                s += value + "/" + data.max + " ";
                tot += value;
            }
            
            s += " total:" + tot;
            s += " average:" + (tot / data.myData.Count);

            return s;
        }
    }

}
