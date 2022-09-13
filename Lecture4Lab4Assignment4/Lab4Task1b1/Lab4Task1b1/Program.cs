using System;
using System.Collections.Generic;

namespace Lab4Task1b1
{
    class Program
    {
        delegate bool IsPromotable_D(Employee em);


        static void Main(string[] args)
        {
            Console.WriteLine("Tightly Coupled!");
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee() { name = "Shyed", id = 1, salary = 200000.00, experience = 5 });
            employeeList.Add(new Employee() { name = "Shahriar", id = 2, salary = 255000.00, experience = 4 });
            employeeList.Add(new Employee() { name = "Housaini", id = 3, salary = 280000.00, experience = 6 });
            employeeList.Add(new Employee() { name = "MCE 079 05536", id = 4, salary = 160000.00, experience = 7 });
            employeeList.Add(new Employee() { name = "NULL", id = 5, salary = 160000.00, experience = 8 });
            employeeList.Add(new Employee() { name = "Merinda", id = 11, salary = 200000.00, experience = 9 });
            employeeList.Add(new Employee() { name = "Belal", id = 12, salary = 255000.00, experience = 10 });
            employeeList.Add(new Employee() { name = "Roy", id = 13, salary = 280000.00, experience = 16 });
            employeeList.Add(new Employee() { name = "Poly", id = 14, salary = 160000.00, experience = 13 });

           Employee.IsPromotable(employeeList);
            Console.ReadLine();

        }


    }

    class Employee

    {
        public string name { get; set; }
        public int id { get; set; }
        public double salary { get; set; }
        public int experience { get; set; }

        public static void IsPromotable(List<Employee> empList)
        {
            foreach (Employee e in empList)
            {
                if (e.experience >= 4 && e.experience <= 7)
                    Console.WriteLine("Name Of Employee " + e.name + " is promotable");
            }

        }


    }

}
