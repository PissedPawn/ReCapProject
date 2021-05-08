using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Car car = new Car()
            {
                Id = 165,
                BrandId = 65,
                ColorId = 2,
                DailyPrice = 200,
                Description = "benz sdkfhb",
                ModelYear = 2019
            };

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }

            //add new car
           // carManager.Add(car);
            Console.WriteLine("---------------------Added a new car");


            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }

            //delete a car - Prado a743
            Car carToDelete = new Car() { Id = 19, BrandId = 2, ColorId = 2, DailyPrice = 1500, ModelYear = 2015, Description = "Prado a743" };

            carManager.Delete(car);
            Console.WriteLine("-----------------------Deleted : Prado a743");

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }

            //update audi a763s daily price

            Car carToUpdate = new Car() { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 2000, ModelYear = 2015, Description = "Audi a876" };
            carManager.Update(carToUpdate);

            Console.WriteLine("-----------------------Updated : Audi a763 to audi a876");

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }

            //Get By Id 

            //Console.WriteLine("-----------------------Get by Id if exists in database");
            //Console.WriteLine(carManager.GetById(1).Description);

            //////






        }
    }
}
