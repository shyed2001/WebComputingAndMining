﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Task1_2ab
{
    delegate bool IsPromotable_D(Employee em);
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee() { name = "Merinda", Id = 1, salary = 200000.00, experience = 5 });
            employeeList.Add(new Employee() { name = "Belal", Id = 2, salary = 255000.00, experience = 4 });
            employeeList.Add(new Employee() { name = "Roy", Id = 3, salary = 280000.00, experience = 6 });
            employeeList.Add(new Employee() { name = "Poly", Id = 4, salary = 160000.00, experience = 3 });

            IsPromotable_D p = new IsPromotable_D(Program.IsPromotable);
            Employee.Promotable(employeeList, p);

        }
        public static bool IsPromotable(Employee e)
        {
            if (e.experience >= 5)
                return true;
            else return false;
        }
    }

    class Employee
    {
        public string name { get; set; }
        public int Id { get; set; }
        public double salary { get; set; }
        public int experience { get; set; }

        public static void Promotable(List<Employee> empList, IsPromotable_D promotable)
        {
            foreach (Employee e in empList)
            {
                if (promotable(e))
                    Console.WriteLine(e.name + "is promotable");
            }
            //Not hardcoded//framework reusability    
        }
    }
}
