using System.ComponentModel.DataAnnotations;

namespace Cars.WebAPI.Entities.Base
{
    public abstract class BaseEntity
    {
        [Required]
        public int Id { get; set; }
    }
}
