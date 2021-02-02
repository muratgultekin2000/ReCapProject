using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;
        public InMemoryBrandDal()
        {
            _brands = new List<Brand> { 
             new Brand{ BrandId=1, BrandName="ww" },
             new Brand{ BrandId=2, BrandName="reno" },
             new Brand{ BrandId=3, BrandName="hyundai" },
             new Brand{ BrandId=4, BrandName="ford" },
             new Brand{ BrandId=5, BrandName="bmv" },
            };
            
        }
    }
}
