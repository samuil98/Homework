using System;
using System.Collections.Generic;

namespace Interfaces
{
    public class Shop
    {
        
        static void Main(string[] args)
        {
            var newArticles = new List<ISold>();
            newArticles.Add(new Car("golf",2000));
            newArticles.Add(new Computer(800,true));
            foreach (var article in newArticles)
            {
                article.Sell(article);
            }

            var demagedArticles = new List<IDamaged>();
            demagedArticles.Add(new Samrphone("Nokia",600));
            demagedArticles.Add(new Computer(750));

            foreach (var article in demagedArticles)
            {
                article.Sell(article);
                article.Fix();
                article.Sell(article);
            }
            
            var brokenArticles = new List<IBroken>();
            brokenArticles.Add(new Samrphone("Samsung", 800));
            brokenArticles.Add(new Car("Lada", 800));
            foreach (var article in brokenArticles)
            {
                article.TrowInTrash(article);
            }

            GetTotalIncome();
        }

        public static double GetTotalIncome()
        {
            double income = Car.incomeFromCars + Samrphone.incomeFromPhones + Computer.incomeFromPCs;
            Console.WriteLine("Total income is {0}", income);
            return income;
        }
    }
}
