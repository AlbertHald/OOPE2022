

using System.Threading.Tasks.Dataflow;

namespace Lektion2
{
    internal class Employee
    {
        //Constructor
        public Employee(string name, string jobTitle, int salary)
        {
            Name = name;
            JobTitle = jobTitle;
            Salary = salary;
        }

        private string _Name;
        public string Name { set; get; }

        private string _JobTitle;
        public string JobTitle { set; get; } 

        private int _Salary;  
        public int Salary { set; get; }
    }
}
