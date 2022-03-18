using System.ComponentModel.DataAnnotations;

namespace VinylSpinService.Data
{
    public class Vinyl : BaseEntity
    {
        [Required]
        public Guid ArtistId { get; set; }
        public Artist? Artist { get; set; }
        [Required]
        public DateOnly Released { get; set; }
        [Required]
        public byte Rating { get; set; }
        [Required]
        public string Description { get; set; } = default!;
        [Required]
        public Guid GenreId { get; set; }
        public Genre? Genre { get; set; }
    }
}