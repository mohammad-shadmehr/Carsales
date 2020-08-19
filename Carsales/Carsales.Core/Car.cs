using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Carsales.Core
{
    public class Car: Vehicle
    {
        [Required]
        public int NumberOfDoors { get; set; }

        [Required]
        public int NumberOfWheels { get; set; }

        [Required]
        public string BodyType { get; set; }

        [Required]
        public string Engine { get; set; }
    }
}
