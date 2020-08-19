using System;

namespace Carsales.Application.Cars.Dto
{
    public class CarDto: VehicleDto
    {
        public int NumberOfDoors { get; set; }
        public int NumberOfWheels { get; set; }
        public string BodyType { get; set; }
        public string Engine { get; set; }
    }
}