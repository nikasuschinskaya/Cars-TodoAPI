using Cars.WebAPI.Entities.Base;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cars.WebAPI.Entities
{
    [Table("Cars")]
    public class CarEntity : BaseEntity
    {
        [MaxLength(70)]
        [Required]
        public string Brand { get; set; }


        [Required]
        public int Power { get; set; }


        [Column(TypeName = "decimal(18,4)")]
        [Required]
        public decimal Price { get; set; }


        [MinLength(3), MaxLength(30)]
        [Required]
        public string Color { get; set; }
    }
}
