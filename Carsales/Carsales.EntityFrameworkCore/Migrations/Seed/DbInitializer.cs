using System;
using System.Linq;
using Carsales.Core;

namespace Carsales.EntityFrameworkCore.Migrations.Seed
{
    public static class DbInitializer
    {
        public static void Initialize(CarsalesDbContext context)
        {
            context.Database.EnsureCreated();

            InitBoats(context);
            InitCars(context);
        }

        private static void InitBoats(CarsalesDbContext context) {
            // Look for any Boat.
            if (context.Boats.Any())
            {
                return;   // DB has been seeded
            }

            var boats = new Boat[]
            {
                new Boat { Make = "3D TENDER", Model = "LUX 440", Category = "Leisure", Segment = "Power"},
                new Boat { Make = "4 Seasons", Model = "Wind Seeker SS540", Category = "Leisure", Segment = "Sail"},
                new Boat { Make = "A CLASS", Model = "Paradox Z23 Foiling", Category = "Leisure", Segment = "Power"},
                new Boat { Make = "A CLASS", Model = "CLASSIC", Category = "Leisure", Segment = "Sail"},
                new Boat { Make = "A CLASS", Model = "CATAMARAN", Category = "Leisure", Segment = "Power"},
            };
            foreach (Boat boat in boats)
            {
                context.Boats.Add(boat);
            }
            context.SaveChanges();
        }

        private static void InitCars(CarsalesDbContext context)
        {
            // Look for any Car.
            if (context.Cars.Any())
            {
                return;   // DB has been seeded
            }

            var cars = new Car[]
            {
                new Car { Make = "Mercedes-Benz", Model="CLS-Class", BodyType="Sedan", Engine="2000cc", NumberOfDoors = 4, NumberOfWheels = 4},
                new Car { Make = "Hyundai", Model="Elantra", BodyType="Sedan", Engine="2000cc", NumberOfDoors = 4, NumberOfWheels = 4},
                new Car { Make = "Hyundai", Model="iMax", BodyType="Sedan", Engine="2500cc", NumberOfDoors = 4, NumberOfWheels = 4},
                new Car { Make = "Hyundai", Model="Santa fe", BodyType="SUV", Engine="2000cc", NumberOfDoors = 4, NumberOfWheels = 4},
                new Car { Make = "Audi", Model="A7", BodyType="Sedan", Engine="2500cc", NumberOfDoors = 4, NumberOfWheels = 4},
                new Car { Make = "Audi", Model="A8", BodyType="Sedan", Engine="2500cc", NumberOfDoors = 4, NumberOfWheels = 4}
            };
            foreach (Car car in cars)
            {
                context.Cars.Add(car);
            }
            context.SaveChanges();
        }
    }
}
