using System;

namespace Task3
{
   class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("John", "Johnson", DateTime.Today.AddYears(-2), Position.Middle);
            SalaryCalculator salaryCalc = new SalaryCalculator();
            Console.WriteLine($"{emp.Name}\n{emp.Surname}\n{emp.Position}\n{salaryCalc.Calculate(emp)}");
        }
    }
}