using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._2._2EmployeeUpgraded
{
    internal class SalariedEmployee : Employee
    {
        public SalariedEmployee(string firstName, string lastName, int age, double payrate)
            : base(firstName, lastName, age, payrate) { }

        public override double Calculatepay(int hoursworked)
        {
            payrate = payrate * (double)hoursworked * 2;
            return payrate;
        }
    }
}
