using System;
using System.Collections.Generic;

namespace AbstractClass
{
    class Restaurant
    {
        static void Main(string[] args)
        {
            var stuff = new List<Worker>();
            stuff.Add(new Waiter("Gosho", 22, 8));
            stuff.Add(new Waiter("Ivan", 24, 12));
            stuff.Add(new Waiter("Toshko", 25, 8));

            foreach (var worker in stuff)
            {
                worker.GetAJob("StarBuks",3.5);
            }
            stuff[1].PayRise(10);
            stuff[0].GetTotalSalary(15);
            stuff[1].GetTotalSalary(13);
        }
    }
}
