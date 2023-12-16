using Microsoft.EntityFrameworkCore;
using MvcProje2.Utility;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<UygulamaDbContext>(options => // bu iki satýrda gerekli köpru yolu yolu baðlantýlarýný kuruyoruz
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));//  bu bizim entitity ile db arasýndaki köprü görevi gören bir linktir

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
