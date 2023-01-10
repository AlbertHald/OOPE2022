
namespace Lektion2
{
    internal class Manager : Employee
    {
        public Manager(string name, string jobTitle, int salary, int yearlyBonus) : base(name, jobTitle, salary)
        {
            Name = name;
            JobTitle = jobTitle;
            Salary = salary;
            YearlyBonus = yearlyBonus;
        }
        private int YearlyBonus { get; set; }

        private protected override int CalculateYearlySalary(int salary, int yearlyBonus)
        {
            int result = base.CalculateYearlySalary(Salary);

            return result + YearlyBonus;
        }
    }
}
