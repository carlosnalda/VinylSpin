using System.ComponentModel.DataAnnotations;

namespace VinylSpinService.Data
{
    public class Artist : BaseEntity
    {
        [Required]
        public string Name { get; set; } = default!;
        public IEnumerable<Vinyl>? Vinyls { get; set; }
    }
}