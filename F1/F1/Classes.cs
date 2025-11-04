using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1
{
    public class Race
    {
        public string Naam { get;set; }
        public DateOnly Datum { get; set; }
        public List<Deelname> Deelnames { get; set; } = new List<Deelname>();

        public Race(string naam, DateOnly datum)
        {
            Naam = naam;
            Datum = datum;
        }

        public void VoegUitslagToe(Driver driver, TimeSpan straftijd, params TimeSpan[] tijden)
        {
            Deelnames.Add(new Deelname(this, straftijd, driver, tijden));
        }
    }
    public class Deelname
    {
        public Race Wedstrijd { get; set; }
        public List<TimeSpan> Tijden { get; set; } = new List<TimeSpan>();
        public TimeSpan TotaleStraftijd { get; set; }
        public Driver Driver { get; set; }

        public Deelname(Race wedstrijd, TimeSpan totaleStraftijd, Driver driver, params TimeSpan[] tijden)
        {
            Wedstrijd = wedstrijd;
            TotaleStraftijd = totaleStraftijd;
            Driver = driver;
            Tijden = tijden.ToList();
        }
    }
    public class Car
    {
        public string Serienummer { get; set; }
        public int Vermogen_PK { get; set; }
        public double Gewicht { get; set; }

        public Car(string serienummer, int vermogen_PK, double gewicht)
        {
            Serienummer = serienummer;
            Vermogen_PK = vermogen_PK;
            Gewicht = gewicht;
        }
    }
    public class Team
    {
        public string Naam { get; set; }
        public List<Driver> Drivers { get; set; } = new List<Driver>();
        public List<Car> Autos { get; set; } = new List<Car>();

        public Team(string naam, Driver[] drivers, params Car[] autos)
        {
            Naam = naam;
            Drivers = drivers.ToList();
            Autos = autos.ToList();
        }
    }
    public enum Country
    {
        Nederland,
        Australië,
        VerenigdKoninkrijk,
        Italië,
        Monaco,
        Finland,
        Denemarken,
        NieuwZeeland,
        Spanje,
        Canada,
        Frankrijk,
        Thailand,
        VS,
        Duitsland,
        Japan
    }
    public class Driver
    {
        public string Naam { get; set; }
        public Country Land { get; set; }
        public Team Team { get; set; }
        public List<Deelname> Uitslagen { get; set; } = new List<Deelname>();

        public Driver(string naam, Country land)
        {
            Naam = naam;
            Land = land;
        }
    }
}
