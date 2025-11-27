using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyCheese_ILogic;
using MyCheese_Logic;
using MyCheeses_Data;
using MyCheeses_MySQL;

using IHost host = Host.CreateDefaultBuilder(args).ConfigureServices(services =>
{
    services.AddScoped<ICheeseLogic, CheeseController>();
    services.AddScoped<ICheeseData, MySQLDatabase>();
}).Build();

