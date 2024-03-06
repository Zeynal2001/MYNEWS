using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MYNEWS.Data;
using MYNEWS.Entities;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddIdentity<AppUser, IdentityRole>(op =>
{
    //op.Password.RequireUppercase = false;
    //op.Password.RequireNonAlphanumeric = false;
})
    .AddDefaultTokenProviders()
    .AddEntityFrameworkStores<AppDbContext>();




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

app.UseAuthentication(); // Istifadeci Login edibmi
app.UseAuthorization(); // Istifadeci Login etse bele icazesi varmi(rollar burda isimize yarayir)

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
