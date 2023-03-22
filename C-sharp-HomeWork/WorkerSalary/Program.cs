using static WorkerSalary.Salary;

namespace WorkerSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salary salary = new Salary();
            SalaryDelegate salaryDelegate = new SalaryDelegate(salary.IncomeTax);
            salaryDelegate += salary.SocialFee;
            salaryDelegate += salary.StampDuty;
            salaryDelegate += salary.CleanBalance;

            salaryDelegate(200000);
        }
    }
}