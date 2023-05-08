using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mp3PlayerApplication_solution
{
    class Context
    {
        private State currentState;
        public Context()
        {
            this.currentState = new OffState();
        }

        public void setState(State newState)
        {
            this.currentState = newState;
        }

        public State getState()
        {
            return this.currentState;
        }

        // ---------------------------------------------------

        internal void goNext()
        {
            this.currentState.goNext(this);
        }

        internal void goPrev()
        {
            this.currentState.goPrev(this);
        }
    }


}
