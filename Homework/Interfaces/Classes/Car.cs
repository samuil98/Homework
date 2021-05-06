using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Car : IBroken, ISold
    {
        public static double incomeFromCars = 0;
        public string Model { get; set; }
        public double SellPrice { get; set; }
        public double BuyingPrice { get; set; }

        public void Sell(object car)
        {

            SellPrice = BuyingPrice * 1.2;
            Console.WriteLine("Car is sold for {0}", SellPrice);
            incomeFromCars = incomeFromCars + SellPrice;
            car = null;
        }
        public Car(string model, double buyingPrice)
        {
            Model = model;
            BuyingPrice = buyingPrice;
        }
        public double TrowInTrash(object car)
        {
            double incomeFromScrap = BuyingPrice / 10;
            Console.WriteLine("Car is already gone there are {0}$ icome from scraps.", incomeFromScrap);            
            car = null;
            return incomeFromCars = incomeFromCars + incomeFromScrap;
        }
       
    }
}
