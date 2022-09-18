using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Task1_2ab
{
    delegate bool IsPromotable_D(Employee em);
    internal class Lab4Task1_2ab
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab4Task1_2a_b Loosely Coupled, mce 079 05536!");
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee() { name = "Merinda Shyed", Id = 1, salary = 200000.00, experience = 5 });
            employeeList.Add(new Employee() { name = "Belal Shahriar", Id = 2, salary = 255000.00, experience = 4 });
            employeeList.Add(new Employee() { name = "Roy Housaini", Id = 3, salary = 280000.00, experience = 6 });
            employeeList.Add(new Employee() { name = "Poly 007905536", Id = 4, salary = 160000.00, experience = 3 });

            IsPromotable_D p = new IsPromotable_D(Lab4Task1_2ab.IsPromotable);
            Employee.Promotable(employeeList, p);
            Console.ReadLine();

        }
        public static bool IsPromotable(Employee e)
        {
            if (e.experience >= 5) // >4
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
                    Console.WriteLine( " The name of promotable employee is " + e.name);
            }
            //Not hardcoded//framework reusability    
        }
    }
}
