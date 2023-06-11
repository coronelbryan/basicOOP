using System.Collections.Generic;

namespace Exercise2
{
    public class Company
    {
        private string name;
        private List<Employee> employees;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public List<Employee> Employees
        {
            get { return this.employees; }
            set { this.employees = value; }
        }

        public Company() { }

        public void AddEmployee(Employee employee) => this.employees.Add(employee);

        public void DisplayEmployees()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}