using System;
using System.Collections.Generic;
using Funcionario.Entities;
using System.Globalization;

namespace Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i<= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'n')
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
                else
                {
                    Console.Write("Additional charge: ");
                    double additional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additional));
                }
                       

            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj.Name + " - $ " + obj.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
