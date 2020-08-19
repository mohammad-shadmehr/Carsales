using System;
using System.Collections.Generic;
using System.Text;
using Carsales.Core;
using Carsales.EntityFrameworkCore.Repositories;

namespace Carsales.EntityFrameworkCore.EntityFrameworkCore.Repositories
{
    public class CarRepository : EfCoreRepositoryBase<Car, CarsalesDbContext>
    {
        public CarRepository(CarsalesDbContext context) : base(context)
        {
        }
    }
}
