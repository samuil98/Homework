using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Computer : ISold, IDamaged
    {
        public static double incomeFromPCs;
        public double SellPrice { get; set; }
        public double BuyingPrice { get; set; }
        public bool Fixed { get; set; }

        public void Fix()
        {
            double cost = BuyingPrice * 0.15;
            Console.WriteLine("omputer is fixed.\nFixing cost: {0}$", cost);
            incomeFromPCs = incomeFromPCs - cost;
        }

        public  void Sell(object computer)
        {

            SellPrice = BuyingPrice * 1.5;
            Console.WriteLine("Computer is sold for {0}", SellPrice);
            incomeFromPCs = incomeFromPCs + SellPrice;
            computer = null;

        }
        public Computer(double buyingPrice)
        {
            BuyingPrice = buyingPrice;
            BuyComputer();
        }
        public Computer( double buyingPrice, bool fix):this( buyingPrice)
        {
            Fixed = fix;
        }
        public double BuyComputer()
        {
            return incomeFromPCs = incomeFromPCs - BuyingPrice;
        }
    }
}
