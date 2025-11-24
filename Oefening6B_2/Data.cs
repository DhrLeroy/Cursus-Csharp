using LINQ_Games.Klassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening6B_2
{
    public class Data
    {
        public static List<Ontwikkelaar> Ontwikkelaars()
        {
            var rockstar = new Ontwikkelaar("Rockstar Games");
            var naughtyDog = new Ontwikkelaar("Naughty Dog");
            var nintendo = new Ontwikkelaar("Nintendo");
            var cdProjekt = new Ontwikkelaar("CD Projekt Red");
            var bethesda = new Ontwikkelaar("Bethesda Game Studios");
            var valve = new Ontwikkelaar("Valve");

            var ellie = new Personage("Ellie", "Held", "Weesmeisje immuun voor de infectie.", 14, "Stealth Kill", true);
            var joel = new Personage("Joel", "Held", "Geslepen overlever die Ellie begeleidt.", 48, "Survival", true);
            var tess = new Personage("Tess", "NPC", "Joels partner in het smokkelen.", 40, "Onderhandeling", false);

            var marioPers = new Personage("Mario", "Held", "Plumber en held van het Mushroom Kingdom.", 40, "Jump & Cappy", true);
            var peach = new Personage("Princess Peach", "NPC", "Doelwit van Bowser's plannen.", 28, "", false);
            var bowser = new Personage("Bowser", "Slechterik", "Rivaal van Mario.", 50, "Shell Slam", false);


            var ontwikkelaars = new List<Ontwikkelaar> { rockstar, naughtyDog, nintendo, cdProjekt, bethesda, valve };

            var rdr2 = new Game("Red Dead Redemption 2", "Action-Adventure", TimeSpan.FromHours(60), new DateTime(2018, 10, 26), "PlayStation", 9.7, "Red Dead", new[] { "Engels" });
            rdr2.VoegPersonageToe(new Personage("Arthur Morgan", "Held", "Outlaw en hoofdpersoon van het verhaal.", 36, "Sharpshooter", true));
            rdr2.VoegPersonageToe(new Personage("Dutch van der Linde", "Slechterik", "Leider van de Van der Linde gang.", 40, "Leiderschap", false));
            rdr2.VoegPersonageToe(new Personage("Sadie Adler", "NPC", "Wraakzuchtige weduwe en bondgenoot.", 30, "Wraak", false));
            rdr2.VoegAchievementToe(new Achievement("Lending a Hand", "Voltooi alle optionele missies.", 5, false));
            rdr2.VoegAchievementToe(new Achievement("Bounty Hunter", "Vang alle voortvluchtigen levend.", 3, false));
            rdr2.VoegAchievementToe(new Achievement("Wildlife Photographer", "Maak foto's van 30 diersoorten.", 2, false));
            rockstar.Games.Add(rdr2);

            var gta5 = new Game("Grand Theft Auto V", "Action", TimeSpan.FromHours(35), new DateTime(2013, 9, 17), "PC", 9.5, "Grand Theft Auto", new[] { "Engels" });
            gta5.VoegPersonageToe(new Personage("Michael De Santa", "Held", "Voormalig bankovervaller.", 45, "Bullet Time", true));
            gta5.VoegPersonageToe(new Personage("Trevor Philips", "Held", "Onvoorspelbare crimineel.", 40, "Rage Mode", true));
            gta5.VoegPersonageToe(new Personage("Franklin Clinton", "Held", "Goede chauffeur", 25, "Slowmotion driver", true));
            gta5.VoegPersonageToe(new Personage("Lester Crest", "NPC", "Mastermind achter de overvallen.", 38, "Hacker", false));
            gta5.VoegAchievementToe(new Achievement("Criminal Mastermind", "Voltooi alle heists zonder dood te gaan.", 5, true));
            rockstar.Games.Add(gta5);

            var tlou1 = new Game("The Last of Us Part I", "Action-Adventure", TimeSpan.FromHours(15), new DateTime(2022, 9, 2), "PlayStation", 9.4, "The Last of Us", new[] { "Engels" });
            tlou1.VoegPersonageToe(ellie);
            tlou1.VoegPersonageToe(joel);
            tlou1.VoegPersonageToe(tess);
            tlou1.VoegAchievementToe(new Achievement("No Matter What", "Voltooi het verhaal op elk niveau.", 2, false));
            tlou1.VoegAchievementToe(new Achievement("Crafting Master", "Maak elk type wapen en item minstens één keer.", 3, false));
            tlou1.VoegAchievementToe(new Achievement("Explorer", "Vind alle artefacten en Firefly-pendels.", 2, false));

            naughtyDog.Games.Add(tlou1);

            var tlou2 = new Game("The Last of Us Part II", "Action-Adventure", TimeSpan.FromHours(25), new DateTime(2020, 6, 19), "PlayStation", 9.3, "The Last of Us", new[] { "Engels" });
            tlou2.VoegPersonageToe(ellie);
            tlou2.VoegPersonageToe(new Personage("Abby", "Slechterik", "Soldaat van de WLF, moreel complex.", 22, "Strength", false));
            tlou2.VoegPersonageToe(joel);
            tlou2.VoegAchievementToe(new Achievement("Survival Expert", "Upgrade alle vaardigheden.", 3, false));
            tlou2.VoegAchievementToe(new Achievement("Stealth Assassin", "Elimineer 15 vijanden zonder gedetecteerd te worden.", 3, false));
            tlou2.VoegAchievementToe(new Achievement("Archivaris", "Verzamel alle trainingsmanuals.", 2, false));

            naughtyDog.Games.Add(tlou2);

            var uncharted4 = new Game("Uncharted 4: A Thief's End", "Adventure", TimeSpan.FromHours(15), new DateTime(2016, 5, 10), "PlayStation", 7.4, "Uncharted", new[] { "Engels" });
            uncharted4.VoegPersonageToe(new Personage("Nathan Drake", "Held", "Avonturier op zoek naar schatten.", 38, "Climbing & Shooting", true));
            uncharted4.VoegPersonageToe(new Personage("Sam Drake", "NPC", "Nathans broer.", 43, "Backup", false));
            uncharted4.VoegPersonageToe(new Personage("Rafe Adler", "Slechterik", "Rijke erfgenaam met slechte bedoelingen.", 35, "Manipulatie", false));
            uncharted4.VoegAchievementToe(new Achievement("Treasure Hunter", "Vind alle verborgen schatten.", 2, false));
            naughtyDog.Games.Add(uncharted4);

            var botw = new Game("The Legend of Zelda: Breath of the Wild", "Adventure", TimeSpan.FromHours(50), new DateTime(2017, 3, 3), "Switch", 10, "Zelda", new[] { "Engels", "Japans" });
            botw.VoegPersonageToe(new Personage("Link", "Held", "Legendarische held van Hyrule.", 17, "Master Sword", true));
            botw.VoegPersonageToe(new Personage("Zelda", "NPC", "Prinses met magische krachten.", 18, "Sealing Power", false));
            botw.VoegPersonageToe(new Personage("Calamity Ganon", "Slechterik", "Kwaadwillige entiteit.", 1000, "Destructie", false));
            botw.VoegAchievementToe(new Achievement("Hyrule Explorer", "Ontdek elke toren en regio.", 3, false));
            nintendo.Games.Add(botw);

            var mario = new Game("Super Mario Odyssey", "Platformer", TimeSpan.FromHours(12), new DateTime(2017, 10, 27), "Switch", 9.5, "Super Mario", new[] { "Engels", "Japans" });
            mario.VoegPersonageToe(marioPers);
            mario.VoegPersonageToe(peach);
            mario.VoegPersonageToe(bowser);
            mario.VoegAchievementToe(new Achievement("Power Moon Collector", "Verzamel 500 Power Moons.", 4, false));
            mario.VoegAchievementToe(new Achievement("World Traveler", "Bezoek alle koninkrijken.", 2, false));
            mario.VoegAchievementToe(new Achievement("Hat Trick", "Versla drie vijanden tegelijk met Cappy.", 1, false));

            nintendo.Games.Add(mario);

            var galaxy = new Game("Super Mario Galaxy", "Platformer", TimeSpan.FromHours(13), new DateTime(2007, 11, 1), "Wii", 8.2, "Super Mario", new[] { "Engels", "Japans" });
            galaxy.VoegPersonageToe(marioPers);
            galaxy.VoegPersonageToe(peach);
            galaxy.VoegPersonageToe(bowser);
            galaxy.VoegAchievementToe(new Achievement("Power Star Collector", "Verzamel alle 120 Power Stars.", 4, false));
            galaxy.VoegAchievementToe(new Achievement("Comet Conqueror", "Voltooi alle Comet-obstakels.", 3, false));
            galaxy.VoegAchievementToe(new Achievement("Cosmic Collector", "Verzamel 999 star bits.", 2, false));

            nintendo.Games.Add(galaxy);

            var witcher3 = new Game("The Witcher 3: Wild Hunt", "RPG", TimeSpan.FromHours(70), new DateTime(2015, 5, 19), "PC", 8.9, "The Witcher", new[] { "Engels", "Pools" });
            witcher3.VoegPersonageToe(new Personage("Geralt of Rivia", "Held", "Witcher en monsterjager.", 100, "Signs & Swordplay", true));
            witcher3.VoegPersonageToe(new Personage("Ciri", "NPC", "Gevolgd door het lot.", 21, "Teleportatie", false));
            witcher3.VoegPersonageToe(new Personage("Eredin", "Slechterik", "Leider van de Wild Hunt.", 300, "Dimensiereizen", false));
            witcher3.VoegAchievementToe(new Achievement("Full Crew", "Rekruteer alle bondgenoten.", 3, false));
            cdProjekt.Games.Add(witcher3);

            var skyrim = new Game("The Elder Scrolls V: Skyrim", "RPG", TimeSpan.FromHours(100), new DateTime(2011, 11, 11), "PC", 9.2, "The Elder Scrolls", new[] { "Engels" });
            skyrim.VoegPersonageToe(new Personage("Dragonborn", "Held", "Jij, de speler, met drakentalent.", 30, "Shouts", true));
            skyrim.VoegPersonageToe(new Personage("Alduin", "Slechterik", "Wereldeter draak.", 1000, "Firestorm", false));
            skyrim.VoegPersonageToe(new Personage("Lydia", "NPC", "Jouw huisbewaker.", 25, "Companion", false));
            skyrim.VoegAchievementToe(new Achievement("Thu'um Master", "Leer alle schreeuwen.", 4, false));
            bethesda.Games.Add(skyrim);

            var hl2 = new Game("Half-Life 2", "Shooter", TimeSpan.FromHours(15), new DateTime(2004, 11, 16), "PC", 6.5, "Half-Life", new[] { "Engels" });
            hl2.VoegPersonageToe(new Personage("Gordon Freeman", "Held", "Stille wetenschapper met een crowbar.", 27, "Gravity Gun", true));
            hl2.VoegPersonageToe(new Personage("Alyx Vance", "NPC", "Bondgenoot en ingenieur.", 23, "Hacking", false));
            hl2.VoegPersonageToe(new Personage("Dr. Breen", "Slechterik", "Overheerser van de aarde.", 60, "Propaganda", false));
            hl2.VoegAchievementToe(new Achievement("Lambda Locator", "Vind alle Lambda caches.", 2, false));
            valve.Games.Add(hl2);

            var portal2 = new Game("Portal 2", "Puzzle", TimeSpan.FromHours(10), new DateTime(2011, 4, 19), "PC", 7.2, "Portal", new[] { "Engels" });
            portal2.VoegPersonageToe(new Personage("Chell", "Held", "Zwijgende testsubject.", 27, "Portal Gun", true));
            portal2.VoegPersonageToe(new Personage("GLaDOS", "Slechterik", "Sarkastische AI.", 999, "Sarcasme & Laser", false));
            portal2.VoegPersonageToe(new Personage("Wheatley", "NPC", "Onhandige hulp-AI.", 1, "Verwarring", false));
            portal2.VoegAchievementToe(new Achievement("Pit Boss", "Laat GLaDOS je begeleiden.", 3, false));
            valve.Games.Add(portal2);

            tlou1.VoegAchievementToe(new Achievement("Crafting Master", "Maak elk type wapen en item minstens één keer.", 3, false));
            tlou1.VoegAchievementToe(new Achievement("Explorer", "Vind alle artefacten en Firefly-pendels.", 2, false));


            return ontwikkelaars;
        } 
    }
}
