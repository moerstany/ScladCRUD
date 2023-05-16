global using Microsoft.EntityFrameworkCore;
global using ScladCRUD.Models;
global using ScladCRUD.Controllers;
global using Microsoft.AspNetCore.Mvc;
global using System;
global using System.Security.Cryptography;
global using Microsoft.IdentityModel.Tokens;
global using System.Text;
global using Microsoft.AspNetCore.Authentication.JwtBearer;




var builder = WebApplication.CreateBuilder(args);
string connection = builder.Configuration.GetConnectionString("ApiConnection");

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ScladContext>(options =>
options.UseNpgsql(connection));

var tkConf = builder.Configuration.GetSection("Jwt");
var tokenValidationParameters = new TokenValidationParameters
{
ValidateIssuer = true,
ValidateAudience = true,
ValidateLifetime = true,
ValidateIssuerSigningKey = true,
    ValidIssuer = tkConf["Issuer"],
    ValidAudience = tkConf["Audience"],
    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tkConf["Key"]))
};

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(o =>
    {
        o.TokenValidationParameters = tokenValidationParameters;
    });

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
