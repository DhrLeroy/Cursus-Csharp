using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace LINQ_Vluchten
{
    public static class Data
    {

        public static List<Vlucht> GeefVluchten()
        {
            return JsonSerializer.Deserialize<List<Vlucht>>(File.ReadAllText("data.json"));
        }

        private static void GenereerVluchten()
        {
            File.WriteAllText("C:\\Users\\RenaudLeroy\\source\\repos\\DhrLeroy\\Cursus-Csharp\\LINQ_Vluchten\\data.json", JsonSerializer.Serialize(Data.GeefAlleVluchten()));
        }


        private static List<Vlucht> GeefAlleVluchten()
        {
            var rnd = new Random();

            var luchthavens = new List<Luchthaven>
            {
                new() { Naam="Brussels Airport", Afkorting="BRU", Land="België", HoogteZeeniveau=56 },
                new() { Naam="Schiphol", Afkorting="AMS", Land="Nederland", HoogteZeeniveau=-3 },
                new() { Naam="Charles de Gaulle", Afkorting="CDG", Land="Frankrijk", HoogteZeeniveau=119 },
                new() { Naam="Heathrow", Afkorting="LHR", Land="Verenigd Koninkrijk", HoogteZeeniveau=25 },
                new() { Naam="Frankfurt Airport", Afkorting="FRA", Land="Duitsland", HoogteZeeniveau=111 },
                new() { Naam="Madrid Barajas", Afkorting="MAD", Land="Spanje", HoogteZeeniveau=610 },
                new() { Naam="Rome Fiumicino", Afkorting="FCO", Land="Italië", HoogteZeeniveau=5 },
                new() { Naam="Vienna Airport", Afkorting="VIE", Land="Oostenrijk", HoogteZeeniveau=183 },
                new() { Naam="Copenhagen Airport", Afkorting="CPH", Land="Denemarken", HoogteZeeniveau=5 },
                new() { Naam="Oslo Airport", Afkorting="OSL", Land="Noorwegen", HoogteZeeniveau=208 }
            };
            string[] maatschappijen =
            {
                "Brussels Airlines",
                "KLM",
                "Lufthansa",
                "Air France",
                "Ryanair",
                "EasyJet",
                "SAS",
                "ITA Airways"
            };
            
            var vluchten = new List<Vlucht>();

            for (int i = 1; i <= 30; i++)
            {
                Luchthaven van = luchthavens[rnd.Next(luchthavens.Count)];
                Luchthaven naar;

                do
                {
                    naar = luchthavens[rnd.Next(luchthavens.Count)];
                }
                while (naar == van);

                var vlucht = new Vlucht
                {
                    Naam = $"Vlucht {i}",
                    Code = $"FL{i:000}",
                    Maatschappij = maatschappijen[rnd.Next(maatschappijen.Length)],
                    Van = van,
                    Naar = naar,
                    Datum = DateTime.Today
                                .AddDays(rnd.Next(0, 60))
                                .AddHours(rnd.Next(0, 24))
                                .AddMinutes(rnd.Next(0, 60)),
                    Duurtijd = TimeSpan.FromMinutes(rnd.Next(60, 240))
                };

                int aantalPassagiers = rnd.Next(20, 41);

                for (int p = 0; p < aantalPassagiers; p++)
                {
                    vlucht.Passagiers.Add(MaakPassagier());
                }

                vluchten.Add(vlucht);
            }

            return vluchten;
        }

        private static string[] ticketTypes =
{
    "Economy",
    "Economy",
    "Economy",
    "Business",
    "First Class"
};

        private static List<NaamGroep> naamGroepen = new List<NaamGroep>
{
    new()
    {
        Regio = "Belgisch-Nederlands",
        Voornamen =
        {
            "Jan","Emma","Lucas","Noah","Olivia","Liam",
            "Mila","Finn","Sophie","Arthur","Julie",
            "Louis","Lotte","Mats","Elise"
        },
        Familienamen =
        {
            "Peeters","Janssens","Maes","Willems",
            "Claes","Vermeulen","Jacobs",
            "Goossens","Mertens","De Smet"
        }
    },

    new()
    {
        Regio = "Frans",
        Voornamen =
        {
            "Pierre","Paul","Antoine","Étienne",
            "Camille","Chloé","Amélie","Juliette",
            "Mathilde","Raphaël"
        },
        Familienamen =
        {
            "Martin","Bernard","Durand","Petit",
            "Leroy","Moreau","Laurent",
            "Michel","Roux","Girard"
        }
    },

    new()
    {
        Regio = "Engels",
        Voornamen =
        {
            "James","John","Michael","William",
            "David","Emily","Charlotte",
            "Grace","Abigail","Victoria"
        },
        Familienamen =
        {
            "Smith","Johnson","Brown",
            "Taylor","Anderson","Wilson",
            "Moore","White","Harris"
        }
    },

    new()
    {
        Regio = "Duits",
        Voornamen =
        {
            "Lukas","Felix","Jonas",
            "Leon","Tim","Anna",
            "Leonie","Mia","Lena"
        },
        Familienamen =
        {
            "Müller","Schmidt","Schneider",
            "Fischer","Weber","Meyer",
            "Wagner","Becker"
        }
    },

    new()
    {
        Regio = "Spaans",
        Voornamen =
        {
            "Carlos","Alejandro","Javier",
            "Diego","Pablo","Lucia",
            "Maria","Sofia","Valeria"
        },
        Familienamen =
        {
            "Garcia","Rodriguez","Gonzalez",
            "Fernandez","Lopez","Martinez",
            "Perez","Ruiz"
        }
    },

    new()
    {
        Regio = "Italiaans",
        Voornamen =
        {
            "Marco","Lorenzo","Giovanni",
            "Francesco","Matteo",
            "Giulia","Chiara","Martina"
        },
        Familienamen =
        {
            "Rossi","Russo","Ferrari",
            "Esposito","Romano",
            "Ricci","Marino"
        }
    },

    new()
    {
        Regio = "Arabisch",
        Voornamen =
        {
            "Ahmed","Mohammed","Omar",
            "Youssef","Karim",
            "Fatima","Amina","Layla",
            "Yasmin","Mariam"
        },
        Familienamen =
        {
            "Hassan","Ali","Rahman",
            "Ahmed","Mahmoud",
            "Abdallah","Farouk",
            "Saleh","Nasser"
        }
    },

    new()
    {
        Regio = "Turks",
        Voornamen =
        {
            "Emre","Can","Burak",
            "Mert","Kerem",
            "Zeynep","Elif",
            "Ayse","Ece"
        },
        Familienamen =
        {
            "Yilmaz","Demir","Kaya",
            "Celik","Sahin",
            "Aydin","Arslan",
            "Kilic","Aslan"
        }
    },

    new()
    {
        Regio = "Chinees",
        Voornamen =
        {
            "Wei","Jun","Li",
            "Mei","Min","Jin"
        },
        Familienamen =
        {
            "Wang","Li","Zhang",
            "Liu","Chen","Yang",
            "Huang","Zhao"
        }
    },

    new()
    {
        Regio = "Japans",
        Voornamen =
        {
            "Haruto","Yuki","Sora",
            "Kenji","Aiko","Sakura"
        },
        Familienamen =
        {
            "Sato","Suzuki","Tanaka",
            "Ito","Yamamoto",
            "Nakamura"
        }
    },

    new()
    {
        Regio = "Koreaans",
        Voornamen =
        {
            "Minjun","Jiho",
            "Seojun","Hana",
            "Jisoo","Yuna"
        },
        Familienamen =
        {
            "Kim","Lee","Park",
            "Choi","Jung","Kang"
        }
    },

    new()
    {
        Regio = "Afrikaans",
        Voornamen =
        {
            "Kwame","Kofi","Ayo",
            "Tunde","Chinedu",
            "Ama","Zola",
            "Nia","Aisha","Thandi"
        },
        Familienamen =
        {
            "Okafor","Mensah",
            "Diallo","Traore",
            "Kamara","Ndlovu",
            "Moyo","Abebe",
            "Bekele","Tesfaye"
        }
    }
};

       private static string[] domeinen =
{
    "gmail.com",
    "outlook.com",
    "hotmail.com",
    "yahoo.com",
    "icloud.com",
    "proton.me",
    "student.edu"
};

        
        private static Passagier MaakPassagier()
        {
            var rnd = new Random();
            var groep = naamGroepen[rnd.Next(naamGroepen.Count)];

            string voornaam =
                groep.Voornamen[rnd.Next(groep.Voornamen.Count)];

            string familienaam =
                groep.Familienamen[rnd.Next(groep.Familienamen.Count)];

            return new Passagier
            {
                Voornaam = voornaam,
                Naam = familienaam,
                Emailadres = $"{voornaam}.{familienaam}{rnd.Next(1000)}@{domeinen[rnd.Next(domeinen.Length)]}".ToLower(),
                RijNummer = rnd.Next(1, 41),
                StoelNummer = $"{(char)('A' + rnd.Next(6))}",
                SoortTicket = ticketTypes[rnd.Next(ticketTypes.Length)]
            };
        }
    }

    public class NaamGroep
    {
        public string Regio { get; set; }

        public List<string> Voornamen { get; set; } = new();
        public List<string> Familienamen { get; set; } = new();
    }
}
