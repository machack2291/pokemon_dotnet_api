using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();

        Pokemon GetPokemon(int id);

        Pokemon GetPokemon(String name);

        decimal GetPokemkonRating(int pokeId);

        bool PokemonExists(int pokeId);


    }
}
