using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("**********************************ARAÇLARIMIZ***********************************************");
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var kar in carManager.GetAll())
            {
                Console.WriteLine(kar.Id + "=" + kar.ModelYear.Year + " " + kar.Description + " " + kar.DailyPrice + " TL.");
            }
            Console.WriteLine("**********************************ARAÇLARIMIZ***********************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("DEVAM ETMEK İÇİN BİR TUŞA BASINIZ.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("**********************************YENİ ARAÇ LİSTESİ**********************************************************");

            
            carManager.Add(new Car { Id = 10, BrandId = 4, ColorId = 0, ModelYear = new DateTime(2020, 1, 1), DailyPrice = 350000, Description = "O Km araç" });


            foreach (var kar in carManager.GetAll())
            {
                Console.WriteLine(kar.Id + "=" + kar.ModelYear.Year + " " + kar.Description + " " + kar.DailyPrice + " TL.");
            }

            Console.WriteLine("**********************************YENİ ARAÇ LİSTESİ***********************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("DEVAM ETMEK İÇİN BİR TUŞA BASINIZ.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("**********************************GÜNCELENEN LİSTE**********************************************************");
            Car car = new Car { Id = 10, BrandId = 4, ColorId = 0, ModelYear = new DateTime(2020, 1, 1), DailyPrice = 350000, Description = "O Km otomobil" };
            carManager.Update(car);

            foreach (var kar in carManager.GetAll())
            {
                Console.WriteLine(kar.Id + "=" + kar.ModelYear.Year + " " + kar.Description + " " + kar.DailyPrice + " TL.");
            }
            Console.WriteLine("**********************************GÜNCELENEN LİSTE**********************************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("DEVAM ETMEK İÇİN BİR TUŞA BASINIZ.");
            Console.ReadKey();
            Console.WriteLine("**********************************GÜNCELENEN(silinen) LİSTE**********************************************************");
            Car car1 = new Car { Id = 10, BrandId = 4, ColorId = 0, ModelYear = new DateTime(2020, 1, 1), DailyPrice = 350000, Description = "O Km otomobil" };
            carManager.Delete(car1);
            foreach (var kar in carManager.GetAll())
            {
                Console.WriteLine(kar.Id + "=" + kar.ModelYear.Year + " " + kar.Description + " " + kar.DailyPrice + " TL.");
            }
            Console.WriteLine("**********************************GÜNCELENEN(silinen) LİSTE**********************************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("DEVAM ETMEK İÇİN BİR TUŞA BASINIZ.");
            Console.ReadKey();

        }
    }
}
