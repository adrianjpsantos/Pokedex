using Microsoft.EntityFrameworkCore;
using Pokedex.Models;

namespace Pokedex.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){ }
        
        public DbSet<Abilities> Abilities { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Generation> Generations { get; set; }
        public DbSet<Pokemons> Pokemons { get; set; }
        public DbSet<PokemonAbilities> PokemonAbilities { get; set; }
        public DbSet<PokemonTypes> PokemonTypes { get; set; }
        public DbSet<Types> Types { get; set; }
        public DbSet<Weaknessses> Weaknessses { get; set; }
        
    }
}