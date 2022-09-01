using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models
{
    [Table("Generation")]
    public class Generation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Por favor, Informe o Nome")]
        [StringLength(20, ErrorMessage = "O Nome deve possuir no máximo 20 caracteres")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Mídia")]
        [Required(ErrorMessage = "Por favor, Informe a Mídia")]
        [StringLength(1, ErrorMessage = "A Mídia deve possuir no máximo 1 caracter")]
        public string Color { get; set; } = string.Empty;
    }
}