

namespace SystemsAndSubsystems
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

            ElectronicSlicer es = new ElectronicSlicer();
            Motherboard123 mb = new Motherboard123();
            es.add(mb);
            es.add(new SlicingComponent());
            Console.WriteLine( "motherboard price: " + mb.price() );
            Console.WriteLine( "electronic slicer price: " + es.price());

            SuperDuperGrinder sdg = new SuperDuperGrinder();
            Console.WriteLine( "super duper grinder price: " + sdg.price());



            Console.WriteLine("- press ENTER to finish -");
            Console.ReadLine();
        }
    }
}
