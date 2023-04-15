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
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Name = "Andrea";
            Console.WriteLine( emp.Name );
        }
    }
}