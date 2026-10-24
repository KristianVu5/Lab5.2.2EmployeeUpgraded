using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._2._2EmployeeUpgraded
{
    internal class Employee
    {
        protected string firstName;
        protected string lastName;
        protected int age;
        protected double payrate;

        public Employee (string firstName, string lastName, int age, double payrate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.payrate = payrate;
        }

        public virtual double Calculatepay(int hoursworked)
        {
            payrate = payrate * (double)hoursworked;
            return payrate;
        }
    }
}
