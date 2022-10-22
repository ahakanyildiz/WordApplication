using System.ComponentModel.DataAnnotations;

namespace WordApplication_V1.Entities
{
    public class Word
    {
        
        public Guid Id { get; set; }

        [Required(ErrorMessage ="İngilizce alanı boş geçilemez.")]
        public string EnName { get; set; }

        [Required(ErrorMessage = "Türkçe karşılığı boş geçilemez.")]
        public string TrName { get; set; }

        public string? ImageUrl { get; set; }

    }
}
