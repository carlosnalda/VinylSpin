using System.ComponentModel.DataAnnotations;

namespace VinylSpinService.Data
{
    public class Genre : BaseEntity
    {
        [Required]
        public string Name { get; set; } = default!;
        public IEnumerable<Vinyl>? Vinyls { get; set; }
    }
}