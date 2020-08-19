using System;
using System.ComponentModel.DataAnnotations;

namespace Carsales.Application
{
    public class VehicleDto
    {
        public int Id { get; set; }
        public virtual string Make { get; set; }
        public virtual string Model { get; set; }
    }
}