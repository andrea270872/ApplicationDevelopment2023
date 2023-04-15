namespace Employee_Task
{
    class Employee
    {
        public string Address { get; set; } = "Someplace 1,Kolding";
        private int _empID;
        private string _password;
        public string Name { get; set; } = "Unnamed";
        public string LoginName { get; set; }
        public string Department { get; set; }


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

        public Employee(int empId,string loginName, string password,
                        string department, string name)
        {
            _empID = empId;
            LoginName = loginName;
            Password = password;
            Department = department;
            Name = name;
        }
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

            Console.WriteLine(emp.Address); 
            emp.Address = "SomeOtherPlace 2,Vejle";
            Console.WriteLine(emp.Address);
        }
    }
}