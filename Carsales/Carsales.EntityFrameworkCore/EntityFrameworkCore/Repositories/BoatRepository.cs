using System;
using System.Collections.Generic;
using System.Text;
using Carsales.Core;
using Carsales.EntityFrameworkCore.Repositories;

namespace Carsales.EntityFrameworkCore.EntityFrameworkCore.Repositories
{
    public class BoatRepository : EfCoreRepositoryBase<Boat, CarsalesDbContext>
    {
        public BoatRepository(CarsalesDbContext context) : base(context)
        {
        }
    }
}
