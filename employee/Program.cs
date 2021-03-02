using System;

namespace employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee x = new Employee();

            Console.Write($"Name: ");
            x.Name = Console.ReadLine();
            Console.Write($"Gross salary: ");
            x.GrossSalary = double.Parse(Console.ReadLine());
            Console.Write($"Tax: ");
            x.Tax = double.Parse(Console.ReadLine());

            Console.WriteLine($"Employee: {x}");

            Console.Write("Enter the percentage to increase the salary: ");
            double increase = double.Parse(Console.ReadLine());
            x.IncreaseSalary(increase);

            Console.WriteLine($"Updated data: {x}");
        }
    }
}
