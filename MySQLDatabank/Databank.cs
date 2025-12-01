using Microsoft.EntityFrameworkCore;
using MyRestaurant_Data;
using MyRestaurant_Klassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLDatabank
{
    public class Databank : DbContext, IMenuData
    {
        public DbSet<Menu> Menus { get; set; }

        private void VulDatabank()
        {
            if (Menus.Count() > 0)
                return;

            var pizzabodem = new Ingredient("Pizzabodem", 3f);
            var tomatensaus = new Ingredient("Tomatensaus", 10f);
            var kaas = new Ingredient("Kaas", 13.5f);
            var ham = new Ingredient("Ham", 20f);
            var brood = new Ingredient("Brood", 6.5f);
            var look = new Ingredient("Look", 2f);
            var boter = new Ingredient("Boter", 7.2f);

            var basispizza = new Gerecht("Pizza (normaal)", 12.5f, tomatensaus, kaas, pizzabodem);
            var pizzaham = new Gerecht("Pizza (ham)", 14f, tomatensaus, kaas, ham, pizzabodem);
            var lookbrood = new Gerecht("Lookbrood", 7f, brood, look, boter);

            var menu1 = new Menu("Pizza + lookbrood", 18f, basispizza, lookbrood);
            var menu2 = new Menu("Pizza ham + lookbrood", 19f, pizzaham, lookbrood, basispizza);

            Menus.Add(menu1);
            Menus.Add(menu2);
            SaveChanges();

            var ts = new TimeSpan(1, 30, 0);

            var d = DateTime.Now;

            var ds = d.Add(ts);
        }

        public List<Menu> GeefAlleMenus()
        {
            VulDatabank();
            return Menus.Include(m => m.Gerechten).ThenInclude(g => g.Ingredienten).ToList();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySql(Environment.GetEnvironmentVariable("Default_connectionstring", EnvironmentVariableTarget.User).Replace("#default#", "myrestaurant"),
                new MySqlServerVersion(new Version(9, 3, 0)));
        }
    }
}
