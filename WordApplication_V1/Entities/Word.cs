using System.ComponentModel.DataAnnotations;
using WordApplication_V1.Core;

namespace WordApplication_V1.Entities
{
    public class Word : IEntity
    { 
        public Guid Id { get; set; }

        [Required(ErrorMessage ="İngilizce alanı boş geçilemez.")]
        public string EnName { get; set; }

        [Required(ErrorMessage = "Türkçe karşılığı boş geçilemez.")]
        [MinLength(2,ErrorMessage ="En az 2 karakter olmak zorundadır.")]
        public string TrName { get; set; }

        public string? ImageUrl { get; set; }

    }
}
