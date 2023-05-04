

namespace SystemsAndSubsystems
{
    class ElectronicSlicer
    {
        private Motherboard123 motherboard;
        internal float price()
        {
            // TODO
            return 2000 + this.motherboard.price();
        }

        internal void add(Motherboard123 motherboard123)
        {
            // TODO
            this.motherboard = motherboard123;
        }

        internal void add(SlicingComponent slicingComponent)
        {
            // TODO        
        }
    }
}
