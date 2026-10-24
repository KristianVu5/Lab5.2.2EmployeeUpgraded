using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._2._2EmployeeUpgraded
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp;
            emp = new Employee("Sisa", "Ilieva", 28, 100);
            Console.WriteLine("\nVariant 1. " + emp.Calculatepay(40) + "\n");

            SalariedEmployee empsal;
            empsal = new SalariedEmployee("Bozhidar", "Kalinov", 49, 200);
            Console.WriteLine("\nVariant 2." + empsal.Calculatepay(40) + "\n");

            Poly proba = new Poly();
            Console.WriteLine("\nVariant 3.");
            proba.load();
            proba.Calcolatepay();
            Console.ReadLine();

        }
    }
}
