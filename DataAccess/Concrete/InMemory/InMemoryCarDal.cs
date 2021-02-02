using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>{  
            new Car{ Id=1, BrandId=1, ColorId=1, ModelYear=new DateTime(2002,1,1), DailyPrice=50000, Description="güzel araba" },
            new Car{ Id=2, BrandId=1, ColorId=1, ModelYear=new DateTime(2003,1,1), DailyPrice=60000, Description="güzel araba ve iyi" },
            new Car{ Id=3, BrandId=2, ColorId=1, ModelYear=new DateTime(2004,1,1), DailyPrice=70000, Description="güzel,iyi araba" },
            new Car{ Id=4, BrandId=2, ColorId=1, ModelYear=new DateTime(2005,1,1), DailyPrice=80000, Description="güzel,iyi sağlam araba" },
            new Car{ Id=5, BrandId=3, ColorId=2, ModelYear=new DateTime(2006,1,1), DailyPrice=90000, Description="güzel,çok iyi ve sağlam araba" },
            new Car{ Id=6, BrandId=3, ColorId=2, ModelYear=new DateTime(2007,1,1), DailyPrice=100000, Description="acil satlık" },
            new Car{ Id=7, BrandId=3, ColorId=1, ModelYear=new DateTime(2008,1,1), DailyPrice=120000, Description="güzel araba takas olur" },
            new Car{ Id=8, BrandId=4, ColorId=1, ModelYear=new DateTime(2009,1,1), DailyPrice=130000, Description="güzel araba üst modelleriyle takas olur" },
            new Car{ Id=9, BrandId=4, ColorId=3, ModelYear=new DateTime(2010,1,1), DailyPrice=140000, Description="dosta gidecek bir araba" },
            }; 
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

       

        public List<Car> GetAll()
        {
            return _cars;
        }

        

        public List<Car> GetById()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
