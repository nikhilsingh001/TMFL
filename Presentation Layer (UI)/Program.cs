using DataAccessLayer.Models;
using DataAccessLayer.DataContext;
using DataAccessLayer.Repository.Contract;
using DataAccessLayer.Repository;
using BusinessLayer.Service.Contract;
using BusinessLayer.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DataContext>(options =>  options.UseSqlServer(builder.Configuration.GetConnectionString("myconn")));
builder.Services.AddTransient(typeof(IGenericRepository<>),typeof(GenericRepository<>));
builder.Services.AddScoped<IEmp, ServiceEmp>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseDefaultFiles();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Emp}/{action=Index}/{id?}");

app.Run();
