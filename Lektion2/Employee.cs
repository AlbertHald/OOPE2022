

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
        
        //Name of employee
        private string _Name;
        public string Name { set; get; }
        
        //Jobtitle
        private string _jobTitle;
        public string JobTitle { set; get; } 
        
        //Salary
        private int _salary;  
        public int Salary { set; get; }

        //Calculates the yearly salary of an employee
        private protected int CalculateYearlySalary(int salary)
        {
            return salary * 12;
        }
    }
}
