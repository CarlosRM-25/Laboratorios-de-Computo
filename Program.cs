using Gestión_de_Reservas.Data;
using Gestión_de_Reservas.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
// Registrar el repositorio como singleton para mantener datos en memoria durante la vida de la app
builder.Services.AddSingleton<IReservasRepo, InMemoryReservasRepo>();


var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}


app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
name: "default",
pattern: "{controller=Reservations}/{action=Index}/{id?}");


app.Run();
