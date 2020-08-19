using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Carsales.Core
{
    public class Boat: Vehicle
    {
        [Required]
        [StringLength(50)]
        public string Segment { get; set; }

        [Required]
        [StringLength(50)]
        public string Category { get; set; }
    }
}
