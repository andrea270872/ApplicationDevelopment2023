using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mp3PlayerApplication_solution
{
    abstract class State
    {
        abstract internal string description();

        abstract internal string displayInfo();

        abstract internal void goNext(Context context);

        abstract internal void goPrev(Context context);
    }

    class OffState: State
    {
        internal override string description()
        {
            return "off";
        }

        internal override string displayInfo()
        {
            return "-";
        }

        internal override void goNext(Context context)
        {
            context.setState(new StandbyState());
        }

        internal override void goPrev(Context context)
        {
            throw new Exception("State off has no predecessor state.");
        }

    }

    class StandbyState : State
    {
        internal override string description()
        {
            return "standby";
        }

        internal override string displayInfo()
        {
            return "[]";
        }

        internal override void goNext(Context context)
        {
            context.setState(new PlayingState());
        }

        internal override void goPrev(Context context)
        {
            context.setState(new OffState());
        }


    }

    class PlayingState : State
    {
        internal override string description()
        {
            return "playing";
        }

        internal override string displayInfo()
        {
            return "01 song";
        }

        internal override void goNext(Context context)
        {
            throw new Exception("State off has no predecessor state.");
        }

        internal override void goPrev(Context context)
        {
            context.setState(new StandbyState());
        }

    }

}
