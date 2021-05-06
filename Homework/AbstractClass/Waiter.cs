using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Waiter : Worker
    {
        public override string WorkingPlace { get; set; }
        public override string Name { get; set; }

        public override void GetAJob(string company, double salary)
        {
            WorkingPlace = company;
            Salary = salary;

            Console.WriteLine("{0} is now working at {1},\nwith startnig salary: {2} per hour ", Name, WorkingPlace, Salary);
            Console.WriteLine("{0} is hired on {1} hour workig day", Name, WorkingHours);
        }

        public override void GetFired()
        {
            WorkingPlace = "none";
            Salary = 0;
        }
        public Waiter(string name, int age,int workingHours)
        {
            Name = name;
            Age = age;
            WorkingPlace = "none";
            Salary = 0;
            WorkingHours = workingHours;
        }
    }
}
