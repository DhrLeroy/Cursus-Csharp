using Films.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films.Data
{
    public class Data
    {
        public static List<Reeks> GetData()
        {
            var lotr = new Reeks("The Lord of the Rings", new List<Film>());
            var starWars = new Reeks("Star Wars", new List<Film>());
            var theMatrix = new Reeks("The Matrix", new List<Film>());
            var theHobbit = new Reeks("The Hobbit", new List<Film>());

            var hugoweaving = new Acteur("Weaving", "Hugo");
            var ianHolm = new Acteur("Holm", "Ian");
            var martinFreeman = new Acteur("Freeman", "Martin");
            var orlando = new Acteur("Bloom", "Orlando");

            // Shared roles
            var frodo = new Rol("Frodo Baggins", new Acteur("Wood", "Elijah"));
            var gandalf = new Rol("Gandalf", new Acteur("McKellen", "Ian"));
            var sam = new Rol("Samwise Gamgee", new Acteur("Astin", "Sean"));
            var aragorn = new Rol("Aragorn II", new Acteur("Mortensen", "Viggo"));
            var elrond = new Rol("Elrond", hugoweaving);
            var bilboLotr = new Rol("Bilbo Baggins", ianHolm);
            var legolas = new Rol("Legolas Greenleaf", orlando);

            var luke = new Rol("Luke Skywalker", new Acteur("Hamill", "Mark"));
            var vader = new Rol("Darth Vader", new Acteur("Prowse", "David"), new Acteur("Jones", "James Earl"));

            var neo = new Rol("Neo", new Acteur("Reeves", "Keanu"));
            var morpheus = new Rol("Morpheus", new Acteur("Fishburne", "Laurence"));
            var smith = new Rol("Agent Smith", hugoweaving);

            var bilboUnexpectedJourney = new Rol("Bilbo Baggins", ianHolm, martinFreeman);
            var bilboHobbit = new Rol("Bilo Baggins", martinFreeman);
            var thorin = new Rol("Thorin Oakenshield", new Acteur("Armitage", "Richard"));

            // Lord of the Rings Films
            var fotr = new Film(lotr, "The Fellowship of the Ring", "Peter Jackson", 2001, frodo, gandalf, sam, aragorn, elrond, bilboLotr, legolas);
            var tt = new Film(lotr, "The Two Towers", "Peter Jackson", 2002, frodo, gandalf, sam, aragorn, elrond, legolas);
            var rotk = new Film(lotr, "The Return of the King", "Peter Jackson", 2003, frodo, gandalf, sam, aragorn, elrond, bilboLotr, legolas);
            lotr.Films.AddRange(new[] { fotr, tt, rotk });

            // Star Wars Films
            var sw4 = new Film(starWars, "A New Hope", "George Lucas", 1977, luke, vader);
            var sw5 = new Film(starWars, "The Empire Strikes Back", "George Lucas", 1980, luke, vader);
            var sw6 = new Film(starWars, "Return of the Jedi", "George Lucas", 1983, luke, vader);
            starWars.Films.AddRange(new[] { sw4, sw5, sw6 });

            // The Matrix Films
            var matrix1 = new Film(theMatrix, "The Matrix", "Lana & Lilly Wachowski", 1999, neo, morpheus, smith);
            var matrix2 = new Film(theMatrix, "The Matrix Reloaded", "Lana & Lilly Wachowski", 2003, neo, morpheus, smith);
            var matrix3 = new Film(theMatrix, "The Matrix Revolutions", "Lana & Lilly Wachowski", 2003, neo, morpheus, smith);
            theMatrix.Films.AddRange(new[] { matrix1, matrix2, matrix3 });
            
            // The Hobbit Films
            var unexpectedJourney = new Film(theHobbit, "An Unexpected Journey", "Peter Jackson", 2012, bilboUnexpectedJourney, gandalf, thorin);
            var desolationSmaug = new Film(theHobbit, "The Desolation of Smaug", "Peter Jackson", 2013, bilboHobbit, gandalf, thorin, legolas);
            var battleFiveArmies = new Film(theHobbit, "The Battle of the Five Armies", "Peter Jackson", 2014, bilboHobbit, gandalf, thorin, legolas);
            theHobbit.Films.AddRange(new[] { unexpectedJourney, desolationSmaug, battleFiveArmies });

            // Link roles to their respective films
            foreach (var film in lotr.Films.Concat(starWars.Films).Concat(theMatrix.Films))
            {
                foreach (var rol in film.Rollen)
                {
                    rol.AddFilm(film);
                }
            }

            // Final list of series
            var filmSeries = new List<Reeks> { lotr, starWars, theMatrix, theHobbit };

            return filmSeries;
        }
    }
}
