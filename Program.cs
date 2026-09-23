using Microsoft.EntityFrameworkCore;
using TP02.Data;

var builder = WebApplication.CreateBuilder(args);

// Adicionar suporte para MVC (Controllers com Views)
builder.Services.AddControllersWithViews();

// Registar o AppDbContext com a Connection String
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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