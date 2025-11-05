
using IData;
using ILogic;
using Logic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyGaming_Classes;
using MyGaming_MySQL;

using IHost host = Host.CreateDefaultBuilder().ConfigureServices(s =>
{
    s.AddScoped<IGameLogic, GameLogic>();
    s.AddScoped<IGameData, MySQLDatabase>();
}).Build();

var newgame = new Game();
Console.Write("Geef een titel: ");
newgame.Naam = Console.ReadLine();
Console.Write("Geef een rating: ");
newgame.Rating = Convert.ToSingle(Console.ReadLine());

var gameLogic = host.Services.GetService<IGameLogic>();
gameLogic.AddGame(newgame);