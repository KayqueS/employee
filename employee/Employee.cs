using System;
using System.Collections.Generic;
using System.Text;

namespace employee
{
    class Employee
    {
        public string Name;
        public double GrossSalary;
        public double Tax;

        public double NetSalary()
        {
            return GrossSalary - Tax;
        }

        public void IncreaseSalary(double increaseSalary)
        {
            GrossSalary += (GrossSalary * increaseSalary / 100.0); 
        }

        public override string ToString()
        {
            return $"{Name}, $ {NetSalary():F2}";
        }
    }
}
