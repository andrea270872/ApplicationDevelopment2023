using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModularMachines_solution
{
    abstract class Robot
    {
        virtual internal string describeRoles()
        {
            return "";
        }

        virtual internal string describeMotions()
        {
            return "";
        }
    }

    class BasicRobot: Robot
    {
        internal override string describeRoles()
        {
            return "aBasicRobot";
        }

        internal override string describeMotions()
        {
            return "aBasicRobot";
        }
    }
}
