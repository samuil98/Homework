using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Samrphone :  IBroken, IDamaged
    {
        public static double incomeFromPhones;
        public string Brand { get; set; }
        public double SellPrice { get; set; }
        public double BuyingPrice { get; set; }
        public bool Fixed { get; set; }

        public void Fix()
        {
            double cost = BuyingPrice * 0.15;
            Console.WriteLine("Fixing cost: {0}$", cost);
            incomeFromPhones = incomeFromPhones - cost;
            Fixed = true;
        }

        public  void Sell(object phone)
        {
            if (Fixed == false)
            {
                Console.WriteLine("Smartphone can't be sold, becouse it's not fixed!");
                return;
            }
            Console.WriteLine("Smartphone {0} is sold for {1}", Brand, SellPrice);
            incomeFromPhones = incomeFromPhones + SellPrice;
            phone = null; 
        }

        public double TrowInTrash(object phone)
        {
            Console.WriteLine("Te smartphone {0} is trown in the trash.", Brand);
            phone = null;
            return 0;
        }

        public Samrphone(string brand, double buyingPrice)
        {
            Brand = brand;
            BuyingPrice = buyingPrice;
            Buy();
            SellPrice = BuyingPrice * 1.5;
        }
        public Samrphone(string brand, double buyingPrice, bool fix):this(brand, buyingPrice)
        {
            Fixed = fix;
        }
        public double Buy()
        {
           return incomeFromPhones = incomeFromPhones - BuyingPrice;
        }
    }
}
