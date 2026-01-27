using MyMotorbikeStore_Controllers;
using MyMotorbikeStore_Data;
using MyMotorbikeStore_MySQL;
using MyMotorbikeStore_Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddScoped<IMotorbikeService, MotorbikeController>();
builder.Services.AddScoped<IMotorbikeData, MySQLDatabase>();
builder.Services.AddScoped<MySQLDatabase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
