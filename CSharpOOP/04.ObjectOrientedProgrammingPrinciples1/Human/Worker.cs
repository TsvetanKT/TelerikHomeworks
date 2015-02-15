namespace Human
{
    using System;

    public class Worker : Human
    {
        public Worker(string firstName, string secondName, int salary, int workHoursPerDay)
            :base(firstName,secondName)
        {
            this.WeekSalary = salary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public int WeekSalary {get; private set;}

        public int WorkHoursPerDay { get; private set; }

        public decimal MoneyPerHour()
        {
            // 5 working days in one week
            return (((decimal)WeekSalary /(decimal)5)/ (decimal)WorkHoursPerDay);
        }
    }
}
