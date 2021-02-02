using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarColorDal : ICarColorDal
    {
        List<CarColor> _carColors;
        public InMemoryCarColorDal()
        {
            _carColors = new List<CarColor> { 
            new CarColor{ ColorId=1, ColorName="beyaz"},
            new CarColor{ ColorId=2, ColorName="mavi"},
            new CarColor{ ColorId=3, ColorName="kırmızı"},
            new CarColor{ ColorId=4, ColorName="siyah"},
            new CarColor{ ColorId=5, ColorName="lacivert"},
            };
            
        }
    }
}
