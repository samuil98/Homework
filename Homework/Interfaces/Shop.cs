using System;
using System.Collections.Generic;

namespace Interfaces
{
    public class Shop
    {
        
        static void Main(string[] args)
        {
            var newArticles = new List<Computer>();
            newArticles.Add(new Computer(1000));
            newArticles.Add(new Computer(800,true));
            foreach (var computer in newArticles)
            {
                Console.WriteLine("Computer is bought fo {0}", computer.BuyingPrice);
                computer.Sell(computer);
            }
            newArticles[0].Sell(newArticles[0]);

            var demagedPhones = new List<Samrphone>();
            demagedPhones.Add(new Samrphone("Nokia",600));
            demagedPhones.Add(new Samrphone("Samsung", 750));
            foreach (var phone in demagedPhones)
            {
                phone.Fix();
                phone.Sell(phone);
            }

            var brokenCars = new List<Car>();
            brokenCars.Add(new Car("Jigula", 800));
            brokenCars.Add(new Car("Lada", 600));
            foreach (var car in brokenCars)
            {
                car.TrowInTrash(car);
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
