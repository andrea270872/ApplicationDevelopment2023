namespace Employee_Task
{
    class Employee
    {
        private int _empID;
        private string _loginName;
        private string _password;
        private string _department;
        private string _name;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            // emp._empId = 1; // ERROR!
            Console.WriteLine( emp );
        }
    }
}