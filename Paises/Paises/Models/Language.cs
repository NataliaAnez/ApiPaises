namespace Paises.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Language
    {
        [Required]
        [StringLength(maximumLength: 3, ErrorMessage = "Error", MinimumLength = 3)]
        public string iso639_1 { get; set; }
        [Required]
        [StringLength(maximumLength: 3, ErrorMessage = "Error", MinimumLength = 3)]
        public string iso639_2 { get; set; }
        [Key]
        [Required]
        public string name { get; set; }
        [Required]
        public string nativeName { get; set; }
    }
}