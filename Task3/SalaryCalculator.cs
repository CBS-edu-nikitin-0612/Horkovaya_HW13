using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class SalaryCalculator
    {
        private double baseSalary = 100;
        private double PositionFactorCalculate(Position position)
        {
            switch (position)
            {
                case Position.Junior:
                    return 1.25;
                case Position.Middle:
                    return 1.5;
                case Position.Senior:
                    return 1.75;
                default:
                    return 1;
            }
        }
        private double ExperienceFactorCalculate(DateTime registrationDate)
        {
            var expMonth = (DateTime.Today.Year - registrationDate.Year) * 12 +
                DateTime.Today.Month - registrationDate.Month;
            switch (expMonth)
            {
                case > 60:
                    return 1.75;
                case > 36:
                    return 1.5;
                case > 12:
                    return 1.25;
                default:
                    return 1;
            }
        }
        public double Calculate(Employee emp)
        {
            var posFactor = PositionFactorCalculate(emp.Position);
            var expFactor = ExperienceFactorCalculate(emp.RegistrationDate);
            return baseSalary * posFactor * expFactor * (1 - emp.Tax);
        }
    }
}