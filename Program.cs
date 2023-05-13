global using Microsoft.EntityFrameworkCore;
global using ScladCRUD.Models;
global using ScladCRUD.Controllers;
global using Microsoft.AspNetCore.Mvc;
global using System;

var builder = WebApplication.CreateBuilder(args);
string connection = builder.Configuration.GetConnectionString("ApiConnection");

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ScladContext>(options =>
options.UseNpgsql(connection));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
