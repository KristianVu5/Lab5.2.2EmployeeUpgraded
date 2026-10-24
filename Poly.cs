using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._2._2EmployeeUpgraded
{
    internal class Poly
    {
        Employee[] mas;
        public void load()
        {
            mas = new Employee[2];
            mas[0] = new Employee("Ivan", "Ivanov", 10, 20);
            mas[1] = new Employee("Ivan", "Ivanov", 10, 20);
        }

        public void Calcolatepay()
        {
            foreach(Employee e in mas)
            {
                Console.WriteLine(e.Calculatepay(2));
            }
        }
    }
}
