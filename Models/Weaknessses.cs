using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models
{
    [Table("Weaknessses")]
    public class Weaknessses
    {
        [Key, Column(Order = 1)]
        public uint PokemonNumber { get; set; }

        [ForeignKey("PokemonNumber")]
        public Pokemons Pokemon { get; set; } = new();

        [Key, Column(Order = 2)]
        public uint TypeId { get; set; }

        [ForeignKey("TypeId")]
        public Types Type { get; set; } = new();
    }
}