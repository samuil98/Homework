using System;

namespace AbstractClass
{
    public abstract class Worker : Person, IPaySalary
    {
        public abstract string WorkingPlace { get; set; }
        public int WorkingHours { get; set; }
        public double Salary { get; set; } //salay per hour


        public abstract void GetFired();
        public void GetTotalSalary(int days)
        {
            Console.WriteLine("Total salary for {0} is: {1}$", days, Salary * WorkingHours * days);
        }

        public double PayRise(double riseRate)
        {
            double newSalary = Salary + Salary * (riseRate / 100);
            Console.WriteLine("New salary is {0}$ per hour", newSalary);
            return newSalary;
        }
    }
}