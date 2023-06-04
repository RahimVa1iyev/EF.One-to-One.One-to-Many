using Microsoft.EntityFrameworkCore;
using YummyEf.DAL;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<YummyDbContext>(opt =>
opt.UseSqlServer("Server=localhost\\MSSQLSERVER02;;Database=YummyTemplateDB;Integrated Security=True;"));
var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=home}/{action=index}/{id?}"
    );

app.UseStaticFiles();

app.Run();