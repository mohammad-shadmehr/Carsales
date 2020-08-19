using System;
using System.ComponentModel.DataAnnotations;

namespace Carsales.Application.Cars.Dto
{
    public class AddOrUpdateCarInput
    {
        public int? Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Make { get; set; }

        [Required]
        [MaxLength(50)]
        public string Model { get; set; }

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