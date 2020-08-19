using System.ComponentModel.DataAnnotations;

namespace Carsales.Application.Boats.Dto
{
    public class AddOrUpdateBoatInput
    {
        public int? Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Make { get; set; }

        [Required]
        [MaxLength(50)]
        public string Model { get; set; }

        [Required]
        [StringLength(50)]
        public string Segment { get; set; }

        [Required]
        [StringLength(50)]
        public string Category { get; set; }
    }
}