using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularMachines_solution
{
    abstract class RobotDecorator : Robot
    {
        protected Robot robot;

        public RobotDecorator(Robot theRobot)
        {
            this.robot = theRobot;
        }

        internal override string describeRoles()
        {
            if (this.robot != null)
            {
                return this.robot.describeRoles();
            }
            return "noRole";
        }

        internal override string describeMotions()
        {
            if (this.robot != null)
            {
                return this.robot.describeMotions();
            }
            return "noMotion";
        }
    }

    class Finder: RobotDecorator
    {

        public Finder(Robot theRobot) : base(theRobot) { }

        internal override string describeRoles()
        {
            return this.robot.describeRoles() + " finder";
        }
    }

    class Walk : RobotDecorator
    {

        public Walk(Robot theRobot) : base(theRobot) { }

        internal override string describeMotions()
        {
            return this.robot.describeMotions() + " walk";
        }
    }

    class Fly : RobotDecorator
    {

        public Fly(Robot theRobot) : base(theRobot) { }

        internal override string describeMotions()
        {
            return this.robot.describeMotions() + " fly";
        }
    }
}
