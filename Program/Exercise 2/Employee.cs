namespace Exercise2
{
    public class Employee
    {
        private string name;
        private double salaryHour;
        protected double totalSalary;

        public Employee(string name, double salaryHour)
        {
            this.name = name;
            this.salaryHour = salaryHour;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public double SalaryHour
        {
            get
            {
                return this.salaryHour;
            }
            set
            {
                this.salaryHour = value;
            }
        }

        public virtual double CalculateSalary(int hoursWorked)
        {
            this.totalSalary = hoursWorked * salaryHour;
            return this.totalSalary;
        }

        public override string ToString()
        {
            return $"name: {this.name} - salary per hour: {this.SalaryHour} - total salary: {this.totalSalary}";
        }
    }
}