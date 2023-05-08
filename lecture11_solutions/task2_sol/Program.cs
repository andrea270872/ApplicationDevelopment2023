using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemsAndSubsystems_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * A machine can be composed of other machines (or devices).
             * And a machine can contain also software components (drivers, OS, apps).
             * 
             * Each machine (or part of machine) has a price. 
             * When a machine M contains other machines, all prices are added to compute the price of M.
             * 
             * Below there are a few examples of machines and parts. 
             * The current implementation of these classes work, but it is very right and not very Object-Oriented.
             * Re-design the classes in this current solution, so that it will be easier:
             * - to compose machines together in a modular way, (i.e. avoid having too many specific classes in your hierarchy),
             * - classes share as many methods as possible (i.e. avoid repetition),
             * - and that it is as simple as possible to add more machines and more parts (flexibility).
             * - it should be possible to define a machine M1 that contains 2 other machines M2 and M3, 
             *   and M2 also contains another machine M4.
             * 
             */

            // Solution: adopt the composite design pattern: http://www.oodesign.com/composite-pattern.html



            CompositeMachine electronicSlicer = new CompositeMachine();
            electronicSlicer.setPrice( 2000 );
            SimpleMachine motherboard123 = new SimpleMachine();
            motherboard123.setPrice(500);
            electronicSlicer.add(motherboard123);
            SimpleMachine slicingComponent = new SimpleMachine();
            slicingComponent.setPrice(100);
            electronicSlicer.add(slicingComponent);

            Console.WriteLine("motherboard price: " + motherboard123.price());
            Console.WriteLine("electronic slicer price: " + electronicSlicer.price());

            CompositeMachine superDuperGrinder = new CompositeMachine();
            superDuperGrinder.setPrice(1000);
            Console.WriteLine("super duper grinder price: " + superDuperGrinder.price());



            // Finally: M1[ M2, M3[M4] ]
            CompositeMachine m1 = new CompositeMachine();
            m1.setPrice(1000);
                SimpleMachine m2 = new SimpleMachine();
                m2.setPrice(200);
                m1.add(m2);
                CompositeMachine m3 = new CompositeMachine();
                m3.setPrice(300);
                m1.add(m3);
                    SimpleMachine m4 = new SimpleMachine();
                    m4.setPrice(40);
                    m3.add(m4);
            Console.WriteLine("M1 price: " + m1.price() ); // should be 1000 +( 200+ (300+40) ) = 1540



            Console.WriteLine("- press ENTER to finish -");
            Console.ReadLine();
        }
    }
}
