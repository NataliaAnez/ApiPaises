namespace Paises.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class RegionalBloc
    {
        [Key]
        public string acronym { get; set; }
        [Required]
        public string name { get; set; }
        public List<string> otherAcronyms { get; set; }
        public List<string> otherNames { get; set; }
    }

}