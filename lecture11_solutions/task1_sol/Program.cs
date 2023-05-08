using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluggableDataVisualizations_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * The following code creates a data collection (i.e a SomeData object) and populates it with a few values.
             * The values are then printed.
             * A SomeData object contains a list of integer values (possibly measurements or data about a character in a game, ...),
             * and a maximum, to set a sort of scale for the values.
             * 
             * Your task is to redesign the SomeData class (eventually using other classes or methods), so that the code in (B), (C) and (D) would work.
             * 
             */

            SomeData sd = new SomeData();
            sd.add(1);
            sd.add(2);
            sd.add(3);
            sd.setMax(10);

            Console.WriteLine(sd);

            /*
             * (B)
             * 
             * It should be possible to write:
             */
            sd.setDigitalMode();
            Console.WriteLine(sd); 
            /*
             * Should print:
             * x--------- 
             * xx-------- 
             * xxx------- 
             * 
             * which represent the values in the SomeData object: 1, 2 and 3 over a maximum of 10.
             */

            /*
             * (C)
             * 
             * It should also be possile to set the printing mode back to the simple one of the beginning:
             */
            sd.setStandardMode();
            Console.WriteLine(sd); 
            /*
             * Should print:
             * (1 2 3) over 10
             */

            /*
            * (D)
            * 
            * Finally, it should be possile to set the printing mode to "advanced":
            */
            sd.setAdvancedMode();
            Console.WriteLine(sd);
            /*
             * And this time it should print:
             * 1/10 2/10 3/10 - total: 6 average: 2 
             */


            Console.WriteLine("- press ENTER to finis-");
            Console.ReadLine();
        }
    }
}
