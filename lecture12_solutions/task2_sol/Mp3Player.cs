using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mp3PlayerApplication_solution
{
    class Mp3Player
    {
        Context myContext;

        public Mp3Player()
        {
            this.myContext = new Context();
        }

        internal string description()
        {
            return myContext.getState().description();
        }

        internal string displayInfo()
        {
            return myContext.getState().displayInfo();
        }

        internal void switchOn()
        {
            this.myContext.goNext();
        }

        internal void playSong()
        {
            this.myContext.goNext();
        }

        internal void stop()
        {
            this.myContext.goPrev();
        }

        internal void switchOff()
        {
            this.myContext.goPrev();
        }
    }

}
