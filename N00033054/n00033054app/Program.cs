
using Microsoft.EntityFrameworkCore;
using n00033054app.BD;
using n00033054app.Repositorios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DbEntities>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("conn"))
    );

builder.Services.AddTransient<ICuentaRepositorio, CuentaRepositorio>();
builder.Services.AddTransient<IIngresoRepositorio, IngresoRepositorio>();
builder.Services.AddTransient<IGastoRepositorio, GastoRepositorio>();

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
    pattern: "{controller=Cuenta}/{action=Index}/{id?}");

app.Run();
