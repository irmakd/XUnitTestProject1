using System;

namespace Calculator
{
    public class SalaryCalculator
    {
 
        private const int HoursInYear = 2340;
        //public decimal GetAnnualSalary(decimal hourlyWage)
        //{
        //    return hourlyWage * HoursInYear;
        //}
        public decimal GetAnnualSalary(decimal hourlyWage) =>  hourlyWage * HoursInYear;

        //public decimal GetHourlyWage(decimal annualSalary)
        //{
        //    decimal hourlyWage = annualSalary / HoursInYear;
        //    return hourlyWage;

        //}

        public decimal GetHourlyWage(decimal annualSalary) =>  annualSalary / HoursInYear;
     
    }
}
