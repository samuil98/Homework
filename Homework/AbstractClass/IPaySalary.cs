using System;


interface IPaySalary
{
    public double Salary { get; set; }

    double PayRise(double riseRate);
   
}
