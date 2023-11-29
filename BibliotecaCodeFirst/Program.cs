using Microsoft.EntityFrameworkCore;
using DAL;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Contexto>(
     o => o.UseNpgsql(builder.Configuration.GetConnectionString(
         "Host=localhost;Port=5432;Database=bibliotecaRapidos;User Id=postgres;Password=1234;SearchPath=public"
)));
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();