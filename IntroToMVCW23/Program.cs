using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using IntroToMVCW23.Data;
using Microsoft.AspNetCore.Identity;
using IntroToMVCW23.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);

string connectionString = "IntroIdentityDbContextConnection";

builder.Services.AddDbContext<IntroIdentityDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString(connectionString) ?? throw new InvalidOperationException("Connection string not found.")));

// userManager, signInManager, roleManager
builder.Services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<IntroIdentityDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

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
app.UseAuthentication();;

app.UseAuthorization();

// home/privacy

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
