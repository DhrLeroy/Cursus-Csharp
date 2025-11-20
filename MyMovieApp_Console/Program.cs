using IMovieLogic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MovieLogic;
using MyMovieApp_classes;
using MyMovieApp_Data;
using MyMovieApp_MySQL;

using IHost host = Host.CreateDefaultBuilder(args).ConfigureServices( s =>
{
    s.AddScoped<IMovieController, MovieController>();
    s.AddScoped<IMovieData, MYSQLDatabase>();
}).Build();

var logic = host.Services.GetService<IMovieController>();

Console.Write("Wil je data toevoegen aan de databank? (Y/N) ");

if(Console.ReadLine().Equals("y", StringComparison.CurrentCultureIgnoreCase))
{
    var rocky4 = new Movie();
    rocky4.Title = "Rocky IV";
    rocky4.Release = new DateTime(1985, 11, 27);

    var sylvesterstallone = new Actor();
    sylvesterstallone.First_name = "Sylvester";
    sylvesterstallone.Last_name = "Stallone";
    sylvesterstallone.Birthday = new DateTime(1946, 7, 6);
    rocky4.Cast.Add(sylvesterstallone);

    var minecraft = new Movie();
    minecraft.Title = "Minecraft: The Movie";
    minecraft.Release = new DateTime(2025, 4, 2);

    var jackblack = new Actor();
    jackblack.First_name = "Jack";
    jackblack.Last_name = "Black";
    jackblack.Birthday = new DateTime(1969, 8, 28);
    minecraft.Cast.Add(jackblack);

    var jasonmomoa = new Actor();
    jasonmomoa.First_name = "Jason";
    jasonmomoa.Last_name = "Momoa";
    jasonmomoa.Birthday = new DateTime(1979, 8, 1);
    minecraft.Cast.Add(jasonmomoa);

    logic.SaveMovie(rocky4);

    logic.SaveMovie(minecraft);

}