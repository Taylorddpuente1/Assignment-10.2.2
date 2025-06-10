// create list of employees, Display all with salary > $5000 and age < 30
using LINQAssignment;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace LINQAssignment
{
   class Employee
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public int Age { get; set; }
        public decimal salary { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Taylor", Age = 26, salary = 150000 },
                new Employee() { Id = 2, Name = "Lily", Age = 56, salary = 2000 },
                new Employee() { Id = 3, Name = "Neil", Age = 30, salary = 5700 },
                new Employee() { Id = 4, Name = "Matthew", Age = 25, salary = 4000 },
                new Employee() { Id = 5, Name = "Paul", Age = 23, salary = 70000 },
            };
            var result = from employee in employees
                             where employee.Age < 30 && employee.salary > 5000
                             select new { employee.Name, employee.Age, employee.salary };
          
            foreach(var employee in result )

                Console.WriteLine($"Name: {employee.Name}, salary: {employee.salary}, Age: {employee.Age}");
        }
    }
}