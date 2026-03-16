using MAUIVoorbeeld_NavigationPages.Klassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MAUIVoorbeeld_NavigationPages
{
    public class PokémonRepository
    {
        public List<Pokémon> GeefAllePokémons()
        {
            return JsonSerializer.Deserialize<List<Pokémon>>(File.ReadAllText($"C:\\Users\\RenaudLeroy\\source\\repos\\DhrLeroy\\Cursus-Csharp\\MAUIVoorbeeld_NavigationPages\\data.json"));
        }

        public void PokémonOpslaan(Pokémon pokémon)
        {
            var pokémons = GeefAllePokémons();
            var pokJson = pokémons.FirstOrDefault(p => p.Naam.Equals(pokémon.Naam, StringComparison.CurrentCultureIgnoreCase));
            pokémons.Remove(pokJson);
            pokémons.Add(pokémon);
            PokémonsOpslaan(pokémons);
        }
        
        private void PokémonsOpslaan(List<Pokémon> pokémons)
        {
            File.WriteAllText($"C:\\Users\\RenaudLeroy\\source\\repos\\DhrLeroy\\Cursus-Csharp\\MAUIVoorbeeld_NavigationPages\\data.json", JsonSerializer.Serialize(pokémons));
        }

        internal void PokémonVerwijderen(Pokémon pokémon)
        {
            var pokémons = GeefAllePokémons();
            var pokJson = pokémons.FirstOrDefault(p => p.Naam.Equals(pokémon.Naam, StringComparison.CurrentCultureIgnoreCase));
            pokémons.Remove(pokJson);
            PokémonsOpslaan(pokémons);
        }
    }
}
