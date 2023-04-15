using System.Xml.Linq;

namespace Employee_Task
{
    class Employee
    {
        private int _empID;
        private string _loginName;
        private string _password;
        private string _department;
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int EmployeeID
        {
            get { return _empID; }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (value.Length >= 6)
                {
                    _password = value;
                }
                else
                {
                    throw new Exception("Password must be at least 6 characters");
                }
            }
        }

        public string LoginName
        {
            get { return _loginName; }
            set { _loginName = value; }
        }
        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }

        public int DefineEmployee(string loginName, string password,
                        string department, string name)
        {
            _empID = 3;         // here this is OK, because INSIDE the class!
            LoginName = loginName;
            Password = password;
            Department = department;
            Name = name;

            // Eventually this data can be saved to a database
            // ...

            return _empID;
        }

        // overload the method!
        public int DefineEmployee(string department, string name)
        {
            _empID = 3;         // here this is OK, because INSIDE the class!
            LoginName = "the_login";
            Password = "the_password";
            Department = department;
            Name = name;

            // Eventually this data can be saved to a database
            // ...

            return _empID;
        }

        public Employee(int empId,string loginName, string password,
                        string department, string name)
        {
            _empID = empId;
            LoginName = loginName;
            Password = password;
            Department = department;
            Name = name;
        }

        // overload of the Employee constructor
        public Employee() { }
    }

    internal class Program
    { 
        static void Main(string[] args)
        {
            Employee emp = new Employee(3,"abc", "XXX123!", "SillyWalks", "Andrea");
            Console.WriteLine(emp.LoginName);
            Console.WriteLine(emp.Password);
            Console.WriteLine(emp.Department);
            Console.WriteLine(emp.Name);
            Console.WriteLine("The ID of this employee is " + emp.EmployeeID);

            Console.WriteLine("------------------------------");
            Employee anotherEmp = new Employee();
            anotherEmp.DefineEmployee("Used Cars", "Bob");
            Console.WriteLine(anotherEmp.Name);
            Console.WriteLine(anotherEmp.Department);
        }
    }
}