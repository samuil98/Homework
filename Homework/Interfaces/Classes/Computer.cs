using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Computer : IDamaged
    {
        public static double incomeFromPCs;
        public double SellPrice { get; set; }
        public double BuyingPrice { get; set; }
        public bool Fixed { get; set; }

        public void Fix()
        {
            double cost = BuyingPrice * 0.15;
            Console.WriteLine("Computer is fixed.\nFixing cost: {0}$", cost);
            incomeFromPCs = incomeFromPCs - cost;
            Fixed = true;
        }

        public  void Sell(object computer)
        {
            if (Fixed == false)
            {
                Console.WriteLine("Computer can't be sold, becouse it's not fixed!");
                return;
            }            
            Console.WriteLine("Computer is sold for {0}", SellPrice);
            incomeFromPCs = incomeFromPCs + SellPrice;
            computer = null;

        }
        public Computer(double buyingPrice)
        {
            BuyingPrice = buyingPrice;
            Buy();
            SellPrice = BuyingPrice * 1.4;
        }
        public Computer( double buyingPrice, bool fix):this( buyingPrice)
        {
            Fixed = fix;
        }
        public double Buy()
        {
            return incomeFromPCs = incomeFromPCs - BuyingPrice;
        }
    }
}
