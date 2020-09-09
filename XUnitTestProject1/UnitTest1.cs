using Calculator;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Hazırlama - Arrange
            SalaryCalculator salaryCalculator = new SalaryCalculator();

            //Hareket - Act
            decimal annualSalary = salaryCalculator.GetAnnualSalary(40);
            //İddia etme - Assert
            Assert.Equal(93600, annualSalary);

        }
        [Fact]
        public void Test2()
        {
            //Hazırlama - Arrange
            SalaryCalculator salaryCalculator = new SalaryCalculator();

            //Hareket - Act
            decimal hourlyWage = salaryCalculator.GetHourlyWage(93600);
            //İddia etme - Assert
            Assert.Equal(40, hourlyWage);

        }
    }
}
