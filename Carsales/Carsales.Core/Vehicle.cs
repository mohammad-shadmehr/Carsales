using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Carsales.Core
{
    public abstract class Vehicle: IEntity
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public virtual string Make { get; set; }

        [Required]
        [StringLength(50)]
        public virtual string Model { get; set; }
    }
}
