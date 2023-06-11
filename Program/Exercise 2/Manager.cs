namespace Exercise2
{
    public class Manager : Employee
    {
        private decimal bonus;

        public Manager(string name, double hourlyWage, decimal bonus) : base(name, hourlyWage)
        {
            this.bonus = bonus;
        }

        public decimal Bonus
        {
            get { return this.bonus; }
            set { this.Bonus = value; }
        }

        public override double CalculateSalary(int hoursWorked)
        {
            base.totalSalary = base.CalculateSalary(hoursWorked) + (double)this.bonus;
            return base.totalSalary;
        }

        public override string ToString()
        {
            return $"name: {this.Name} - salary per hour: {this.SalaryHour} - bonus: {this.bonus} - total salary {this.totalSalary}";
        }
    }
}