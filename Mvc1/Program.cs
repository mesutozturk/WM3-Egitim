//Configure services

using Microsoft.EntityFrameworkCore;
using Mvc1.Data;
using Mvc1.Services.Email;
using SendGrid.Extensions.DependencyInjection;

//mevcut bir dbden entityframework tablolarını aktarmak için
//Scaffold-DbContext "Data Source=MESUT-WS;Initial Catalog=Northwind;User ID=sa;Password=123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models


var builder = WebApplication.CreateBuilder(args);

string con1 = builder.Configuration.GetConnectionString("con1");

builder.Services.AddDbContext<NorthwindContext>(options =>
{
    options.UseSqlServer(con1);
});

builder.Services.AddTransient<IMailService, YandexEmailService>();
builder.Services.AddSendGrid(options =>
{
    options.ApiKey = "Key";
});
builder.Services.AddControllersWithViews();
// builder.Services.AddRazorPages();
// builder.Services.AddServerSideBlazor();

var app = builder.Build();
//Configure - Middleware
app.UseHttpsRedirection();
app.UseStaticFiles(); //wwwroot içindeki statik (html-css-js-img-video-audio)
//app.UseCookiePolicy();
app.UseRouting();
// app.UseAuthentication();
// app.UseAuthorization();
//app.UseSession();
//app.MapRazorPages();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();